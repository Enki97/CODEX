Public Class FrmModificarGruposMusculares
    Public esIngles As Boolean = False
    Public grupos As GruposMusculares
    Dim nav = New Navegacion(Me)

    Public Sub cargarDatos()
        txtNombre.Text = Trim(grupos.nombre)
        txtFotoURL.Text = Trim(grupos.foto)
        rtbDescripcion.Text = Trim(grupos.descripcion)
        cmbTipo.SelectedText = Trim(grupos.tipo)
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        nav.anterior()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        'Validamos los datos ingresados
        Dim comprobar As New GruposMusculares()
        Dim nombre, descripcion, foto, tipo As String
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

        If cmbTipo.SelectedItem = "" Then
            faltan = True
            If esIngles Then
                strFaltan += "/Type"
            Else
                strFaltan += "/Tipo"
            End If
        Else
            tipo = cmbTipo.SelectedItem.ToString
        End If

        'Ingresa nuevo grupo muscular
        If faltan Then
            MsgBox(strFaltan + "/", MsgBoxStyle.Critical)
        Else
            If grupos.modificarGrupos(grupos.id_grupos, nombre, descripcion, foto, tipo) = 0 Then
                MsgBox(strCorrecto)
                FrmGruposMusculares.grupo = New GruposMusculares(grupos.id_grupos)
                FrmGruposMusculares.actualizar()
                nav.anterior()
            Else
                MsgBox(strError + grupos.msg, MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub FrmModificarGruposMusculares_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cargarDatos()

        If esIngles Then
            Me.Text = "Muscular Group Modify"
            lblNombre.Text = "Name:"
            lblFotoURL.Text = "Photo URL:"
            lblDescripcion.Text = "Description:"
            lblTipo.Text = "Type:"
            btnCancelar.Text = "Cancel"
            btnGuardar.Text = "Save"
        End If
    End Sub
End Class