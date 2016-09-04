Public Class FrmModificarEjercicio
    Public esIngles As Boolean = False
    Public ejercicio As Ejercicio
    Dim nav = New Navegacion(Me)

    Public Sub actualizarGrupos()
        cmbGrupoMuscular.Items.Clear()
        Dim g As New GruposMusculares()

        For Each grupo As String In g.listarIDNombre()
            cmbGrupoMuscular.Items.Add(grupo)
        Next
    End Sub

    Public Sub cargarDatos()
        txtNombre.Text = Trim(ejercicio.nombre)
        txtFotoURL.Text = Trim(ejercicio.foto)
        txtURLVideo.Text = "https://www.youtube.com/watch?v=" + Trim(ejercicio.video)
        rtbDescripcion.Text = Trim(ejercicio.descripcion)
        Me.actualizarGrupos()

        lstGruposMusculares.Items.Clear()
        For Each g As String In ejercicio.grupos
            If Not g Is Nothing Then
                lstGruposMusculares.Items.Add(g)
            End If
        Next
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        nav.anterior()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim nombre, descripcion, foto, video As String
        'Validamos los datos ingresados
        Dim comprobar As New Ejercicio()
        Dim id_grupos() As Integer
        Dim consultarID As New GruposMusculares()
        Dim strFaltan As String = "Faltan campos obligatorios: "
        Dim strCorrecto As String = "Procedimiento correcto."
        Dim strError As String = "Se produjo un error: " + vbNewLine
        Dim faltan As Boolean = False

        If esIngles Then
            strFaltan = "The following fields are required: "
            strCorrecto = "Successful procedure." + vbNewLine
            strError = "There was an error: "
        End If

        If txtNombre.Text = "" Then
            faltan = True
            If esIngles Then
                strFaltan += "/Nombre"
            Else
                strFaltan += "/Name"
            End If
        Else
            nombre = txtNombre.Text
        End If

        If rtbDescripcion.Text = "" Then
            faltan = True
            If esIngles Then
                strFaltan += "/Description"
            Else
                strFaltan += "/Descripcion"
            End If
        Else
            descripcion = rtbDescripcion.Text
        End If

        If txtFotoURL.Text = "" Then
            faltan = True
            If esIngles Then
                strFaltan += "/Photo"
            Else
                strFaltan += "/Foto"
            End If
        Else
            foto = txtFotoURL.Text
        End If

        If txtFotoURL.Text = "" Then
            faltan = True
            strFaltan += "/Video"
        Else
            video = txtURLVideo.Text
        End If

        If lstGruposMusculares.Items.Count = 0 Then
            faltan = True
            If esIngles Then
                strFaltan += "/Muscular Groups"
            Else
                strFaltan += "/Grupos Musculares"
            End If
        Else
            ReDim id_grupos(lstGruposMusculares.Items.Count - 1)
            Dim i As Integer = 0
            For Each g As String In lstGruposMusculares.Items
                Dim id As String = ""
                For Each c As Char In g
                    If Char.IsDigit(c) Then
                        id += c
                    Else
                        Exit For
                    End If
                Next
                id_grupos(i) = CInt(id)
                i += 1
            Next
        End If

        'Ingresa nuevo ejercicio
        If faltan Then
            MsgBox(strFaltan + "/", MsgBoxStyle.Critical)
        Else
            If ejercicio.modificarEjercicio(ejercicio.id_ejercicio, nombre, descripcion, foto, video) = 0 Then
                If ejercicio.modificarentrena(ejercicio.id_ejercicio, id_grupos) = 0 Then
                    MsgBox(strCorrecto)

                    FrmEjercicio.ejercicio = New Ejercicio(ejercicio.id_ejercicio)
                    FrmEjercicio.actualizar()
                    nav.anterior()
                Else
                    MsgBox(strError + ejercicio.msg, MsgBoxStyle.Critical)
                End If

            Else
                MsgBox(strError + ejercicio.msg, MsgBoxStyle.Critical)
            End If

            nav.anterior()
        End If
    End Sub

    Private Sub FrmModificarEjercicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cargarDatos()
        If esIngles Then
            Me.Text = "Exercise Modify"
            lblNombre.Text = "Name:"
            lblFotoURL.Text = "Photo URL:"
            lblURLVideo.Text = "Video's URL:"
            lblDescripcion.Text = "Description:"
            lblGruposMusculares.Text = "Muscular Groups:"
            lblEjercita.Text = "Add Muscular Groups:"
            btnAgregarMusculo.Text = "Add"
            btnEliminar.Text = "Delete"
            btnGuardar.Text = "Save"
            btnCancelar.Text = "Cancel"
        End If
    End Sub

    Private Sub btnAgregarMusculo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarMusculo.Click
        If cmbGrupoMuscular.SelectedItem = "" Then
            If esIngles Then
                MsgBox("You must select a muscular group.", MsgBoxStyle.Critical)
            Else
                MsgBox("Debes seleccionar un grupo muscular.", MsgBoxStyle.Critical)
            End If
        Else
            lstGruposMusculares.Items.Add(cmbGrupoMuscular.SelectedItem.ToString)
            cmbGrupoMuscular.Items.Remove(cmbGrupoMuscular.SelectedItem)
        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If lstGruposMusculares.SelectedItem = "" Then
            If esIngles Then
                MsgBox("You must select a muscular group.", MsgBoxStyle.Critical)
            Else
                MsgBox("Debes seleccionar un grupo muscular.", MsgBoxStyle.Critical)
            End If
        Else
            lstGruposMusculares.Items.Remove(lstGruposMusculares.SelectedItem)
        End If
    End Sub
End Class