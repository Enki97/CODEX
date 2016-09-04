Public Class FrmAltaEvolucion
    Public esIngles As Boolean = False
    Dim nav = New Navegacion(Me)
    ' TODO: Se ingresa como fecha, la fecha actual, es decir la fecha en la que el entrenador califica

    Public Sub actualizarLista()
        Dim strNoDeportista = "Aún no se han registrado deportistas."
        If esIngles Then
            strNoDeportista = "No sportmen added yet."
        End If
        lstDeportistas.Items.Clear()
        Dim lista As New Usuario()
        Dim deportistas As Dictionary(Of Integer, String) = lista.listar("deportista")
        If deportistas.Count > 0 Then
            For Each d In deportistas
                lstDeportistas.Items.Add(d.Key.ToString & " : " & d.Value.ToString)
            Next
        Else
            lstDeportistas.Items.Clear()
            lstDeportistas.Items.Add(strNoDeportista)
        End If
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        nav.anterior()
    End Sub

    Private Sub btnGuardarSeguir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarSeguir.Click
        Dim cumplimiento, rAnaerobica, rMuscular, fMuscular, flexibilidad, rMonotonia, reciliencia As Integer
        Dim usuario As Usuario = FrmLogin.obtenerSesion()
        Dim entrenador As New Entrenador(usuario.documento)
        Dim strFaltan As String = "Faltan campos obligatorios: "
        Dim strExiste As String = "El deportista es entrenado por otro entrenador o hubo un error en la base de datos."
        Dim strCorrecto As String = "Procedimiento correcto."
        Dim strError As String = "Se produjo un error: " + vbNewLine
        Dim faltan As Boolean = False

        If esIngles Then
            strFaltan = "The following fields are required: "
            strExiste = "The sportman is trained by other coach or there was an error in the database."
            strCorrecto = "Successful procedure." + vbNewLine
            strError = "There was an error: "
        End If
        If cmbAgenda.SelectedItem = "" Then
            faltan = True
            If esIngles Then
                strFaltan += "/Compliance with the Schedule"
            Else
                strFaltan += "/Cumplimiento con la agenda"
            End If
        Else
            cumplimiento = cmbAgenda.SelectedItem.ToString
        End If

        If cmbFlexibilidad.SelectedItem = "" Then
            faltan = True
            If esIngles Then
                strFaltan += "/Flexibility"
            Else
                strFaltan += "/Flexibilidad"
            End If
        Else
            flexibilidad = cmbFlexibilidad.SelectedItem.ToString
        End If

        If cmbFuerzaMuscular.SelectedItem = "" Then
            faltan = True
            If esIngles Then
                strFaltan += "/Muscular Force"
            Else
                strFaltan += "/Fuerza Muscular"
            End If
        Else
            fMuscular = cmbFuerzaMuscular.SelectedItem.ToString
        End If

        If cmbResiliencia.SelectedItem = "" Then
            faltan = True
            If esIngles Then
                strFaltan += "/Recilience"
            Else
                strFaltan += "/Reciliencia"
            End If
        Else
            reciliencia = cmbResiliencia.SelectedItem.ToString
        End If

        If cmbResistenciaAnaerobica.SelectedItem = "" Then
            faltan = True
            If esIngles Then
                strFaltan += "/Anaerobic Endurance"
            Else
                strFaltan += "/Resistencia Anaerobica"
            End If
        Else
            rAnaerobica = cmbResistenciaAnaerobica.SelectedItem.ToString
        End If

        If cmbResistenciaMonotonia.SelectedItem = "" Then
            faltan = True
            If esIngles Then
                strFaltan += "/Resistance to Monotony"
            Else
                strFaltan += "/Resistencia a la monotonia"
            End If
        Else
            rMonotonia = cmbResistenciaMonotonia.SelectedItem.ToString
        End If

        If cmbResistenciaMuscular.SelectedItem = "" Then
            faltan = True
            If esIngles Then
                strFaltan += "/Muscular Endurance"
            Else
                strFaltan += "/Resistencia Muscular"
            End If
        Else
            rMuscular = cmbResistenciaMuscular.SelectedItem.ToString
        End If

        If lstDeportistas.SelectedItem = "" Then
            faltan = True
            If esIngles Then
                strFaltan += "/Sportman"
            Else
                strFaltan += "/Deportista"
            End If
            MsgBox(strFaltan + "/", MsgBoxStyle.Critical)
        Else
            If faltan Then
                MsgBox(strFaltan + "/", MsgBoxStyle.Critical)
            Else
                Dim documento As String = lstDeportistas.SelectedItem.ToString
                documento = documento.Substring(0, 8)
                Dim deportista = New Deportista(CInt(documento))
                Dim evolucion As New Evolucion(deportista, entrenador)
                If deportista.tieneCalificacion() Then
                    If evolucion.correspondeEntrenador(deportista.documento, entrenador.documento) Then
                        evolucion.ingresarCalificacion(cumplimiento, rAnaerobica, rMuscular, fMuscular, flexibilidad, rMonotonia, reciliencia)
                        MsgBox(strCorrecto)
                    Else
                        MsgBox(strExiste, MsgBoxStyle.Critical)
                    End If
                Else
                    evolucion.ingresarCalificacion(cumplimiento, rAnaerobica, rMuscular, fMuscular, flexibilidad, rMonotonia, reciliencia)
                    MsgBox(strCorrecto)
                End If
            End If
        End If
           


    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim cumplimiento, rAnaerobica, rMuscular, fMuscular, flexibilidad, rMonotonia, reciliencia As Integer
        Dim usuario As Usuario = FrmLogin.obtenerSesion()
        Dim entrenador As New Entrenador(usuario.documento)
        Dim strFaltan As String = "Faltan campos obligatorios: "
        Dim strExiste As String = "El deportista es entrenado por otro entrenador o hubo un error en la base de datos."
        Dim strCorrecto As String = "Procedimiento correcto."
        Dim strError As String = "Se produjo un error: " + vbNewLine
        Dim faltan As Boolean = False

        If esIngles Then
            strFaltan = "The following fields are required: "
            strExiste = "The sportman is trained by other coach or there was an error in the database."
            strCorrecto = "Successful procedure." + vbNewLine
            strError = "There was an error: "
        End If
        If cmbAgenda.SelectedItem = "" Then
            faltan = True
            If esIngles Then
                strFaltan += "/Compliance with the Schedule"
            Else
                strFaltan += "/Cumplimiento con la agenda"
            End If
        Else
            cumplimiento = cmbAgenda.SelectedItem.ToString
        End If

        If cmbFlexibilidad.SelectedItem = "" Then
            faltan = True
            If esIngles Then
                strFaltan += "/Flexibility"
            Else
                strFaltan += "/Flexibilidad"
            End If
        Else
            flexibilidad = cmbFlexibilidad.SelectedItem.ToString
        End If

        If cmbFuerzaMuscular.SelectedItem = "" Then
            faltan = True
            If esIngles Then
                strFaltan += "/Muscular Force"
            Else
                strFaltan += "/Fuerza Muscular"
            End If
        Else
            fMuscular = cmbFuerzaMuscular.SelectedItem.ToString
        End If

        If cmbResiliencia.SelectedItem = "" Then
            faltan = True
            If esIngles Then
                strFaltan += "/Recilience"
            Else
                strFaltan += "/Reciliencia"
            End If
        Else
            reciliencia = cmbResiliencia.SelectedItem.ToString
        End If

        If cmbResistenciaAnaerobica.SelectedItem = "" Then
            faltan = True
            If esIngles Then
                strFaltan += "/Anaerobic Endurance"
            Else
                strFaltan += "/Resistencia Anaerobica"
            End If
        Else
            rAnaerobica = cmbResistenciaAnaerobica.SelectedItem.ToString
        End If

        If cmbResistenciaMonotonia.SelectedItem = "" Then
            faltan = True
            If esIngles Then
                strFaltan += "/Resistance to Monotony"
            Else
                strFaltan += "/Resistencia a la monotonia"
            End If
        Else
            rMonotonia = cmbResistenciaMonotonia.SelectedItem.ToString
        End If

        If cmbResistenciaMuscular.SelectedItem = "" Then
            faltan = True
            If esIngles Then
                strFaltan += "/Muscular Endurance"
            Else
                strFaltan += "/Resistencia Muscular"
            End If
        Else
            rMuscular = cmbResistenciaMuscular.SelectedItem.ToString
        End If

        If lstDeportistas.SelectedItem = "" Then
            faltan = True
            If esIngles Then
                strFaltan += "/Sportman"
            Else
                strFaltan += "/Deportista"
            End If
            MsgBox(strFaltan + "/", MsgBoxStyle.Critical)
        Else
            If faltan Then
                MsgBox(strFaltan + "/", MsgBoxStyle.Critical)
            Else
                Dim documento As String = lstDeportistas.SelectedItem.ToString
                documento = documento.Substring(0, 8)
                Dim deportista = New Deportista(CInt(documento))
                Dim evolucion As New Evolucion(deportista, entrenador)
                If deportista.tieneCalificacion() Then
                    If evolucion.correspondeEntrenador(documento, entrenador.documento) Then
                        evolucion.ingresarCalificacion(cumplimiento, rAnaerobica, rMuscular, fMuscular, flexibilidad, rMonotonia, reciliencia)
                        MsgBox(strCorrecto)
                        nav.anterior()
                    Else
                        MsgBox(strExiste, MsgBoxStyle.Critical)
                    End If
                Else
                    evolucion.ingresarCalificacion(cumplimiento, rAnaerobica, rMuscular, fMuscular, flexibilidad, rMonotonia, reciliencia)
                    MsgBox(strCorrecto)
                    nav.anterior()
                End If
            End If
           
        End If

    End Sub

    Private Sub FrmAltaEvolucion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.actualizarLista()

        If esIngles Then
            Me.Text = "Qualify"
            lblAgenda.Text = "Compliance with the Schedule:"
            lblDeportista.Text = "Select the Sportman:"
            lblFlexibilidad.Text = "Flexibility:"
            lblFuerzaMuscular.Text = "Muscular Force:"
            lblReciliencia.Text = "Resilience:"
            lblResistenciaAnaerobica.Text = "Anaerobic Endurance:"
            lblResistenciaMonotonia.Text = "Resistance to Monotony:"
            lblResistenciaMuscular.Text = "Muscular Endurance:"
            btnCancelar.Text = "Cancel"
            btnGuardar.Text = "Save and Exit"
            btnGuardarSeguir.Text = "Save and Qualify"
        End If
    End Sub
End Class