<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInstituto
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
        Me.lblTelefono = New System.Windows.Forms.Label
        Me.ltbTelefono = New System.Windows.Forms.ListBox
        Me.gbxDireccion = New System.Windows.Forms.GroupBox
        Me.lblConsultarNumero = New System.Windows.Forms.Label
        Me.lblConsultarCalle = New System.Windows.Forms.Label
        Me.ckbBIS = New System.Windows.Forms.CheckBox
        Me.lblNumero = New System.Windows.Forms.Label
        Me.lblCalle = New System.Windows.Forms.Label
        Me.lblSitioWeb = New System.Windows.Forms.Label
        Me.lblEmail = New System.Windows.Forms.Label
        Me.lblNombre = New System.Windows.Forms.Label
        Me.lblRUT = New System.Windows.Forms.Label
        Me.lblConsultarSitioWeb = New System.Windows.Forms.Label
        Me.lblConsultarEmail = New System.Windows.Forms.Label
        Me.lblConsultarNombre = New System.Windows.Forms.Label
        Me.lblConsultarRUT = New System.Windows.Forms.Label
        Me.ltbSectores = New System.Windows.Forms.ListBox
        Me.lblSectores = New System.Windows.Forms.Label
        Me.lblSocios = New System.Windows.Forms.Label
        Me.ltbSocios = New System.Windows.Forms.ListBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnModificar = New System.Windows.Forms.Button
        Me.gbxDireccion.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(12, 214)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(52, 13)
        Me.lblTelefono.TabIndex = 24
        Me.lblTelefono.Text = "Telefono:"
        '
        'ltbTelefono
        '
        Me.ltbTelefono.FormattingEnabled = True
        Me.ltbTelefono.Items.AddRange(New Object() {""})
        Me.ltbTelefono.Location = New System.Drawing.Point(15, 230)
        Me.ltbTelefono.Name = "ltbTelefono"
        Me.ltbTelefono.Size = New System.Drawing.Size(269, 225)
        Me.ltbTelefono.TabIndex = 23
        '
        'gbxDireccion
        '
        Me.gbxDireccion.Controls.Add(Me.lblConsultarNumero)
        Me.gbxDireccion.Controls.Add(Me.lblConsultarCalle)
        Me.gbxDireccion.Controls.Add(Me.ckbBIS)
        Me.gbxDireccion.Controls.Add(Me.lblNumero)
        Me.gbxDireccion.Controls.Add(Me.lblCalle)
        Me.gbxDireccion.Location = New System.Drawing.Point(15, 110)
        Me.gbxDireccion.Name = "gbxDireccion"
        Me.gbxDireccion.Size = New System.Drawing.Size(270, 101)
        Me.gbxDireccion.TabIndex = 122
        Me.gbxDireccion.TabStop = False
        Me.gbxDireccion.Text = "Dirección"
        '
        'lblConsultarNumero
        '
        Me.lblConsultarNumero.AutoSize = True
        Me.lblConsultarNumero.Location = New System.Drawing.Point(108, 48)
        Me.lblConsultarNumero.Name = "lblConsultarNumero"
        Me.lblConsultarNumero.Size = New System.Drawing.Size(93, 13)
        Me.lblConsultarNumero.TabIndex = 6
        Me.lblConsultarNumero.Text = "Número de Puerta"
        '
        'lblConsultarCalle
        '
        Me.lblConsultarCalle.AutoSize = True
        Me.lblConsultarCalle.Location = New System.Drawing.Point(108, 22)
        Me.lblConsultarCalle.Name = "lblConsultarCalle"
        Me.lblConsultarCalle.Size = New System.Drawing.Size(30, 13)
        Me.lblConsultarCalle.TabIndex = 5
        Me.lblConsultarCalle.Text = "Calle"
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
        'lblCalle
        '
        Me.lblCalle.AutoSize = True
        Me.lblCalle.Location = New System.Drawing.Point(6, 22)
        Me.lblCalle.Name = "lblCalle"
        Me.lblCalle.Size = New System.Drawing.Size(33, 13)
        Me.lblCalle.TabIndex = 1
        Me.lblCalle.Text = "Calle:"
        '
        'lblSitioWeb
        '
        Me.lblSitioWeb.AutoSize = True
        Me.lblSitioWeb.Location = New System.Drawing.Point(12, 87)
        Me.lblSitioWeb.Name = "lblSitioWeb"
        Me.lblSitioWeb.Size = New System.Drawing.Size(56, 13)
        Me.lblSitioWeb.TabIndex = 121
        Me.lblSitioWeb.Text = "Sitio Web:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(12, 61)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 119
        Me.lblEmail.Text = "Email:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(12, 35)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 117
        Me.lblNombre.Text = "Nombre:"
        '
        'lblRUT
        '
        Me.lblRUT.AutoSize = True
        Me.lblRUT.Location = New System.Drawing.Point(12, 9)
        Me.lblRUT.Name = "lblRUT"
        Me.lblRUT.Size = New System.Drawing.Size(33, 13)
        Me.lblRUT.TabIndex = 115
        Me.lblRUT.Text = "RUT:"
        '
        'lblConsultarSitioWeb
        '
        Me.lblConsultarSitioWeb.AutoSize = True
        Me.lblConsultarSitioWeb.Location = New System.Drawing.Point(74, 87)
        Me.lblConsultarSitioWeb.Name = "lblConsultarSitioWeb"
        Me.lblConsultarSitioWeb.Size = New System.Drawing.Size(53, 13)
        Me.lblConsultarSitioWeb.TabIndex = 126
        Me.lblConsultarSitioWeb.Text = "Sitio Web"
        '
        'lblConsultarEmail
        '
        Me.lblConsultarEmail.AutoSize = True
        Me.lblConsultarEmail.Location = New System.Drawing.Point(74, 61)
        Me.lblConsultarEmail.Name = "lblConsultarEmail"
        Me.lblConsultarEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblConsultarEmail.TabIndex = 125
        Me.lblConsultarEmail.Text = "Email"
        '
        'lblConsultarNombre
        '
        Me.lblConsultarNombre.AutoSize = True
        Me.lblConsultarNombre.Location = New System.Drawing.Point(74, 35)
        Me.lblConsultarNombre.Name = "lblConsultarNombre"
        Me.lblConsultarNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblConsultarNombre.TabIndex = 124
        Me.lblConsultarNombre.Text = "Nombre"
        '
        'lblConsultarRUT
        '
        Me.lblConsultarRUT.AutoSize = True
        Me.lblConsultarRUT.Location = New System.Drawing.Point(74, 9)
        Me.lblConsultarRUT.Name = "lblConsultarRUT"
        Me.lblConsultarRUT.Size = New System.Drawing.Size(30, 13)
        Me.lblConsultarRUT.TabIndex = 123
        Me.lblConsultarRUT.Text = "RUT"
        '
        'ltbSectores
        '
        Me.ltbSectores.FormattingEnabled = True
        Me.ltbSectores.Location = New System.Drawing.Point(335, 22)
        Me.ltbSectores.Name = "ltbSectores"
        Me.ltbSectores.Size = New System.Drawing.Size(167, 433)
        Me.ltbSectores.TabIndex = 127
        '
        'lblSectores
        '
        Me.lblSectores.AutoSize = True
        Me.lblSectores.Location = New System.Drawing.Point(332, 9)
        Me.lblSectores.Name = "lblSectores"
        Me.lblSectores.Size = New System.Drawing.Size(52, 13)
        Me.lblSectores.TabIndex = 128
        Me.lblSectores.Text = "Sectores:"
        '
        'lblSocios
        '
        Me.lblSocios.AutoSize = True
        Me.lblSocios.Location = New System.Drawing.Point(556, 9)
        Me.lblSocios.Name = "lblSocios"
        Me.lblSocios.Size = New System.Drawing.Size(42, 13)
        Me.lblSocios.TabIndex = 129
        Me.lblSocios.Text = "Socios:"
        '
        'ltbSocios
        '
        Me.ltbSocios.FormattingEnabled = True
        Me.ltbSocios.Location = New System.Drawing.Point(555, 22)
        Me.ltbSocios.Name = "ltbSocios"
        Me.ltbSocios.Size = New System.Drawing.Size(167, 433)
        Me.ltbSocios.TabIndex = 130
        '
        'btnCancel
        '
        Me.btnCancel.Image = Global.SIGEN.My.Resources.Resources.ok1
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.Location = New System.Drawing.Point(617, 469)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(105, 30)
        Me.btnCancel.TabIndex = 131
        Me.btnCancel.Text = "Ok"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModificar.Location = New System.Drawing.Point(506, 469)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(105, 30)
        Me.btnModificar.TabIndex = 132
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'FrmInstituto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 511)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.ltbSocios)
        Me.Controls.Add(Me.lblSocios)
        Me.Controls.Add(Me.lblSectores)
        Me.Controls.Add(Me.ltbSectores)
        Me.Controls.Add(Me.lblConsultarSitioWeb)
        Me.Controls.Add(Me.lblConsultarEmail)
        Me.Controls.Add(Me.lblConsultarNombre)
        Me.Controls.Add(Me.lblConsultarRUT)
        Me.Controls.Add(Me.gbxDireccion)
        Me.Controls.Add(Me.lblSitioWeb)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblRUT)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.ltbTelefono)
        Me.Name = "FrmInstituto"
        Me.Text = "Instituto"
        Me.gbxDireccion.ResumeLayout(False)
        Me.gbxDireccion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents ltbTelefono As System.Windows.Forms.ListBox
    Friend WithEvents gbxDireccion As System.Windows.Forms.GroupBox
    Friend WithEvents ckbBIS As System.Windows.Forms.CheckBox
    Friend WithEvents lblNumero As System.Windows.Forms.Label
    Friend WithEvents lblCalle As System.Windows.Forms.Label
    Friend WithEvents lblSitioWeb As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblRUT As System.Windows.Forms.Label
    Friend WithEvents lblConsultarSitioWeb As System.Windows.Forms.Label
    Friend WithEvents lblConsultarEmail As System.Windows.Forms.Label
    Friend WithEvents lblConsultarNombre As System.Windows.Forms.Label
    Friend WithEvents lblConsultarRUT As System.Windows.Forms.Label
    Friend WithEvents lblConsultarNumero As System.Windows.Forms.Label
    Friend WithEvents lblConsultarCalle As System.Windows.Forms.Label
    Friend WithEvents ltbSectores As System.Windows.Forms.ListBox
    Friend WithEvents lblSectores As System.Windows.Forms.Label
    Friend WithEvents lblSocios As System.Windows.Forms.Label
    Friend WithEvents ltbSocios As System.Windows.Forms.ListBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
End Class
