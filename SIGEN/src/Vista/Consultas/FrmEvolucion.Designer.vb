<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEvolucion
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series
        Dim Series7 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series
        Dim Series8 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea
        Dim Series9 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series
        Dim DataPoint1 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(18, "18,18")
        Dim DataPoint2 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(10, "10,10")
        Dim DataPoint3 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(15, "15,0")
        Dim DataPoint4 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(20, "20,0")
        Dim DataPoint5 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(9, "9,0")
        Dim DataPoint6 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(15, "15,0")
        Dim DataPoint7 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(5, "5,0")
        Me.btnCancel = New System.Windows.Forms.Button
        Me.tabPromedio = New System.Windows.Forms.TabPage
        Me.grPromedio = New System.Windows.Forms.DataVisualization.Charting.Chart
        Me.tabGrafica = New System.Windows.Forms.TabPage
        Me.grEvolucion = New System.Windows.Forms.DataVisualization.Charting.Chart
        Me.tabTabular = New System.Windows.Forms.TabPage
        Me.lblCalcularPromedio = New System.Windows.Forms.Label
        Me.lblPromedio = New System.Windows.Forms.Label
        Me.lblConsultarResiliencia = New System.Windows.Forms.Label
        Me.lblConsultarCumplimiento = New System.Windows.Forms.Label
        Me.lblConsultarMonotonia = New System.Windows.Forms.Label
        Me.lblConsultarAnaerobica = New System.Windows.Forms.Label
        Me.lblConsultarFlexibilidad = New System.Windows.Forms.Label
        Me.lblConsultarFuerza = New System.Windows.Forms.Label
        Me.lblConsultarResistenciaMuscular = New System.Windows.Forms.Label
        Me.grCalificacion = New System.Windows.Forms.DataVisualization.Charting.Chart
        Me.lblReciliencia = New System.Windows.Forms.Label
        Me.lblAgenda = New System.Windows.Forms.Label
        Me.lblResistenciaMonotonia = New System.Windows.Forms.Label
        Me.lblResistenciaAnaerobica = New System.Windows.Forms.Label
        Me.lblFlexibilidad = New System.Windows.Forms.Label
        Me.lblFuerzaMuscular = New System.Windows.Forms.Label
        Me.lblResistenciaMuscular = New System.Windows.Forms.Label
        Me.tabEvolucion = New System.Windows.Forms.TabControl
        Me.tabPromedio.SuspendLayout()
        CType(Me.grPromedio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabGrafica.SuspendLayout()
        CType(Me.grEvolucion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabTabular.SuspendLayout()
        CType(Me.grCalificacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabEvolucion.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Image = Global.SIGEN.My.Resources.Resources.ok1
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.Location = New System.Drawing.Point(617, 469)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(105, 30)
        Me.btnCancel.TabIndex = 80
        Me.btnCancel.Text = "Ok"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'tabPromedio
        '
        Me.tabPromedio.Controls.Add(Me.grPromedio)
        Me.tabPromedio.Location = New System.Drawing.Point(4, 22)
        Me.tabPromedio.Name = "tabPromedio"
        Me.tabPromedio.Size = New System.Drawing.Size(701, 424)
        Me.tabPromedio.TabIndex = 2
        Me.tabPromedio.Text = "Promedio de Evolución"
        Me.tabPromedio.UseVisualStyleBackColor = True
        '
        'grPromedio
        '
        ChartArea1.Name = "ChartArea1"
        Me.grPromedio.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.grPromedio.Legends.Add(Legend1)
        Me.grPromedio.Location = New System.Drawing.Point(3, 3)
        Me.grPromedio.Name = "grPromedio"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Legend = "Legend1"
        Series1.Name = "Promedio"
        Series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Date]
        Me.grPromedio.Series.Add(Series1)
        Me.grPromedio.Size = New System.Drawing.Size(695, 421)
        Me.grPromedio.TabIndex = 0
        Me.grPromedio.Text = "Chart3"
        '
        'tabGrafica
        '
        Me.tabGrafica.Controls.Add(Me.grEvolucion)
        Me.tabGrafica.Location = New System.Drawing.Point(4, 22)
        Me.tabGrafica.Name = "tabGrafica"
        Me.tabGrafica.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGrafica.Size = New System.Drawing.Size(701, 424)
        Me.tabGrafica.TabIndex = 1
        Me.tabGrafica.Text = "Gráfica Evolutiva"
        Me.tabGrafica.UseVisualStyleBackColor = True
        '
        'grEvolucion
        '
        ChartArea2.AxisY.Maximum = 20
        ChartArea2.Name = "ChartArea1"
        Me.grEvolucion.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.grEvolucion.Legends.Add(Legend2)
        Me.grEvolucion.Location = New System.Drawing.Point(3, 6)
        Me.grEvolucion.Name = "grEvolucion"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series2.Legend = "Legend1"
        Series2.MarkerSize = 10
        Series2.Name = "Cumplimiento con Agenda"
        Series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Date]
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series3.Legend = "Legend1"
        Series3.Name = "Resistencia Anaeróbica"
        Series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Date]
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series4.Legend = "Legend1"
        Series4.Name = "Fuerza Muscular"
        Series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Date]
        Series5.ChartArea = "ChartArea1"
        Series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series5.Legend = "Legend1"
        Series5.Name = "Resistencia Muscular"
        Series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Date]
        Series6.ChartArea = "ChartArea1"
        Series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series6.Legend = "Legend1"
        Series6.Name = "Flexibilidad"
        Series6.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Date]
        Series7.ChartArea = "ChartArea1"
        Series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series7.Legend = "Legend1"
        Series7.Name = "Resistencia a la Monotonía"
        Series7.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Date]
        Series8.ChartArea = "ChartArea1"
        Series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series8.Legend = "Legend1"
        Series8.Name = "Resiliencia"
        Series8.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Date]
        Me.grEvolucion.Series.Add(Series2)
        Me.grEvolucion.Series.Add(Series3)
        Me.grEvolucion.Series.Add(Series4)
        Me.grEvolucion.Series.Add(Series5)
        Me.grEvolucion.Series.Add(Series6)
        Me.grEvolucion.Series.Add(Series7)
        Me.grEvolucion.Series.Add(Series8)
        Me.grEvolucion.Size = New System.Drawing.Size(692, 412)
        Me.grEvolucion.TabIndex = 0
        Me.grEvolucion.Text = "Chart2"
        '
        'tabTabular
        '
        Me.tabTabular.Controls.Add(Me.lblCalcularPromedio)
        Me.tabTabular.Controls.Add(Me.lblPromedio)
        Me.tabTabular.Controls.Add(Me.lblConsultarResiliencia)
        Me.tabTabular.Controls.Add(Me.lblConsultarCumplimiento)
        Me.tabTabular.Controls.Add(Me.lblConsultarMonotonia)
        Me.tabTabular.Controls.Add(Me.lblConsultarAnaerobica)
        Me.tabTabular.Controls.Add(Me.lblConsultarFlexibilidad)
        Me.tabTabular.Controls.Add(Me.lblConsultarFuerza)
        Me.tabTabular.Controls.Add(Me.lblConsultarResistenciaMuscular)
        Me.tabTabular.Controls.Add(Me.grCalificacion)
        Me.tabTabular.Controls.Add(Me.lblReciliencia)
        Me.tabTabular.Controls.Add(Me.lblAgenda)
        Me.tabTabular.Controls.Add(Me.lblResistenciaMonotonia)
        Me.tabTabular.Controls.Add(Me.lblResistenciaAnaerobica)
        Me.tabTabular.Controls.Add(Me.lblFlexibilidad)
        Me.tabTabular.Controls.Add(Me.lblFuerzaMuscular)
        Me.tabTabular.Controls.Add(Me.lblResistenciaMuscular)
        Me.tabTabular.Location = New System.Drawing.Point(4, 22)
        Me.tabTabular.Name = "tabTabular"
        Me.tabTabular.Padding = New System.Windows.Forms.Padding(3)
        Me.tabTabular.Size = New System.Drawing.Size(701, 424)
        Me.tabTabular.TabIndex = 0
        Me.tabTabular.Text = "Calificación"
        Me.tabTabular.UseVisualStyleBackColor = True
        '
        'lblCalcularPromedio
        '
        Me.lblCalcularPromedio.AutoSize = True
        Me.lblCalcularPromedio.Location = New System.Drawing.Point(155, 94)
        Me.lblCalcularPromedio.Name = "lblCalcularPromedio"
        Me.lblCalcularPromedio.Size = New System.Drawing.Size(51, 13)
        Me.lblCalcularPromedio.TabIndex = 97
        Me.lblCalcularPromedio.Text = "Promedio"
        '
        'lblPromedio
        '
        Me.lblPromedio.AutoSize = True
        Me.lblPromedio.Location = New System.Drawing.Point(6, 94)
        Me.lblPromedio.Name = "lblPromedio"
        Me.lblPromedio.Size = New System.Drawing.Size(54, 13)
        Me.lblPromedio.TabIndex = 96
        Me.lblPromedio.Text = "Promedio:"
        '
        'lblConsultarResiliencia
        '
        Me.lblConsultarResiliencia.AutoSize = True
        Me.lblConsultarResiliencia.Location = New System.Drawing.Point(155, 81)
        Me.lblConsultarResiliencia.Name = "lblConsultarResiliencia"
        Me.lblConsultarResiliencia.Size = New System.Drawing.Size(59, 13)
        Me.lblConsultarResiliencia.TabIndex = 95
        Me.lblConsultarResiliencia.Text = "Reciliencia"
        '
        'lblConsultarCumplimiento
        '
        Me.lblConsultarCumplimiento.AutoSize = True
        Me.lblConsultarCumplimiento.Location = New System.Drawing.Point(155, 3)
        Me.lblConsultarCumplimiento.Name = "lblConsultarCumplimiento"
        Me.lblConsultarCumplimiento.Size = New System.Drawing.Size(69, 13)
        Me.lblConsultarCumplimiento.TabIndex = 90
        Me.lblConsultarCumplimiento.Text = "Cumplimiento"
        '
        'lblConsultarMonotonia
        '
        Me.lblConsultarMonotonia.AutoSize = True
        Me.lblConsultarMonotonia.Location = New System.Drawing.Point(155, 68)
        Me.lblConsultarMonotonia.Name = "lblConsultarMonotonia"
        Me.lblConsultarMonotonia.Size = New System.Drawing.Size(137, 13)
        Me.lblConsultarMonotonia.TabIndex = 94
        Me.lblConsultarMonotonia.Text = "Resistencia a la Monotonía"
        '
        'lblConsultarAnaerobica
        '
        Me.lblConsultarAnaerobica.AutoSize = True
        Me.lblConsultarAnaerobica.Location = New System.Drawing.Point(155, 16)
        Me.lblConsultarAnaerobica.Name = "lblConsultarAnaerobica"
        Me.lblConsultarAnaerobica.Size = New System.Drawing.Size(119, 13)
        Me.lblConsultarAnaerobica.TabIndex = 91
        Me.lblConsultarAnaerobica.Text = "Resistencia Anaeróbica"
        '
        'lblConsultarFlexibilidad
        '
        Me.lblConsultarFlexibilidad.AutoSize = True
        Me.lblConsultarFlexibilidad.Location = New System.Drawing.Point(155, 55)
        Me.lblConsultarFlexibilidad.Name = "lblConsultarFlexibilidad"
        Me.lblConsultarFlexibilidad.Size = New System.Drawing.Size(58, 13)
        Me.lblConsultarFlexibilidad.TabIndex = 93
        Me.lblConsultarFlexibilidad.Text = "Flexibilidad"
        '
        'lblConsultarFuerza
        '
        Me.lblConsultarFuerza.AutoSize = True
        Me.lblConsultarFuerza.Location = New System.Drawing.Point(155, 29)
        Me.lblConsultarFuerza.Name = "lblConsultarFuerza"
        Me.lblConsultarFuerza.Size = New System.Drawing.Size(85, 13)
        Me.lblConsultarFuerza.TabIndex = 92
        Me.lblConsultarFuerza.Text = "Fuerza Muscular"
        '
        'lblConsultarResistenciaMuscular
        '
        Me.lblConsultarResistenciaMuscular.AutoSize = True
        Me.lblConsultarResistenciaMuscular.Location = New System.Drawing.Point(155, 42)
        Me.lblConsultarResistenciaMuscular.Name = "lblConsultarResistenciaMuscular"
        Me.lblConsultarResistenciaMuscular.Size = New System.Drawing.Size(108, 13)
        Me.lblConsultarResistenciaMuscular.TabIndex = 89
        Me.lblConsultarResistenciaMuscular.Text = "Resistencia Muscular"
        '
        'grCalificacion
        '
        ChartArea3.Name = "ChartArea1"
        Me.grCalificacion.ChartAreas.Add(ChartArea3)
        Me.grCalificacion.Location = New System.Drawing.Point(9, 110)
        Me.grCalificacion.Name = "grCalificacion"
        Series9.ChartArea = "ChartArea1"
        Series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Radar
        Series9.Name = "Series1"
        DataPoint1.Label = "Cumplimiento"
        DataPoint2.Label = "Resistencia Anaeróbica"
        DataPoint3.Label = "Resistencia Muscular"
        DataPoint4.Label = "Fuerza Muscular"
        DataPoint5.Label = "Flexibilidad"
        DataPoint6.Label = "Resistencia a la Monotonía"
        DataPoint7.Label = "Reciliencia"
        Series9.Points.Add(DataPoint1)
        Series9.Points.Add(DataPoint2)
        Series9.Points.Add(DataPoint3)
        Series9.Points.Add(DataPoint4)
        Series9.Points.Add(DataPoint5)
        Series9.Points.Add(DataPoint6)
        Series9.Points.Add(DataPoint7)
        Series9.YValuesPerPoint = 2
        Me.grCalificacion.Series.Add(Series9)
        Me.grCalificacion.Size = New System.Drawing.Size(686, 308)
        Me.grCalificacion.TabIndex = 88
        Me.grCalificacion.Text = "Chart1"
        '
        'lblReciliencia
        '
        Me.lblReciliencia.AutoSize = True
        Me.lblReciliencia.Location = New System.Drawing.Point(6, 81)
        Me.lblReciliencia.Name = "lblReciliencia"
        Me.lblReciliencia.Size = New System.Drawing.Size(62, 13)
        Me.lblReciliencia.TabIndex = 87
        Me.lblReciliencia.Text = "Reciliencia:"
        '
        'lblAgenda
        '
        Me.lblAgenda.AutoSize = True
        Me.lblAgenda.Location = New System.Drawing.Point(6, 3)
        Me.lblAgenda.Name = "lblAgenda"
        Me.lblAgenda.Size = New System.Drawing.Size(144, 13)
        Me.lblAgenda.TabIndex = 82
        Me.lblAgenda.Text = "Cumplimiento con la Agenda:"
        '
        'lblResistenciaMonotonia
        '
        Me.lblResistenciaMonotonia.AutoSize = True
        Me.lblResistenciaMonotonia.Location = New System.Drawing.Point(6, 68)
        Me.lblResistenciaMonotonia.Name = "lblResistenciaMonotonia"
        Me.lblResistenciaMonotonia.Size = New System.Drawing.Size(140, 13)
        Me.lblResistenciaMonotonia.TabIndex = 86
        Me.lblResistenciaMonotonia.Text = "Resistencia a la Monotonía:"
        '
        'lblResistenciaAnaerobica
        '
        Me.lblResistenciaAnaerobica.AutoSize = True
        Me.lblResistenciaAnaerobica.Location = New System.Drawing.Point(6, 16)
        Me.lblResistenciaAnaerobica.Name = "lblResistenciaAnaerobica"
        Me.lblResistenciaAnaerobica.Size = New System.Drawing.Size(122, 13)
        Me.lblResistenciaAnaerobica.TabIndex = 83
        Me.lblResistenciaAnaerobica.Text = "Resistencia Anaeróbica:"
        '
        'lblFlexibilidad
        '
        Me.lblFlexibilidad.AutoSize = True
        Me.lblFlexibilidad.Location = New System.Drawing.Point(6, 55)
        Me.lblFlexibilidad.Name = "lblFlexibilidad"
        Me.lblFlexibilidad.Size = New System.Drawing.Size(61, 13)
        Me.lblFlexibilidad.TabIndex = 85
        Me.lblFlexibilidad.Text = "Flexibilidad:"
        '
        'lblFuerzaMuscular
        '
        Me.lblFuerzaMuscular.AutoSize = True
        Me.lblFuerzaMuscular.Location = New System.Drawing.Point(6, 29)
        Me.lblFuerzaMuscular.Name = "lblFuerzaMuscular"
        Me.lblFuerzaMuscular.Size = New System.Drawing.Size(88, 13)
        Me.lblFuerzaMuscular.TabIndex = 84
        Me.lblFuerzaMuscular.Text = "Fuerza Muscular:"
        '
        'lblResistenciaMuscular
        '
        Me.lblResistenciaMuscular.AutoSize = True
        Me.lblResistenciaMuscular.Location = New System.Drawing.Point(6, 42)
        Me.lblResistenciaMuscular.Name = "lblResistenciaMuscular"
        Me.lblResistenciaMuscular.Size = New System.Drawing.Size(111, 13)
        Me.lblResistenciaMuscular.TabIndex = 81
        Me.lblResistenciaMuscular.Text = "Resistencia Muscular:"
        '
        'tabEvolucion
        '
        Me.tabEvolucion.Controls.Add(Me.tabTabular)
        Me.tabEvolucion.Controls.Add(Me.tabGrafica)
        Me.tabEvolucion.Controls.Add(Me.tabPromedio)
        Me.tabEvolucion.Location = New System.Drawing.Point(13, 13)
        Me.tabEvolucion.Name = "tabEvolucion"
        Me.tabEvolucion.SelectedIndex = 0
        Me.tabEvolucion.Size = New System.Drawing.Size(709, 450)
        Me.tabEvolucion.TabIndex = 0
        '
        'FrmEvolucion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 511)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.tabEvolucion)
        Me.Name = "FrmEvolucion"
        Me.Text = "Evolución"
        Me.tabPromedio.ResumeLayout(False)
        CType(Me.grPromedio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabGrafica.ResumeLayout(False)
        CType(Me.grEvolucion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabTabular.ResumeLayout(False)
        Me.tabTabular.PerformLayout()
        CType(Me.grCalificacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabEvolucion.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents tabPromedio As System.Windows.Forms.TabPage
    Friend WithEvents tabGrafica As System.Windows.Forms.TabPage
    Friend WithEvents grEvolucion As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents tabTabular As System.Windows.Forms.TabPage
    Friend WithEvents lblCalcularPromedio As System.Windows.Forms.Label
    Friend WithEvents lblPromedio As System.Windows.Forms.Label
    Friend WithEvents lblConsultarResiliencia As System.Windows.Forms.Label
    Friend WithEvents lblConsultarCumplimiento As System.Windows.Forms.Label
    Friend WithEvents lblConsultarMonotonia As System.Windows.Forms.Label
    Friend WithEvents lblConsultarAnaerobica As System.Windows.Forms.Label
    Friend WithEvents lblConsultarFlexibilidad As System.Windows.Forms.Label
    Friend WithEvents lblConsultarFuerza As System.Windows.Forms.Label
    Friend WithEvents lblConsultarResistenciaMuscular As System.Windows.Forms.Label
    Friend WithEvents lblReciliencia As System.Windows.Forms.Label
    Friend WithEvents lblAgenda As System.Windows.Forms.Label
    Friend WithEvents lblResistenciaMonotonia As System.Windows.Forms.Label
    Friend WithEvents lblResistenciaAnaerobica As System.Windows.Forms.Label
    Friend WithEvents lblFlexibilidad As System.Windows.Forms.Label
    Friend WithEvents lblFuerzaMuscular As System.Windows.Forms.Label
    Friend WithEvents lblResistenciaMuscular As System.Windows.Forms.Label
    Friend WithEvents tabEvolucion As System.Windows.Forms.TabControl
    Friend WithEvents grPromedio As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents grCalificacion As System.Windows.Forms.DataVisualization.Charting.Chart
End Class
