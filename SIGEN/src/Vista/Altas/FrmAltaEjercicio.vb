Public Class FrmAltaEjercicio
    Public esIngles As Boolean = False
    Dim nav = New Navegacion(Me)

    Public Sub actualizarGrupos()
        cmbGrupoMuscular.Items.Clear()
        Dim g As New GruposMusculares()

        For Each grupo As String In g.listarIDNombre()
            cmbGrupoMuscular.Items.Add(grupo)
        Next
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim nombre, descripcion, foto, video As String
        'Validamos los datos ingresados
        Dim comprobar As New Ejercicio()
        Dim id_grupos() As Integer
        Dim consultarID As New GruposMusculares()
        Dim strFaltan As String = "Faltan campos obligatorios: "
        Dim strExiste As String = "El nombre ingresado ya existe o hubo un error en la base de datos."
        Dim strCorrecto As String = "Procedimiento correcto."
        Dim strError As String = "Se produjo un error: " + vbNewLine
        Dim faltan As Boolean = False
        Dim existe As Boolean = False

        If esIngles Then
            strFaltan = "The following fields are required: "
            strExiste = "The entered name already exists or there was an error in the database."
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
        ElseIf comprobar.yaExiste(txtNombre.Text) Then
            existe = True
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
        ElseIf existe Then
            MsgBox(strExiste, MsgBoxStyle.Critical)
        Else
            Dim ingresar As New Ejercicio()
            If ingresar.ingresarEjercicio(nombre, descripcion, foto, video) = 0 Then
                Dim id_ejercicio As Integer = ingresar.obtenerID(nombre)
                If ingresar.entrena(id_ejercicio, id_grupos) = 0 Then
                    MsgBox(strCorrecto)
                    'Borra los datos ingresados, vuelve al formulario anterior y actualiza la lista
                    FrmListarEjercicios.actualizarLista()
                    txtNombre.Text = ""
                    rtbDescripcion.Text = ""
                    txtFotoURL.Text = ""
                    txtURLVideo.Text = ""
                    ingresar = Nothing
                    id_grupos = Nothing
                    Me.actualizarGrupos()
                    lstGruposMusculares.Items.Clear()
                    nav.anterior()
                Else
                    MsgBox(strError + ingresar.msg, MsgBoxStyle.Critical)
                End If

            Else
                MsgBox(strError + ingresar.msg, MsgBoxStyle.Critical)
            End If

            nav.anterior()
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        nav.anterior()
    End Sub

    Private Sub FrmAltaEjercicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.actualizarGrupos()
        If esIngles Then
            Me.Text = "New Exercise"
            lblDescripcion.Text = "Description:"
            lblEjercita.Text = "Select the Muscular Groups that" + vbNewLine + _
                               "this exercise improve:"
            lblFotoURL.Text = "Photo URL:"
            lblGruposMusculares.Text = "Muscular Groups:"
            lblNombre.Text = "Name:"
            lblURLVideo.Text = "Video's URL:"
            btnAgregarMusculo.Text = "Add"
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
End Class