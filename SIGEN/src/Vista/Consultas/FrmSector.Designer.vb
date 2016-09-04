<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSector
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
        Me.lblInstituto = New System.Windows.Forms.Label
        Me.lblNumero = New System.Windows.Forms.Label
        Me.lblNombre = New System.Windows.Forms.Label
        Me.lblConsultarNombre = New System.Windows.Forms.Label
        Me.lblConsultarNumero = New System.Windows.Forms.Label
        Me.lblConsultarInstituto = New System.Windows.Forms.Label
        Me.lblActividades = New System.Windows.Forms.Label
        Me.ltbActividades = New System.Windows.Forms.ListBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnModificar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblInstituto
        '
        Me.lblInstituto.AutoSize = True
        Me.lblInstituto.Location = New System.Drawing.Point(12, 9)
        Me.lblInstituto.Name = "lblInstituto"
        Me.lblInstituto.Size = New System.Drawing.Size(47, 13)
        Me.lblInstituto.TabIndex = 0
        Me.lblInstituto.Text = "Instituto:"
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Location = New System.Drawing.Point(12, 32)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(96, 13)
        Me.lblNumero.TabIndex = 1
        Me.lblNumero.Text = "Número de Sector:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(12, 56)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Nombre:"
        '
        'lblConsultarNombre
        '
        Me.lblConsultarNombre.AutoSize = True
        Me.lblConsultarNombre.Location = New System.Drawing.Point(114, 56)
        Me.lblConsultarNombre.Name = "lblConsultarNombre"
        Me.lblConsultarNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblConsultarNombre.TabIndex = 5
        Me.lblConsultarNombre.Text = "Nombre"
        '
        'lblConsultarNumero
        '
        Me.lblConsultarNumero.AutoSize = True
        Me.lblConsultarNumero.Location = New System.Drawing.Point(114, 32)
        Me.lblConsultarNumero.Name = "lblConsultarNumero"
        Me.lblConsultarNumero.Size = New System.Drawing.Size(93, 13)
        Me.lblConsultarNumero.TabIndex = 4
        Me.lblConsultarNumero.Text = "Número de Sector"
        '
        'lblConsultarInstituto
        '
        Me.lblConsultarInstituto.AutoSize = True
        Me.lblConsultarInstituto.Location = New System.Drawing.Point(114, 9)
        Me.lblConsultarInstituto.Name = "lblConsultarInstituto"
        Me.lblConsultarInstituto.Size = New System.Drawing.Size(44, 13)
        Me.lblConsultarInstituto.TabIndex = 3
        Me.lblConsultarInstituto.Text = "Instituto"
        '
        'lblActividades
        '
        Me.lblActividades.AutoSize = True
        Me.lblActividades.Location = New System.Drawing.Point(12, 82)
        Me.lblActividades.Name = "lblActividades"
        Me.lblActividades.Size = New System.Drawing.Size(65, 13)
        Me.lblActividades.TabIndex = 6
        Me.lblActividades.Text = "Actividades:"
        '
        'ltbActividades
        '
        Me.ltbActividades.FormattingEnabled = True
        Me.ltbActividades.Location = New System.Drawing.Point(15, 99)
        Me.ltbActividades.Name = "ltbActividades"
        Me.ltbActividades.Size = New System.Drawing.Size(707, 342)
        Me.ltbActividades.TabIndex = 7
        '
        'btnCancel
        '
        Me.btnCancel.Image = Global.SIGEN.My.Resources.Resources.ok1
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.Location = New System.Drawing.Point(617, 469)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(105, 30)
        Me.btnCancel.TabIndex = 39
        Me.btnCancel.Text = "Ok"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModificar.Location = New System.Drawing.Point(506, 469)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(105, 30)
        Me.btnModificar.TabIndex = 40
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'FrmSector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 511)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.ltbActividades)
        Me.Controls.Add(Me.lblActividades)
        Me.Controls.Add(Me.lblConsultarNombre)
        Me.Controls.Add(Me.lblConsultarNumero)
        Me.Controls.Add(Me.lblConsultarInstituto)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblNumero)
        Me.Controls.Add(Me.lblInstituto)
        Me.Name = "FrmSector"
        Me.Text = "Sector"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblInstituto As System.Windows.Forms.Label
    Friend WithEvents lblNumero As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblConsultarNombre As System.Windows.Forms.Label
    Friend WithEvents lblConsultarNumero As System.Windows.Forms.Label
    Friend WithEvents lblConsultarInstituto As System.Windows.Forms.Label
    Friend WithEvents lblActividades As System.Windows.Forms.Label
    Friend WithEvents ltbActividades As System.Windows.Forms.ListBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
End Class
