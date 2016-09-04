<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAltaEvolucion
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
        Me.lblDeportista = New System.Windows.Forms.Label
        Me.lstDeportistas = New System.Windows.Forms.ListBox
        Me.gbxCalificacion = New System.Windows.Forms.GroupBox
        Me.lblReciliencia = New System.Windows.Forms.Label
        Me.cmbResiliencia = New System.Windows.Forms.ComboBox
        Me.lblResistenciaMonotonia = New System.Windows.Forms.Label
        Me.cmbResistenciaMonotonia = New System.Windows.Forms.ComboBox
        Me.lblFlexibilidad = New System.Windows.Forms.Label
        Me.cmbFlexibilidad = New System.Windows.Forms.ComboBox
        Me.lblFuerzaMuscular = New System.Windows.Forms.Label
        Me.cmbFuerzaMuscular = New System.Windows.Forms.ComboBox
        Me.cmbResistenciaAnaerobica = New System.Windows.Forms.ComboBox
        Me.lblResistenciaAnaerobica = New System.Windows.Forms.Label
        Me.cmbAgenda = New System.Windows.Forms.ComboBox
        Me.lblAgenda = New System.Windows.Forms.Label
        Me.cmbResistenciaMuscular = New System.Windows.Forms.ComboBox
        Me.lblResistenciaMuscular = New System.Windows.Forms.Label
        Me.btnGuardarSeguir = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.gbxCalificacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDeportista
        '
        Me.lblDeportista.AutoSize = True
        Me.lblDeportista.Location = New System.Drawing.Point(12, 9)
        Me.lblDeportista.Name = "lblDeportista"
        Me.lblDeportista.Size = New System.Drawing.Size(125, 13)
        Me.lblDeportista.TabIndex = 11
        Me.lblDeportista.Text = "Seleccione al Deportista:"
        '
        'lstDeportistas
        '
        Me.lstDeportistas.FormattingEnabled = True
        Me.lstDeportistas.Location = New System.Drawing.Point(15, 26)
        Me.lstDeportistas.Name = "lstDeportistas"
        Me.lstDeportistas.Size = New System.Drawing.Size(189, 329)
        Me.lstDeportistas.TabIndex = 12
        '
        'gbxCalificacion
        '
        Me.gbxCalificacion.Controls.Add(Me.lblReciliencia)
        Me.gbxCalificacion.Controls.Add(Me.cmbResiliencia)
        Me.gbxCalificacion.Controls.Add(Me.lblResistenciaMonotonia)
        Me.gbxCalificacion.Controls.Add(Me.cmbResistenciaMonotonia)
        Me.gbxCalificacion.Controls.Add(Me.lblFlexibilidad)
        Me.gbxCalificacion.Controls.Add(Me.cmbFlexibilidad)
        Me.gbxCalificacion.Controls.Add(Me.lblFuerzaMuscular)
        Me.gbxCalificacion.Controls.Add(Me.cmbFuerzaMuscular)
        Me.gbxCalificacion.Controls.Add(Me.cmbResistenciaAnaerobica)
        Me.gbxCalificacion.Controls.Add(Me.lblResistenciaAnaerobica)
        Me.gbxCalificacion.Controls.Add(Me.cmbAgenda)
        Me.gbxCalificacion.Controls.Add(Me.lblAgenda)
        Me.gbxCalificacion.Controls.Add(Me.cmbResistenciaMuscular)
        Me.gbxCalificacion.Controls.Add(Me.lblResistenciaMuscular)
        Me.gbxCalificacion.Location = New System.Drawing.Point(210, 9)
        Me.gbxCalificacion.Name = "gbxCalificacion"
        Me.gbxCalificacion.Size = New System.Drawing.Size(262, 346)
        Me.gbxCalificacion.TabIndex = 13
        Me.gbxCalificacion.TabStop = False
        Me.gbxCalificacion.Text = "Calificación"
        '
        'lblReciliencia
        '
        Me.lblReciliencia.AutoSize = True
        Me.lblReciliencia.Location = New System.Drawing.Point(6, 184)
        Me.lblReciliencia.Name = "lblReciliencia"
        Me.lblReciliencia.Size = New System.Drawing.Size(62, 13)
        Me.lblReciliencia.TabIndex = 13
        Me.lblReciliencia.Text = "Reciliencia:"
        '
        'cmbResiliencia
        '
        Me.cmbResiliencia.FormattingEnabled = True
        Me.cmbResiliencia.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.cmbResiliencia.Location = New System.Drawing.Point(73, 181)
        Me.cmbResiliencia.Name = "cmbResiliencia"
        Me.cmbResiliencia.Size = New System.Drawing.Size(183, 21)
        Me.cmbResiliencia.TabIndex = 12
        '
        'lblResistenciaMonotonia
        '
        Me.lblResistenciaMonotonia.AutoSize = True
        Me.lblResistenciaMonotonia.Location = New System.Drawing.Point(6, 157)
        Me.lblResistenciaMonotonia.Name = "lblResistenciaMonotonia"
        Me.lblResistenciaMonotonia.Size = New System.Drawing.Size(140, 13)
        Me.lblResistenciaMonotonia.TabIndex = 11
        Me.lblResistenciaMonotonia.Text = "Resistencia a la Monotonía:"
        '
        'cmbResistenciaMonotonia
        '
        Me.cmbResistenciaMonotonia.FormattingEnabled = True
        Me.cmbResistenciaMonotonia.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.cmbResistenciaMonotonia.Location = New System.Drawing.Point(152, 154)
        Me.cmbResistenciaMonotonia.Name = "cmbResistenciaMonotonia"
        Me.cmbResistenciaMonotonia.Size = New System.Drawing.Size(104, 21)
        Me.cmbResistenciaMonotonia.TabIndex = 10
        '
        'lblFlexibilidad
        '
        Me.lblFlexibilidad.AutoSize = True
        Me.lblFlexibilidad.Location = New System.Drawing.Point(6, 130)
        Me.lblFlexibilidad.Name = "lblFlexibilidad"
        Me.lblFlexibilidad.Size = New System.Drawing.Size(61, 13)
        Me.lblFlexibilidad.TabIndex = 9
        Me.lblFlexibilidad.Text = "Flexibilidad:"
        '
        'cmbFlexibilidad
        '
        Me.cmbFlexibilidad.FormattingEnabled = True
        Me.cmbFlexibilidad.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.cmbFlexibilidad.Location = New System.Drawing.Point(73, 127)
        Me.cmbFlexibilidad.Name = "cmbFlexibilidad"
        Me.cmbFlexibilidad.Size = New System.Drawing.Size(183, 21)
        Me.cmbFlexibilidad.TabIndex = 8
        '
        'lblFuerzaMuscular
        '
        Me.lblFuerzaMuscular.AutoSize = True
        Me.lblFuerzaMuscular.Location = New System.Drawing.Point(6, 76)
        Me.lblFuerzaMuscular.Name = "lblFuerzaMuscular"
        Me.lblFuerzaMuscular.Size = New System.Drawing.Size(88, 13)
        Me.lblFuerzaMuscular.TabIndex = 7
        Me.lblFuerzaMuscular.Text = "Fuerza Muscular:"
        '
        'cmbFuerzaMuscular
        '
        Me.cmbFuerzaMuscular.FormattingEnabled = True
        Me.cmbFuerzaMuscular.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.cmbFuerzaMuscular.Location = New System.Drawing.Point(100, 73)
        Me.cmbFuerzaMuscular.Name = "cmbFuerzaMuscular"
        Me.cmbFuerzaMuscular.Size = New System.Drawing.Size(156, 21)
        Me.cmbFuerzaMuscular.TabIndex = 6
        '
        'cmbResistenciaAnaerobica
        '
        Me.cmbResistenciaAnaerobica.FormattingEnabled = True
        Me.cmbResistenciaAnaerobica.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.cmbResistenciaAnaerobica.Location = New System.Drawing.Point(134, 46)
        Me.cmbResistenciaAnaerobica.Name = "cmbResistenciaAnaerobica"
        Me.cmbResistenciaAnaerobica.Size = New System.Drawing.Size(122, 21)
        Me.cmbResistenciaAnaerobica.TabIndex = 5
        '
        'lblResistenciaAnaerobica
        '
        Me.lblResistenciaAnaerobica.AutoSize = True
        Me.lblResistenciaAnaerobica.Location = New System.Drawing.Point(6, 49)
        Me.lblResistenciaAnaerobica.Name = "lblResistenciaAnaerobica"
        Me.lblResistenciaAnaerobica.Size = New System.Drawing.Size(122, 13)
        Me.lblResistenciaAnaerobica.TabIndex = 4
        Me.lblResistenciaAnaerobica.Text = "Resistencia Anaeróbica:"
        '
        'cmbAgenda
        '
        Me.cmbAgenda.FormattingEnabled = True
        Me.cmbAgenda.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.cmbAgenda.Location = New System.Drawing.Point(156, 19)
        Me.cmbAgenda.Name = "cmbAgenda"
        Me.cmbAgenda.Size = New System.Drawing.Size(100, 21)
        Me.cmbAgenda.TabIndex = 3
        '
        'lblAgenda
        '
        Me.lblAgenda.AutoSize = True
        Me.lblAgenda.Location = New System.Drawing.Point(6, 22)
        Me.lblAgenda.Name = "lblAgenda"
        Me.lblAgenda.Size = New System.Drawing.Size(144, 13)
        Me.lblAgenda.TabIndex = 2
        Me.lblAgenda.Text = "Cumplimiento con la Agenda:"
        '
        'cmbResistenciaMuscular
        '
        Me.cmbResistenciaMuscular.FormattingEnabled = True
        Me.cmbResistenciaMuscular.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.cmbResistenciaMuscular.Location = New System.Drawing.Point(123, 100)
        Me.cmbResistenciaMuscular.Name = "cmbResistenciaMuscular"
        Me.cmbResistenciaMuscular.Size = New System.Drawing.Size(133, 21)
        Me.cmbResistenciaMuscular.TabIndex = 1
        '
        'lblResistenciaMuscular
        '
        Me.lblResistenciaMuscular.AutoSize = True
        Me.lblResistenciaMuscular.Location = New System.Drawing.Point(6, 103)
        Me.lblResistenciaMuscular.Name = "lblResistenciaMuscular"
        Me.lblResistenciaMuscular.Size = New System.Drawing.Size(111, 13)
        Me.lblResistenciaMuscular.TabIndex = 0
        Me.lblResistenciaMuscular.Text = "Resistencia Muscular:"
        '
        'btnGuardarSeguir
        '
        Me.btnGuardarSeguir.Location = New System.Drawing.Point(256, 369)
        Me.btnGuardarSeguir.Name = "btnGuardarSeguir"
        Me.btnGuardarSeguir.Size = New System.Drawing.Size(105, 30)
        Me.btnGuardarSeguir.TabIndex = 14
        Me.btnGuardarSeguir.Text = "Guardar y Calificar"
        Me.btnGuardarSeguir.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.SIGEN.My.Resources.Resources.cancel
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(145, 369)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(105, 30)
        Me.btnCancelar.TabIndex = 10
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
        Me.btnGuardar.TabIndex = 9
        Me.btnGuardar.Text = "Guardar y Salir"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'FrmAltaEvolucion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 411)
        Me.Controls.Add(Me.btnGuardarSeguir)
        Me.Controls.Add(Me.gbxCalificacion)
        Me.Controls.Add(Me.lstDeportistas)
        Me.Controls.Add(Me.lblDeportista)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Name = "FrmAltaEvolucion"
        Me.Text = "Calificar"
        Me.gbxCalificacion.ResumeLayout(False)
        Me.gbxCalificacion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents lblDeportista As System.Windows.Forms.Label
    Friend WithEvents lstDeportistas As System.Windows.Forms.ListBox
    Friend WithEvents gbxCalificacion As System.Windows.Forms.GroupBox
    Friend WithEvents cmbResistenciaMuscular As System.Windows.Forms.ComboBox
    Friend WithEvents lblResistenciaMuscular As System.Windows.Forms.Label
    Friend WithEvents cmbAgenda As System.Windows.Forms.ComboBox
    Friend WithEvents lblAgenda As System.Windows.Forms.Label
    Friend WithEvents cmbResistenciaMonotonia As System.Windows.Forms.ComboBox
    Friend WithEvents lblFlexibilidad As System.Windows.Forms.Label
    Friend WithEvents cmbFlexibilidad As System.Windows.Forms.ComboBox
    Friend WithEvents lblFuerzaMuscular As System.Windows.Forms.Label
    Friend WithEvents cmbFuerzaMuscular As System.Windows.Forms.ComboBox
    Friend WithEvents cmbResistenciaAnaerobica As System.Windows.Forms.ComboBox
    Friend WithEvents lblResistenciaAnaerobica As System.Windows.Forms.Label
    Friend WithEvents cmbResiliencia As System.Windows.Forms.ComboBox
    Friend WithEvents lblResistenciaMonotonia As System.Windows.Forms.Label
    Friend WithEvents lblReciliencia As System.Windows.Forms.Label
    Friend WithEvents btnGuardarSeguir As System.Windows.Forms.Button
End Class
