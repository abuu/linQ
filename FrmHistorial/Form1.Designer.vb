<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpValor = New System.Windows.Forms.DateTimePicker()
        Me.cmbValor = New System.Windows.Forms.ComboBox()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.btnDeshacer = New System.Windows.Forms.Button()
        Me.DgvHistorial = New System.Windows.Forms.DataGridView()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DgvHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Valor"
        '
        'dtpValor
        '
        Me.dtpValor.CustomFormat = "dd/MM/yyyy"
        Me.dtpValor.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpValor.Location = New System.Drawing.Point(69, 44)
        Me.dtpValor.Name = "dtpValor"
        Me.dtpValor.ShowCheckBox = True
        Me.dtpValor.Size = New System.Drawing.Size(100, 20)
        Me.dtpValor.TabIndex = 30
        '
        'cmbValor
        '
        Me.cmbValor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbValor.FormattingEnabled = True
        Me.cmbValor.Location = New System.Drawing.Point(69, 43)
        Me.cmbValor.Name = "cmbValor"
        Me.cmbValor.Size = New System.Drawing.Size(399, 21)
        Me.cmbValor.TabIndex = 29
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(69, 44)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(399, 20)
        Me.txtValor.TabIndex = 28
        '
        'btnCargar
        '
        Me.btnCargar.Location = New System.Drawing.Point(484, 75)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(75, 23)
        Me.btnCargar.TabIndex = 27
        Me.btnCargar.Text = "Cargar"
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'btnGrabar
        '
        Me.btnGrabar.Location = New System.Drawing.Point(484, 104)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(75, 23)
        Me.btnGrabar.TabIndex = 26
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'btnDeshacer
        '
        Me.btnDeshacer.Location = New System.Drawing.Point(484, 134)
        Me.btnDeshacer.Name = "btnDeshacer"
        Me.btnDeshacer.Size = New System.Drawing.Size(75, 23)
        Me.btnDeshacer.TabIndex = 25
        Me.btnDeshacer.Text = "Deshacer"
        Me.btnDeshacer.UseVisualStyleBackColor = True
        '
        'DgvHistorial
        '
        Me.DgvHistorial.AllowUserToAddRows = False
        Me.DgvHistorial.AllowUserToDeleteRows = False
        Me.DgvHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvHistorial.Location = New System.Drawing.Point(12, 75)
        Me.DgvHistorial.MultiSelect = False
        Me.DgvHistorial.Name = "DgvHistorial"
        Me.DgvHistorial.ReadOnly = True
        Me.DgvHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvHistorial.Size = New System.Drawing.Size(456, 177)
        Me.DgvHistorial.TabIndex = 24
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(209, 9)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.ReadOnly = True
        Me.TxtNombre.Size = New System.Drawing.Size(259, 20)
        Me.TxtNombre.TabIndex = 23
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(175, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(28, 23)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Location = New System.Drawing.Point(69, 7)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.TxtCodigo.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Código"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 275)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpValor)
        Me.Controls.Add(Me.cmbValor)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.btnCargar)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.btnDeshacer)
        Me.Controls.Add(Me.DgvHistorial)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtCodigo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DgvHistorial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpValor As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbValor As System.Windows.Forms.ComboBox
    Friend WithEvents txtValor As System.Windows.Forms.TextBox
    Friend WithEvents btnCargar As System.Windows.Forms.Button
    Friend WithEvents btnGrabar As System.Windows.Forms.Button
    Friend WithEvents btnDeshacer As System.Windows.Forms.Button
    Friend WithEvents DgvHistorial As System.Windows.Forms.DataGridView
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TxtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
