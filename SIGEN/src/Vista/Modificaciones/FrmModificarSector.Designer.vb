<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificarSector
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
        Me.cklActividades = New System.Windows.Forms.CheckedListBox
        Me.lblActividades = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.lblNombre = New System.Windows.Forms.Label
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'cklActividades
        '
        Me.cklActividades.FormattingEnabled = True
        Me.cklActividades.Location = New System.Drawing.Point(16, 57)
        Me.cklActividades.Name = "cklActividades"
        Me.cklActividades.Size = New System.Drawing.Size(456, 304)
        Me.cklActividades.TabIndex = 82
        '
        'lblActividades
        '
        Me.lblActividades.AutoSize = True
        Me.lblActividades.Location = New System.Drawing.Point(12, 35)
        Me.lblActividades.Name = "lblActividades"
        Me.lblActividades.Size = New System.Drawing.Size(318, 13)
        Me.lblActividades.TabIndex = 81
        Me.lblActividades.Text = "Seleccione las actividades que pueden practicarse en este sector"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(66, 12)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(406, 20)
        Me.txtNombre.TabIndex = 78
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(13, 15)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 77
        Me.lblNombre.Text = "Nombre:"
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.SIGEN.My.Resources.Resources.cancel
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(256, 372)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(105, 30)
        Me.btnCancelar.TabIndex = 84
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = Global.SIGEN.My.Resources.Resources.ok1
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.Location = New System.Drawing.Point(367, 372)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(105, 30)
        Me.btnGuardar.TabIndex = 83
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'FrmModificarSector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 411)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.cklActividades)
        Me.Controls.Add(Me.lblActividades)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Name = "FrmModificarSector"
        Me.Text = "Modify Sector"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents cklActividades As System.Windows.Forms.CheckedListBox
    Friend WithEvents lblActividades As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
End Class
