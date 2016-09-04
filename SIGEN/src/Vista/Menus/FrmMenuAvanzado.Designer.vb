<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenuAvanzado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenuAvanzado))
        Me.btnPerfil = New System.Windows.Forms.Button
        Me.btnDeportista = New System.Windows.Forms.Button
        Me.btnEjercicios = New System.Windows.Forms.Button
        Me.btnGruposMusculos = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnAvanzado = New System.Windows.Forms.Button
        Me.btnSeleccionador = New System.Windows.Forms.Button
        Me.btnActividades = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnPerfil
        '
        Me.btnPerfil.Location = New System.Drawing.Point(12, 12)
        Me.btnPerfil.Name = "btnPerfil"
        Me.btnPerfil.Size = New System.Drawing.Size(260, 35)
        Me.btnPerfil.TabIndex = 0
        Me.btnPerfil.Text = "Perfil"
        Me.btnPerfil.UseVisualStyleBackColor = True
        '
        'btnDeportista
        '
        Me.btnDeportista.Location = New System.Drawing.Point(12, 53)
        Me.btnDeportista.Name = "btnDeportista"
        Me.btnDeportista.Size = New System.Drawing.Size(260, 35)
        Me.btnDeportista.TabIndex = 1
        Me.btnDeportista.Text = "Deportistas"
        Me.btnDeportista.UseVisualStyleBackColor = True
        '
        'btnEjercicios
        '
        Me.btnEjercicios.Location = New System.Drawing.Point(12, 94)
        Me.btnEjercicios.Name = "btnEjercicios"
        Me.btnEjercicios.Size = New System.Drawing.Size(260, 35)
        Me.btnEjercicios.TabIndex = 4
        Me.btnEjercicios.Text = "Ejercicios"
        Me.btnEjercicios.UseVisualStyleBackColor = True
        '
        'btnGruposMusculos
        '
        Me.btnGruposMusculos.Location = New System.Drawing.Point(12, 135)
        Me.btnGruposMusculos.Name = "btnGruposMusculos"
        Me.btnGruposMusculos.Size = New System.Drawing.Size(260, 35)
        Me.btnGruposMusculos.TabIndex = 5
        Me.btnGruposMusculos.Text = "Grupos Musculares"
        Me.btnGruposMusculos.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Image = Global.SIGEN.My.Resources.Resources.exit2
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(12, 314)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(260, 35)
        Me.btnSalir.TabIndex = 9
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnAvanzado
        '
        Me.btnAvanzado.Location = New System.Drawing.Point(12, 217)
        Me.btnAvanzado.Name = "btnAvanzado"
        Me.btnAvanzado.Size = New System.Drawing.Size(260, 35)
        Me.btnAvanzado.TabIndex = 7
        Me.btnAvanzado.Text = "Nuevo Usuario Avanzado"
        Me.btnAvanzado.UseVisualStyleBackColor = True
        '
        'btnSeleccionador
        '
        Me.btnSeleccionador.Location = New System.Drawing.Point(12, 259)
        Me.btnSeleccionador.Name = "btnSeleccionador"
        Me.btnSeleccionador.Size = New System.Drawing.Size(260, 35)
        Me.btnSeleccionador.TabIndex = 8
        Me.btnSeleccionador.Text = "Nuevo Seleccionador"
        Me.btnSeleccionador.UseVisualStyleBackColor = True
        '
        'btnActividades
        '
        Me.btnActividades.Location = New System.Drawing.Point(12, 176)
        Me.btnActividades.Name = "btnActividades"
        Me.btnActividades.Size = New System.Drawing.Size(260, 35)
        Me.btnActividades.TabIndex = 6
        Me.btnActividades.Text = "Actividades"
        Me.btnActividades.UseVisualStyleBackColor = True
        '
        'FrmMenuAvanzado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(284, 361)
        Me.Controls.Add(Me.btnActividades)
        Me.Controls.Add(Me.btnSeleccionador)
        Me.Controls.Add(Me.btnAvanzado)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGruposMusculos)
        Me.Controls.Add(Me.btnEjercicios)
        Me.Controls.Add(Me.btnDeportista)
        Me.Controls.Add(Me.btnPerfil)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMenuAvanzado"
        Me.Text = "Menú"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPerfil As System.Windows.Forms.Button
    Friend WithEvents btnDeportista As System.Windows.Forms.Button
    Friend WithEvents btnEjercicios As System.Windows.Forms.Button
    Friend WithEvents btnGruposMusculos As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnAvanzado As System.Windows.Forms.Button
    Friend WithEvents btnSeleccionador As System.Windows.Forms.Button
    Friend WithEvents btnActividades As System.Windows.Forms.Button

End Class
