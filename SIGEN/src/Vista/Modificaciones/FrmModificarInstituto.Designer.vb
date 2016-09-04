<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificarInstituto
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gbxDireccion = New System.Windows.Forms.GroupBox
        Me.ckbBIS = New System.Windows.Forms.CheckBox
        Me.lblNumero = New System.Windows.Forms.Label
        Me.txtNumero = New System.Windows.Forms.TextBox
        Me.lblCalle = New System.Windows.Forms.Label
        Me.txtCalle = New System.Windows.Forms.TextBox
        Me.lblSitioWeb = New System.Windows.Forms.Label
        Me.txtSitioWeb = New System.Windows.Forms.TextBox
        Me.lblEmail = New System.Windows.Forms.Label
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.lblNombre = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.btnBajaTelefono = New System.Windows.Forms.Button
        Me.txtTelefono = New System.Windows.Forms.TextBox
        Me.btnAltaTelefono = New System.Windows.Forms.Button
        Me.lbxTelefono = New System.Windows.Forms.ListBox
        Me.lblTelefono = New System.Windows.Forms.Label
        Me.gbxDireccion.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxDireccion
        '
        Me.gbxDireccion.Controls.Add(Me.ckbBIS)
        Me.gbxDireccion.Controls.Add(Me.lblNumero)
        Me.gbxDireccion.Controls.Add(Me.txtNumero)
        Me.gbxDireccion.Controls.Add(Me.lblCalle)
        Me.gbxDireccion.Controls.Add(Me.txtCalle)
        Me.gbxDireccion.Location = New System.Drawing.Point(15, 90)
        Me.gbxDireccion.Name = "gbxDireccion"
        Me.gbxDireccion.Size = New System.Drawing.Size(270, 270)
        Me.gbxDireccion.TabIndex = 136
        Me.gbxDireccion.TabStop = False
        Me.gbxDireccion.Text = "Dirección"
        '
        'ckbBIS
        '
        Me.ckbBIS.AutoSize = True
        Me.ckbBIS.Location = New System.Drawing.Point(221, 48)
        Me.ckbBIS.Name = "ckbBIS"
        Me.ckbBIS.Size = New System.Drawing.Size(43, 17)
        Me.ckbBIS.TabIndex = 4
        Me.ckbBIS.Text = "BIS"
        Me.ckbBIS.UseVisualStyleBackColor = True
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Location = New System.Drawing.Point(6, 48)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(96, 13)
        Me.lblNumero.TabIndex = 3
        Me.lblNumero.Text = "Número de Puerta:"
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(108, 45)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(107, 20)
        Me.txtNumero.TabIndex = 2
        '
        'lblCalle
        '
        Me.lblCalle.AutoSize = True
        Me.lblCalle.Location = New System.Drawing.Point(6, 22)
        Me.lblCalle.Name = "lblCalle"
        Me.lblCalle.Size = New System.Drawing.Size(33, 13)
        Me.lblCalle.TabIndex = 1
        Me.lblCalle.Text = "Calle:"
        '
        'txtCalle
        '
        Me.txtCalle.Location = New System.Drawing.Point(59, 19)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(205, 20)
        Me.txtCalle.TabIndex = 0
        '
        'lblSitioWeb
        '
        Me.lblSitioWeb.AutoSize = True
        Me.lblSitioWeb.Location = New System.Drawing.Point(12, 67)
        Me.lblSitioWeb.Name = "lblSitioWeb"
        Me.lblSitioWeb.Size = New System.Drawing.Size(56, 13)
        Me.lblSitioWeb.TabIndex = 135
        Me.lblSitioWeb.Text = "Sitio Web:"
        '
        'txtSitioWeb
        '
        Me.txtSitioWeb.Location = New System.Drawing.Point(74, 64)
        Me.txtSitioWeb.Name = "txtSitioWeb"
        Me.txtSitioWeb.Size = New System.Drawing.Size(209, 20)
        Me.txtSitioWeb.TabIndex = 134
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(12, 41)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 133
        Me.lblEmail.Text = "Email:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(51, 38)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(232, 20)
        Me.txtEmail.TabIndex = 132
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(12, 15)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 131
        Me.lblNombre.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(65, 12)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(218, 20)
        Me.txtNombre.TabIndex = 130
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.SIGEN.My.Resources.Resources.cancel
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(256, 369)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(105, 30)
        Me.btnCancelar.TabIndex = 124
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = Global.SIGEN.My.Resources.Resources.ok1
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.Location = New System.Drawing.Point(367, 369)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(105, 30)
        Me.btnGuardar.TabIndex = 123
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnBajaTelefono
        '
        Me.btnBajaTelefono.Location = New System.Drawing.Point(450, 58)
        Me.btnBajaTelefono.Name = "btnBajaTelefono"
        Me.btnBajaTelefono.Size = New System.Drawing.Size(23, 23)
        Me.btnBajaTelefono.TabIndex = 141
        Me.btnBajaTelefono.Text = "-"
        Me.btnBajaTelefono.UseVisualStyleBackColor = True
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(292, 31)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(152, 20)
        Me.txtTelefono.TabIndex = 140
        '
        'btnAltaTelefono
        '
        Me.btnAltaTelefono.Location = New System.Drawing.Point(450, 29)
        Me.btnAltaTelefono.Name = "btnAltaTelefono"
        Me.btnAltaTelefono.Size = New System.Drawing.Size(23, 23)
        Me.btnAltaTelefono.TabIndex = 139
        Me.btnAltaTelefono.Text = "+"
        Me.btnAltaTelefono.UseVisualStyleBackColor = True
        '
        'lbxTelefono
        '
        Me.lbxTelefono.FormattingEnabled = True
        Me.lbxTelefono.Location = New System.Drawing.Point(292, 57)
        Me.lbxTelefono.Name = "lbxTelefono"
        Me.lbxTelefono.Size = New System.Drawing.Size(152, 303)
        Me.lbxTelefono.TabIndex = 138
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(289, 15)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(52, 13)
        Me.lblTelefono.TabIndex = 137
        Me.lblTelefono.Text = "Telefono:"
        '
        'FrmModificarInstituto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 411)
        Me.Controls.Add(Me.btnBajaTelefono)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.btnAltaTelefono)
        Me.Controls.Add(Me.lbxTelefono)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.gbxDireccion)
        Me.Controls.Add(Me.lblSitioWeb)
        Me.Controls.Add(Me.txtSitioWeb)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Name = "FrmModificarInstituto"
        Me.Text = "Modificar Instituto"
        Me.gbxDireccion.ResumeLayout(False)
        Me.gbxDireccion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbxDireccion As System.Windows.Forms.GroupBox
    Friend WithEvents ckbBIS As System.Windows.Forms.CheckBox
    Friend WithEvents lblNumero As System.Windows.Forms.Label
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents lblCalle As System.Windows.Forms.Label
    Friend WithEvents txtCalle As System.Windows.Forms.TextBox
    Friend WithEvents lblSitioWeb As System.Windows.Forms.Label
    Friend WithEvents txtSitioWeb As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnBajaTelefono As System.Windows.Forms.Button
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents btnAltaTelefono As System.Windows.Forms.Button
    Friend WithEvents lbxTelefono As System.Windows.Forms.ListBox
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
End Class
