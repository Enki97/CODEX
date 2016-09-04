<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenuEntrenador
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
        Me.btnPerfilEntrenador = New System.Windows.Forms.Button
        Me.btnListaDeportistas = New System.Windows.Forms.Button
        Me.btnListarCombos = New System.Windows.Forms.Button
        Me.btnTablaCompatibilidad = New System.Windows.Forms.Button
        Me.btnPlanesEntrenamiento = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnCalificar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnPerfilEntrenador
        '
        Me.btnPerfilEntrenador.Location = New System.Drawing.Point(13, 12)
        Me.btnPerfilEntrenador.Name = "btnPerfilEntrenador"
        Me.btnPerfilEntrenador.Size = New System.Drawing.Size(260, 35)
        Me.btnPerfilEntrenador.TabIndex = 1
        Me.btnPerfilEntrenador.Text = "Perfil"
        Me.btnPerfilEntrenador.UseVisualStyleBackColor = True
        '
        'btnListaDeportistas
        '
        Me.btnListaDeportistas.Location = New System.Drawing.Point(12, 53)
        Me.btnListaDeportistas.Name = "btnListaDeportistas"
        Me.btnListaDeportistas.Size = New System.Drawing.Size(260, 35)
        Me.btnListaDeportistas.TabIndex = 2
        Me.btnListaDeportistas.Text = "Deportistas"
        Me.btnListaDeportistas.UseVisualStyleBackColor = True
        '
        'btnListarCombos
        '
        Me.btnListarCombos.Location = New System.Drawing.Point(13, 176)
        Me.btnListarCombos.Name = "btnListarCombos"
        Me.btnListarCombos.Size = New System.Drawing.Size(260, 35)
        Me.btnListarCombos.TabIndex = 5
        Me.btnListarCombos.Text = "Combos"
        Me.btnListarCombos.UseVisualStyleBackColor = True
        '
        'btnTablaCompatibilidad
        '
        Me.btnTablaCompatibilidad.Location = New System.Drawing.Point(12, 217)
        Me.btnTablaCompatibilidad.Name = "btnTablaCompatibilidad"
        Me.btnTablaCompatibilidad.Size = New System.Drawing.Size(260, 35)
        Me.btnTablaCompatibilidad.TabIndex = 6
        Me.btnTablaCompatibilidad.Text = "Tabla de Compatibilidad"
        Me.btnTablaCompatibilidad.UseVisualStyleBackColor = True
        '
        'btnPlanesEntrenamiento
        '
        Me.btnPlanesEntrenamiento.Location = New System.Drawing.Point(13, 94)
        Me.btnPlanesEntrenamiento.Name = "btnPlanesEntrenamiento"
        Me.btnPlanesEntrenamiento.Size = New System.Drawing.Size(260, 35)
        Me.btnPlanesEntrenamiento.TabIndex = 3
        Me.btnPlanesEntrenamiento.Text = "Planes de Entrenamiento"
        Me.btnPlanesEntrenamiento.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Image = Global.SIGEN.My.Resources.Resources.exit2
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(13, 314)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(260, 35)
        Me.btnSalir.TabIndex = 7
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnCalificar
        '
        Me.btnCalificar.Location = New System.Drawing.Point(13, 135)
        Me.btnCalificar.Name = "btnCalificar"
        Me.btnCalificar.Size = New System.Drawing.Size(260, 35)
        Me.btnCalificar.TabIndex = 4
        Me.btnCalificar.Text = "Calificar"
        Me.btnCalificar.UseVisualStyleBackColor = True
        '
        'FrmMenuEntrenador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(284, 361)
        Me.Controls.Add(Me.btnCalificar)
        Me.Controls.Add(Me.btnPlanesEntrenamiento)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnTablaCompatibilidad)
        Me.Controls.Add(Me.btnListarCombos)
        Me.Controls.Add(Me.btnPerfilEntrenador)
        Me.Controls.Add(Me.btnListaDeportistas)
        Me.Name = "FrmMenuEntrenador"
        Me.Text = "Menú"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnListaDeportistas As System.Windows.Forms.Button
    Friend WithEvents btnListarCombos As System.Windows.Forms.Button
    Friend WithEvents btnTablaCompatibilidad As System.Windows.Forms.Button
    Friend WithEvents btnPerfilEntrenador As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnPlanesEntrenamiento As System.Windows.Forms.Button
    Friend WithEvents btnCalificar As System.Windows.Forms.Button

End Class
