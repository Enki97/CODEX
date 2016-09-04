<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCombo
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
        Me.lblNombre = New System.Windows.Forms.Label
        Me.lblConsultarNombre = New System.Windows.Forms.Label
        Me.lblDescripcion = New System.Windows.Forms.Label
        Me.rtbDescripcion = New System.Windows.Forms.RichTextBox
        Me.lblEjercicios = New System.Windows.Forms.Label
        Me.lstEjercicios = New System.Windows.Forms.ListBox
        Me.btnModificar = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(12, 13)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre:"
        '
        'lblConsultarNombre
        '
        Me.lblConsultarNombre.AutoSize = True
        Me.lblConsultarNombre.Location = New System.Drawing.Point(66, 13)
        Me.lblConsultarNombre.Name = "lblConsultarNombre"
        Me.lblConsultarNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblConsultarNombre.TabIndex = 1
        Me.lblConsultarNombre.Text = "Nombre"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(12, 36)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(66, 13)
        Me.lblDescripcion.TabIndex = 2
        Me.lblDescripcion.Text = "Descripción:"
        '
        'rtbDescripcion
        '
        Me.rtbDescripcion.Location = New System.Drawing.Point(15, 52)
        Me.rtbDescripcion.Name = "rtbDescripcion"
        Me.rtbDescripcion.Size = New System.Drawing.Size(706, 130)
        Me.rtbDescripcion.TabIndex = 3
        Me.rtbDescripcion.Text = ""
        '
        'lblEjercicios
        '
        Me.lblEjercicios.AutoSize = True
        Me.lblEjercicios.Location = New System.Drawing.Point(12, 208)
        Me.lblEjercicios.Name = "lblEjercicios"
        Me.lblEjercicios.Size = New System.Drawing.Size(55, 13)
        Me.lblEjercicios.TabIndex = 4
        Me.lblEjercicios.Text = "Ejercicios:"
        '
        'lstEjercicios
        '
        Me.lstEjercicios.FormattingEnabled = True
        Me.lstEjercicios.Location = New System.Drawing.Point(15, 225)
        Me.lstEjercicios.Name = "lstEjercicios"
        Me.lstEjercicios.Size = New System.Drawing.Size(706, 225)
        Me.lstEjercicios.TabIndex = 5
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(505, 469)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(105, 30)
        Me.btnModificar.TabIndex = 36
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Image = Global.SIGEN.My.Resources.Resources.ok1
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.Location = New System.Drawing.Point(616, 469)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(105, 30)
        Me.btnCancel.TabIndex = 35
        Me.btnCancel.Text = "Ok"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'FrmCombo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 511)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lstEjercicios)
        Me.Controls.Add(Me.lblEjercicios)
        Me.Controls.Add(Me.rtbDescripcion)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.lblConsultarNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Name = "FrmCombo"
        Me.RightToLeftLayout = True
        Me.Text = "Consultar Combo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblConsultarNombre As System.Windows.Forms.Label
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents rtbDescripcion As System.Windows.Forms.RichTextBox
    Friend WithEvents lblEjercicios As System.Windows.Forms.Label
    Friend WithEvents lstEjercicios As System.Windows.Forms.ListBox
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
