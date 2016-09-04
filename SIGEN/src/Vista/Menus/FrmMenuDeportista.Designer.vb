<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenuDeportista
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
        Me.btnPerfil = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnTablaCompatibilidad = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnPerfil
        '
        Me.btnPerfil.Location = New System.Drawing.Point(12, 12)
        Me.btnPerfil.Name = "btnPerfil"
        Me.btnPerfil.Size = New System.Drawing.Size(260, 35)
        Me.btnPerfil.TabIndex = 1
        Me.btnPerfil.Text = "Perfil"
        Me.btnPerfil.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Image = Global.SIGEN.My.Resources.Resources.exit2
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(12, 314)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(260, 35)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnTablaCompatibilidad
        '
        Me.btnTablaCompatibilidad.Location = New System.Drawing.Point(12, 53)
        Me.btnTablaCompatibilidad.Name = "btnTablaCompatibilidad"
        Me.btnTablaCompatibilidad.Size = New System.Drawing.Size(260, 35)
        Me.btnTablaCompatibilidad.TabIndex = 3
        Me.btnTablaCompatibilidad.Text = "Tabla de Compatibilidad"
        Me.btnTablaCompatibilidad.UseVisualStyleBackColor = True
        '
        'FrmMenuDeportista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(284, 361)
        Me.Controls.Add(Me.btnTablaCompatibilidad)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnPerfil)
        Me.Name = "FrmMenuDeportista"
        Me.Text = "Menú"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnPerfil As System.Windows.Forms.Button
    Friend WithEvents btnTablaCompatibilidad As System.Windows.Forms.Button
End Class
