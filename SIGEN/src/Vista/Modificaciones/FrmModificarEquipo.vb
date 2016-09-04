Public Class FrmModificarEquipo
    Public esIngles As Boolean = False
    Public equipo As Equipos
    Dim nav = New Navegacion(Me)

    Sub actualizarActividad()
        cmbActividad.Items.Clear()
        Dim act As New Actividad()
        Dim actividad() As String = act.listar()
        For Each a In actividad
            cmbActividad.Items.Add(a)
        Next
    End Sub
    Public Sub cargarDatos()
        Dim idActividad As Integer
        Dim nombreActividad As String
        txtCategoria.Text = Trim(equipo.categoria)
        idActividad = equipo.actividad.id_actividad
        nombreActividad = Trim(equipo.actividad.nombre)
        cmbActividad.SelectedText = idActividad.ToString + " : " + nombreActividad
        Me.actualizarActividad()
        lstDeportista.Items.Clear()
        For Each d As String In equipo.deportistas
            If Not d Is Nothing Then
                lstDeportista.Items.Add(Trim(d))
            End If
        Next
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        nav.anterior()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim categoria As String
        Dim actividad, deportistas() As Integer
        Dim esSeleccion As Boolean
        Dim strFaltan As String = "Faltan campos obligatorios: "
        Dim strCorrecto As String = "Procedimiento correcto."
        Dim strError As String = "Se produjo un error: " + vbNewLine
        Dim faltan As Boolean = False

        If esIngles Then
            strFaltan = "The following fields are required: "
            strCorrecto = "Successful procedure." + vbNewLine
            strError = "There was an error: "
        End If

        If txtCategoria.Text = "" Then
            faltan = True
            If esIngles Then
                strFaltan += "/Category"
            Else
                strFaltan += "/Categoria"
            End If
        Else
            categoria = txtCategoria.Text
        End If

        If ckbEsSeleccion.Checked Then
            esSeleccion = True
        Else
            esSeleccion = False
        End If
        If lstDeportista.Items.Count > 0 Then
            Dim strActividad As String = ""
            For Each c As Char In cmbActividad.SelectedItem.ToString
                If c = ":" Then
                    Exit For
                Else
                    strActividad += c
                End If
            Next
            actividad = CInt(Trim(strActividad))
            ReDim deportistas(lstDeportista.Items.Count)
            Dim i As Integer = 0
            For Each d As Integer In lstDeportista.Items
                deportistas(i) = d
                i += 1
            Next
        Else
            faltan = True
            If esIngles Then
                strFaltan += "/Sportsman"
            Else
                strFaltan += "/Deportistas"
            End If
        End If


        If faltan Then
            MsgBox(strFaltan)
        Else
            Dim id As Integer
            id = equipo.modificarEquipo(equipo.id_equipo, categoria, esSeleccion, actividad)
            equipo.modificarRelacion(id, deportistas)
            MsgBox(strCorrecto)

            FrmEquipo.equipo = New Equipos(equipo.id_equipo)
            FrmEquipo.actualizar()
            nav.anterior()
        End If
    End Sub

    Private Sub FrmModificarEquipo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If esIngles Then
            lblCategoria.Text = "Category:"
            lblActividad.Text = "Activity/Sport:"
            lblEsSeleccion.Text = "Indicate if this team is a selection:"
            ckbEsSeleccion.Text = "It's Selection"
            lblDeportista.Text = "Sportmen:"
            lblSeleccioneDeportista.Text = "Select a sportman to add:"
            btnAgregar.Text = "Add"
            btnEliminar.Text = "Delete"
            btnGuardar.Text = "Save"
            btnCancelar.Text = "Cancel"
        End If
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim car As Char = CChar(cmbDeportistas.SelectedItem())
        Dim strDocumento As String = ""
        Dim documento As Integer = 0
        If Char.IsDigit(car) Then
            For Each c As Char In cmbDeportistas.SelectedItem()
                If c = ":" Then
                    Exit For
                Else
                    strDocumento += c
                End If
            Next
            documento = CInt(Trim(strDocumento))

            lstDeportista.Items.Add(documento)
        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim car As Char = CChar(lstDeportista.SelectedItem())
        Dim strDocumento As String = ""
        Dim documento As Integer = 0
        If Char.IsDigit(car) Then
            For Each c As Char In lstDeportista.SelectedItem()
                If c = ":" Then
                    Exit For
                Else
                    strDocumento += c
                End If
            Next
            documento = CInt(Trim(strDocumento))

            lstDeportista.Items.Remove(documento)
        End If
    End Sub
    Sub listaDeportistas()
        lstDeportista.Items.Clear()
        If cmbActividad.SelectedItem = "" Then
            cmbDeportistas.Items.Clear()
            If esIngles Then
                cmbDeportistas.Items.Add("You must select an activity")
            Else
                cmbDeportistas.Items.Add("Debe seleccionar una actividad")
            End If
        Else

            Dim equipo As New Equipos()
            Dim deportistas() As String
            Dim actividad As String
            Dim id_actividad As String = ""
            Dim id As Integer
            actividad = cmbActividad.SelectedItem()
            For Each c As Char In actividad
                If c = ":" Then
                    Exit For
                Else
                    id_actividad += c
                End If
            Next

            id = CInt(Trim(id_actividad))

            If ckbEsSeleccion.Checked Then
                deportistas = equipo.listarSeleccionables(id)
                If deportistas Is Nothing Then
                    cmbDeportistas.Items.Clear()
                    If esIngles Then
                        cmbDeportistas.Items.Add("There aren't Sportsman that pass the conditions")
                    Else
                        cmbDeportistas.Items.Add("No se han ingresado deportistas que cumplan las condiciones")
                    End If
                Else
                    cmbDeportistas.Items.Clear()
                    For Each d As String In deportistas
                        If Not d Is Nothing Then
                            cmbDeportistas.Items.Add(d)
                        End If
                    Next
                End If
            Else
                deportistas = equipo.listarDeportistas(id)
                If deportistas Is Nothing Then
                    cmbDeportistas.Items.Clear()
                    If esIngles Then
                        cmbDeportistas.Items.Add("There aren't Sportsman that pass the conditions")
                    Else
                        cmbDeportistas.Items.Add("No se han ingresado deportistas que cumplan las condiciones")
                    End If
                Else
                    cmbDeportistas.Items.Clear()
                    For Each d As String In deportistas
                        If Not d Is Nothing Then
                            cmbDeportistas.Items.Add(d)
                        End If
                    Next
                End If
            End If
            deportistas = Nothing
        End If
    End Sub

    Private Sub ckbEsSeleccion_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ckbEsSeleccion.CheckedChanged
        Me.listaDeportistas()
    End Sub

    Private Sub cmbActividad_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbActividad.SelectedIndexChanged
        Me.listaDeportistas()
    End Sub
End Class