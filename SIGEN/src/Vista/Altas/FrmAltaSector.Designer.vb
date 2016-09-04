<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAltaSector
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
        Me.lblNumeroSector = New System.Windows.Forms.Label
        Me.txtNumeroSector = New System.Windows.Forms.TextBox
        Me.lblNombre = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.lblInstituto = New System.Windows.Forms.Label
        Me.cmbInstituto = New System.Windows.Forms.ComboBox
        Me.lblActividades = New System.Windows.Forms.Label
        Me.cklActividades = New System.Windows.Forms.CheckedListBox
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblNumeroSector
        '
        Me.lblNumeroSector.AutoSize = True
        Me.lblNumeroSector.Location = New System.Drawing.Point(12, 9)
        Me.lblNumeroSector.Name = "lblNumeroSector"
        Me.lblNumeroSector.Size = New System.Drawing.Size(96, 13)
        Me.lblNumeroSector.TabIndex = 0
        Me.lblNumeroSector.Text = "Número de Sector:"
        '
        'txtNumeroSector
        '
        Me.txtNumeroSector.Location = New System.Drawing.Point(114, 6)
        Me.txtNumeroSector.Name = "txtNumeroSector"
        Me.txtNumeroSector.Size = New System.Drawing.Size(358, 20)
        Me.txtNumeroSector.TabIndex = 1
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(13, 35)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(66, 32)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(406, 20)
        Me.txtNombre.TabIndex = 3
        '
        'lblInstituto
        '
        Me.lblInstituto.AutoSize = True
        Me.lblInstituto.Location = New System.Drawing.Point(13, 61)
        Me.lblInstituto.Name = "lblInstituto"
        Me.lblInstituto.Size = New System.Drawing.Size(47, 13)
        Me.lblInstituto.TabIndex = 4
        Me.lblInstituto.Text = "Instituto:"
        '
        'cmbInstituto
        '
        Me.cmbInstituto.FormattingEnabled = True
        Me.cmbInstituto.Location = New System.Drawing.Point(66, 58)
        Me.cmbInstituto.Name = "cmbInstituto"
        Me.cmbInstituto.Size = New System.Drawing.Size(406, 21)
        Me.cmbInstituto.TabIndex = 5
        '
        'lblActividades
        '
        Me.lblActividades.AutoSize = True
        Me.lblActividades.Location = New System.Drawing.Point(13, 82)
        Me.lblActividades.Name = "lblActividades"
        Me.lblActividades.Size = New System.Drawing.Size(318, 13)
        Me.lblActividades.TabIndex = 6
        Me.lblActividades.Text = "Seleccione las actividades que pueden practicarse en este sector"
        '
        'cklActividades
        '
        Me.cklActividades.FormattingEnabled = True
        Me.cklActividades.Location = New System.Drawing.Point(16, 99)
        Me.cklActividades.Name = "cklActividades"
        Me.cklActividades.Size = New System.Drawing.Size(456, 259)
        Me.cklActividades.TabIndex = 7
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.SIGEN.My.Resources.Resources.cancel
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(256, 369)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(105, 30)
        Me.btnCancelar.TabIndex = 74
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
        Me.btnGuardar.TabIndex = 73
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'FrmAltaSector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 411)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.cklActividades)
        Me.Controls.Add(Me.lblActividades)
        Me.Controls.Add(Me.cmbInstituto)
        Me.Controls.Add(Me.lblInstituto)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtNumeroSector)
        Me.Controls.Add(Me.lblNumeroSector)
        Me.Name = "FrmAltaSector"
        Me.Text = "Nuevo Sector"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNumeroSector As System.Windows.Forms.Label
    Friend WithEvents txtNumeroSector As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblInstituto As System.Windows.Forms.Label
    Friend WithEvents cmbInstituto As System.Windows.Forms.ComboBox
    Friend WithEvents lblActividades As System.Windows.Forms.Label
    Friend WithEvents cklActividades As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
End Class
