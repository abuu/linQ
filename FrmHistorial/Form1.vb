Public Class Form1
    Dim db As New dbDataContext
    Dim lbActivo As Boolean = False
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        AyudaTrabajador.Show(Me)
    End Sub
    Private Sub Form1_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If lbActivo Then Exit Sub
        lbActivo = True
        Call Instancia(0)
        btnCargar.Enabled = False
    End Sub

    Private Sub Instancia(ByVal Index As Byte)
        Select Case Index
            Case 0 'Deshacer
                btnCargar.Enabled = True
                btnGrabar.Enabled = False
                btnDeshacer.Enabled = False
                txtValor.Visible = False
                txtValor.Text = ""
                cmbValor.Visible = False
                cmbValor.DataSource = Nothing
                dtpValor.Visible = False
                dtpValor.Value = Now
                dtpValor.Checked = False
                DgvHistorial.Enabled = True
            Case 1 'Edicion
                btnCargar.Enabled = False
                btnGrabar.Enabled = True
                btnDeshacer.Enabled = True
                DgvHistorial.Enabled = False
        End Select
    End Sub

    Private Sub btnCargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargar.Click
        Dim i As Integer = DgvHistorial.CurrentRow.Index
        Dim tipocontrol = From Dato_rpt In db.dato_rpt _
Where CLng(Dato_rpt.DATO_ID) = DgvHistorial.Item(0, i).Value Select Dato_rpt.DATO_TIPOCONTROL

        MessageBox.Show(tipocontrol.ToString)

        Select Case Integer.Parse(tipocontrol.ToString)
            Case 1 'ComboBox
                cmbValor.Visible = True
                txtValor.Visible = False
                dtpValor.Visible = False
                
            Case 2 'TextBox
                txtValor.Visible = True
                cmbValor.Visible = False
                dtpValor.Visible = False

            Case 3 'DateTime
                dtpValor.Visible = True
                cmbValor.Visible = False
                txtValor.Visible = False
                
        End Select
        Call Instancia(1)



    End Sub

    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        Dim i As Integer = DgvHistorial.CurrentRow.Index
        Dim tipocontrol = From Dato_rpt In db.dato_rpt _
Where _
  CLng(Dato_rpt.DATO_ID) = DgvHistorial.Item(0, i).Value _
Select New With { _
  Dato_rpt.DATO_TIPOCONTROL _
}
        Dim loTIPO_ID, loTDET_ID, loHIST_FECHA, loHIST_TEXTO

        loTIPO_ID = DBNull.Value
        loTDET_ID = DBNull.Value
        loHIST_FECHA = DBNull.Value
        loHIST_TEXTO = DBNull.Value
        Dim trab = From Trabajador In db.trabajador _
Where _
  Trabajador.TRAB_CODIGO = CStr(TxtCodigo.Text) _
Select Trabajador.TRAB_ID
        Select Case Integer.Parse(tipocontrol.ToString)
            Case 1 'ComboBox
                If cmbValor.SelectedValue > 0 Then
                    loTDET_ID = cmbValor.SelectedValue
                End If
            Case 2 'TextBox
                loHIST_TEXTO = txtValor.Text
            Case 3 'DateTime
                If dtpValor.Checked Then
                    loHIST_FECHA = dtpValor.Value
                End If
        End Select
        If Not trab Is Nothing Then
            Dim queryHistorial = _
 From Historial In db.historial _
 Where _
   Historial.TRAB_ID = _
  (((From Historial0 In db.historial _
  Select New With { _
    Historial0.TRAB_ID _
  }).Distinct()).First().TRAB_ID) And _
   CLng(Historial.DATO_ID) = DgvHistorial.Item(0, i).Value _
 Select Historial
            
            For Each Historial As historial In queryHistorial
                Historial.TIPO_ID = loTIPO_ID
                Historial.TDET_ID = loTDET_ID
                Historial.HIST_FECHA = loHIST_FECHA
                Historial.HIST_TEXTO = loHIST_TEXTO
            Next
            db.SubmitChanges()

        Else
            Dim iHistorial As New historial With { _
 .TRAB_ID = (((From Historial0 In db.historial _
  Select New With { _
    Historial0.TRAB_ID _
  }).Distinct()).First().TRAB_ID), _
 .DATO_ID = DgvHistorial.Item(0, i).Value, _
 .TIPO_ID = loTIPO_ID, _
 .TDET_ID = loTDET_ID, _
 .HIST_FECHA = loHIST_FECHA, _
 .HIST_TEXTO = loHIST_TEXTO _
}
            db.historial.InsertOnSubmit(iHistorial)
            db.SubmitChanges()

        End If
    End Sub

    Private Sub btnDeshacer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeshacer.Click
        Call Instancia(0)
    End Sub
End Class
