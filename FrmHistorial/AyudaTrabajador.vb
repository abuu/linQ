Imports System.Linq

Public Class AyudaTrabajador
    Dim db As New dbDataContext
    Private Sub AyudaTrabajador_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim query = From trab In db.trabajador _
                    Select Código = trab.TRAB_CODIGO, Nombre = trab.TRAB_RAZONSOCIAL

        DgvTrabajador.DataSource = query

    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        Dim query = From dat In db.dato_rpt Join hist In db.historial On dat.DATO_ID Equals hist.DATO_ID _
                    Select dat.DATO_ID, dat.DATO_DESC, hist.HIST_TEXTO

        Form1.DgvHistorial.DataSource = query
        Dim i As Integer = DgvTrabajador.CurrentRow.Index
        Form1.TxtCodigo.Text = DgvTrabajador.Item(0, i).Value
        Form1.TxtNombre.Text = DgvTrabajador.Item(1, i).Value
        Form1.btnCargar.Enabled = True
        Me.Close()
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub
End Class