Public Class FrmEvolucion
    Public esIngles As Boolean = False
    Public deportista As Deportista
    Dim nav = New Navegacion(Me)

    Sub setValorCumplimiento(ByVal i As Integer, ByVal valor As Integer)
        grCalificacion.Series(0).Points(i).XValue = valor
        grCalificacion.Series(0).Points(i).YValues(0) = CDbl(valor)
        grCalificacion.Series(0).Points(i).YValues(1) = CDbl(valor)
    End Sub

    Sub calificacionActual(ByVal evolucion As Evolucion)
        Dim califiacion() As Integer = evolucion.ultimaCalificacion()
        Dim cumplimiento, rAnaerobica, rMuscular, fMuscular, flexibilidad, rMonotonia, reciliencia, promedio As Integer
        cumplimiento = califiacion(0)
        rAnaerobica = califiacion(1)
        rMuscular = califiacion(2)
        fMuscular = califiacion(3)
        flexibilidad = califiacion(4)
        rMonotonia = califiacion(5)
        reciliencia = califiacion(6)
        promedio = califiacion(7)

        lblCalcularPromedio.Text = promedio.ToString
        lblConsultarAnaerobica.Text = rAnaerobica.ToString
        lblConsultarCumplimiento.Text = cumplimiento.ToString
        lblConsultarFlexibilidad.Text = flexibilidad.ToString
        lblConsultarFuerza.Text = fMuscular.ToString
        lblConsultarMonotonia.Text = rMonotonia.ToString
        lblConsultarResiliencia.Text = reciliencia.ToString
        lblConsultarResistenciaMuscular.Text = rMuscular.ToString

        grCalificacion.ChartAreas(0).AxisY.Maximum = 20

        setValorCumplimiento(0, cumplimiento)
        setValorCumplimiento(1, rAnaerobica)
        setValorCumplimiento(2, rMuscular)
        setValorCumplimiento(3, fMuscular)
        setValorCumplimiento(4, flexibilidad)
        setValorCumplimiento(5, rMonotonia)
        setValorCumplimiento(6, reciliencia)
    End Sub

    Sub graficaEvolutiva(ByVal evolucion As Evolucion)
        Dim diccionario As Dictionary(Of Date, Integer()) = evolucion.consultarEvolucion()
        Dim califiacion(), cumplimiento, rAnaerobica, rMuscular, fMuscular, flexibilidad, rMonotonia, reciliencia As Integer
        Dim fecha As Date

        grEvolucion.ChartAreas(0).AxisX.Minimum = diccionario.Keys(0).ToOADate()
        grEvolucion.ChartAreas(0).AxisX.Maximum = diccionario.Keys(diccionario.Keys.Count - 1).ToOADate

        For Each evo In diccionario
            califiacion = evo.Value
            fecha = evo.Key

            cumplimiento = califiacion(0)
            rAnaerobica = califiacion(1)
            rMuscular = califiacion(2)
            fMuscular = califiacion(3)
            flexibilidad = califiacion(4)
            rMonotonia = califiacion(5)
            reciliencia = califiacion(6)

            grEvolucion.Series(0).Points.AddXY(fecha, cumplimiento)
            grEvolucion.Series(1).Points.AddXY(fecha, rAnaerobica)
            grEvolucion.Series(2).Points.AddXY(fecha, fMuscular)
            grEvolucion.Series(3).Points.AddXY(fecha, rMuscular)
            grEvolucion.Series(4).Points.AddXY(fecha, flexibilidad)
            grEvolucion.Series(5).Points.AddXY(fecha, rMonotonia)
            grEvolucion.Series(6).Points.AddXY(fecha, reciliencia)
        Next
    End Sub

    Sub graficaPromedio(ByVal evolucion As Evolucion)
        Dim diccionario As Dictionary(Of Date, Integer()) = evolucion.consultarEvolucion()
        Dim califiacion(), promedio As Integer
        Dim fecha As Date

        grPromedio.ChartAreas(0).AxisX.Minimum = diccionario.Keys(0).ToOADate
        grPromedio.ChartAreas(0).AxisX.Maximum = diccionario.Keys(diccionario.Keys.Count - 1).ToOADate

        For Each evo In diccionario
            califiacion = evo.Value
            fecha = evo.Key

            promedio = califiacion(7)

            grPromedio.Series(0).Points.AddXY(fecha, promedio)
        Next
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        nav.anterior()
    End Sub

    Private Sub FrmEvolucion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim evolucion As New Evolucion(deportista)

        Me.calificacionActual(evolucion)
        Me.graficaEvolutiva(evolucion)
        Me.graficaPromedio(evolucion)

        If esIngles Then
            Me.Text = "Evolution"
            tabTabular.Text = "Qualification"
            tabGrafica.Text = "Evolutive Chart"
            tabPromedio.Text = "Evolution Average"
            lblAgenda.Text = "Compliance with the Schedule:"
            lblResistenciaAnaerobica.Text = "Anaerobic Endurance:"
            lblFuerzaMuscular.Text = "Muscular Force:"
            lblResistenciaMuscular.Text = "Muscular Endurance:"
            lblFlexibilidad.Text = "Flexibility:"
            lblResistenciaMonotonia.Text = "Resistance to Monotony:"
            lblReciliencia.Text = "Recilience:"
            lblPromedio.Text = "Average:"
            grCalificacion.Series(0).Points(0).Label = "Compilance"
            grCalificacion.Series(0).Points(1).Label = "Anaerobic Endurance"
            grCalificacion.Series(0).Points(2).Label = "Muscular Force"
            grCalificacion.Series(0).Points(3).Label = "Muscular Endurance"
            grCalificacion.Series(0).Points(4).Label = "Flexibility"
            grCalificacion.Series(0).Points(5).Label = "Resistence to Monotony"
            grCalificacion.Series(0).Points(6).Label = "Recilience"
            grEvolucion.Series(0).Name = "Compilance with the schedule"
            grEvolucion.Series(1).Name = "Anaerobic Endurance"
            grEvolucion.Series(2).Name = "Muscular Force"
            grEvolucion.Series(3).Name = "Muscular Endurance"
            grEvolucion.Series(4).Name = "Flexibility"
            grEvolucion.Series(5).Name = "Resistence to Monotony"
            grEvolucion.Series(6).Name = "Recilience"
            grPromedio.Series(0).Name = "Average"
        End If
    End Sub
End Class