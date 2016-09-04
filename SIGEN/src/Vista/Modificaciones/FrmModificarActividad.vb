Public Class FrmModificarActividad
    Public esIngles As Boolean = False
    Public actividad As Actividad
    Dim nav = New Navegacion(Me)

    Public Sub cargarDatos()
        txtNombre.Text = actividad.nombre
        txtFoto.Text = actividad.imagen
        txtDescripcion.Text = actividad.descripcion
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        nav.anterior()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim faltan As Boolean = False
        Dim strFaltan, nombre, descripcion, foto As String
        If esIngles Then
            strFaltan = "The following fields are required: "
        Else
            strFaltan = "Faltan campos obligatorios: "
        End If

        If txtNombre.Text = "" Then
            faltan = True
            If esIngles Then
                strFaltan += "/Name"
            Else
                strFaltan += "/Nombre"
            End If
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
        Else
            actividad.modificarActividad(actividad.id_actividad, nombre, descripcion, txtFoto.Text)
            FrmActividad.actividad = New Actividad(actividad.id_actividad)
            FrmActividad.actualizar()
            nav.anterior()
        End If
    End Sub

    Private Sub FrmModificarActividad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If esIngles Then
            Me.Text = "Modify Activity/Sport"
            lblNombre.Text = "Name:"
            lblDescripcion.Text = "Description:"
            lblFoto.Text = "Photo URL:"
            btnCancelar.Text = "Cancel"
            btnGuardar.Text = "Save"
        End If
    End Sub
End Class