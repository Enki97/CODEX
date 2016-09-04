Public Class FrmActividad
    Public esIngles As Boolean = False
    Public actividad As Actividad
    Dim nav = New Navegacion(Me)
    Public Sub actualizar()
        lblConsultarNombre.Text = actividad.nombre
        rtbDescripcion.Text = actividad.descripcion
        imgActividad.LoadAsync(Trim(actividad.imagen))
        imgActividad.SizeMode = PictureBoxSizeMode.StretchImage

        Dim deportistas() As String = actividad.listarDeportistas(actividad.id_actividad)
        lstDeportistas.Items.Clear()
        If deportistas Is Nothing Then
            If esIngles Then
                lstDeportistas.Items.Add("There are not sportmen yet.")
            Else
                lstDeportistas.Items.Add("Aún no se ingresaron deportistas.")
            End If
        Else
            For Each d In deportistas
                lstDeportistas.Items.Add(d)
            Next
        End If

        Dim entrenadores() As String = actividad.listarEntrenadores(actividad.id_actividad)
        lstEntrenadores.Items.Clear()
        If entrenadores Is Nothing Then
            If esIngles Then
                lstEntrenadores.Items.Add("There are not coaches yet.")
            Else
                lstEntrenadores.Items.Add("Aún no se ingresaron entrenadores.")
            End If
        Else
            For Each en In entrenadores
                lstEntrenadores.Items.Add(en)
            Next
        End If

        Dim sectores() As String = actividad.listarSectores(actividad.id_actividad)
        lstSectores.Items.Clear()
        If sectores Is Nothing Then
            If esIngles Then
                lstSectores.Items.Add("There are not sectors yet.")
            Else
                lstSectores.Items.Add("Aún no se ingresaron sectores.")
            End If
        Else
            For Each s In sectores
                If Not s Is Nothing Then
                    lstSectores.Items.Add(s)
                End If
            Next
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        nav.anterior()
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        FrmModificarActividad.esIngles = esIngles
        FrmModificarActividad.actividad = actividad
        FrmModificarActividad.cargarDatos()
        nav.siguiente(FrmModificarActividad)
    End Sub

    Private Sub FrmActividad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.actualizar()
        If esIngles Then
            Me.Text = "Sport/Activity"
            lblAyudaDeportistas.Text = "(List of sportmen that practice this activity," + vbNewLine + _
                                       "do double click on a sportman to see " + vbNewLine + _
                                       "his/her profile)"
            lblDeportistas.Text = "Sportmen:"
            lblDescripcion.Text = "Description:"
            lblEntrenadores.Text = "Coaches:"
            lblSectores.Text = "Sectors:"
            lblSectoresAyuda.Text = "(Availables sectors for the practice of this" + vbNewLine + _
                                    "activity)"
            lblNombre.Text = "Name:"
            btnModificar.Text = "Modify"
        End If
    End Sub

    Private Sub lstDeportistas_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstDeportistas.DoubleClick
        If Not lstDeportistas.SelectedItem = "" Then
            Dim auxDocumento As String = ""
            Dim documento As Integer

            For Each c As Char In lstDeportistas.SelectedItem
                If c = ":" Then
                    Exit For
                Else
                    auxDocumento += c
                End If
            Next

            documento = CInt(Trim(auxDocumento))

            Dim usuario As New Deportista(documento)

            FrmPerfilDeportista.usuario = usuario
            FrmPerfilDeportista.esIngles = esIngles
            FrmPerfilDeportista.cargarPerfil()
            nav.siguiente(FrmPerfilDeportista)
        End If
    End Sub


    Private Sub lstEntrenadores_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstEntrenadores.DoubleClick
        If Not lstEntrenadores.SelectedItem = "" Then
            Dim auxDocumento As String = ""
            Dim documento As Integer

            For Each c As Char In lstEntrenadores.SelectedItem
                If c = ":" Then
                    Exit For
                Else
                    auxDocumento += c
                End If
            Next

            documento = CInt(Trim(auxDocumento))

            Dim usuario As New Entrenador(documento)

            frmPerfilEntrenador.usuario = usuario
            frmPerfilEntrenador.esIngles = esIngles
            frmPerfilEntrenador.cargarPerfil()
            nav.siguiente(frmPerfilEntrenador)
        End If
    End Sub


    Private Sub lstSectores_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstSectores.DoubleClick
        If Not lstSectores.SelectedItem = "" Then
            Dim auxRut As String = ""
            Dim auxNro As String = ""
            Dim pasoComa As Boolean = False
            Dim rut As Long
            Dim nro As Integer
            For Each c As Char In lstSectores.SelectedItem
                If c = "," Then
                    pasoComa = True
                    Continue For
                ElseIf c = ":" Then
                    Exit For
                End If
                If pasoComa Then
                    auxNro += c
                Else
                    auxRut += c
                End If
            Next

            rut = CLng(Trim(auxRut))
            nro = CInt(Trim(auxNro))

            Dim sector As New Sectores(rut, nro)

            FrmSector.sector = sector
            FrmSector.esIngles = esIngles
            FrmSector.cargarDatos()
            nav.siguiente(FrmSector)
        End If
    End Sub
End Class