Public Class FrmAltaActividad
    Public esIngles As Boolean = False
    Dim nav = New Navegacion(Me)
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        nav.anterior()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim comprobar As New Actividad()
        Dim faltan As Boolean = False
        Dim existe As Boolean = False
        Dim strFaltan, strExiste, nombre, descripcion, foto As String
        Dim actividad As New Actividad()

        If esIngles Then
            strFaltan = "The following fields are required: "
            strExiste = "The entered name already exist."
        Else
            strFaltan = "Faltan campos obligatorios: "
            strExiste = "El nombre ingresado ya existe."
        End If
        If txtNombre.Text = "" Then
            faltan = True
            If esIngles Then
                strFaltan += "/Name"
            Else
                strFaltan += "/Nombre"
            End If
        ElseIf comprobar.yaExiste(txtNombre.Text) Then
            existe = True
        Else
            nombre = txtNombre.Text
        End If

        If txtDescripcion.Text = "" Then
            faltan = True
            If esIngles Then
                strFaltan += "/Description"
            Else
                strFaltan += "/Descripcion"
            End If
        Else
            descripcion = txtDescripcion.Text
        End If


        If txtFoto.Text = "" Then
            faltan = True
            If esIngles Then
                strFaltan += "/Foto"
            Else
                strFaltan += "/Photo"
            End If
        Else
            foto = txtFoto.Text
        End If

        If faltan Then
            MsgBox(strFaltan + "/", MsgBoxStyle.Critical)
        ElseIf existe Then
            MsgBox(strExiste, MsgBoxStyle.Critical)
        Else
            actividad.ingresarActividad(nombre, descripcion, txtFoto.Text)
            FrmListarActividad.actualizar()
            nav.anterior()
        End If
    End Sub

    Private Sub FrmAltaActividad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Sistema bilingüe
        If esIngles Then
            Me.Text = "New Sport/Activity"
            lblNombre.Text = "Name:"
            lblDescripcion.Text = "Description:"
            lblFoto.Text = "Photo URL:"
            btnGuardar.Text = "Save"
            btnCancelar.Text = "Cancel"
        End If
    End Sub
End Class