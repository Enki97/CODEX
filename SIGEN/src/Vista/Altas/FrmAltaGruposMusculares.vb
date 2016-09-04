Public Class FrmAltaGruposMusculares
    Public esIngles As Boolean = False
    Dim nav = New Navegacion(Me)
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        'Borra los datos ingresados y vuelve al formulario anterior
        txtNombre.Text = ""
        rtbDescripcion.Text = ""
        txtFotoURL.Text = ""
        cmbTipo.SelectedItem = ""
        nav.anterior()
    End Sub

    Private Sub bnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        'Validamos los datos ingresados
        Dim comprobar As New GruposMusculares()
        Dim nombre, descripcion, foto, tipo As String
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
        Else
            If comprobar.yaExiste(txtNombre.Text) Then
                existe = True
            Else
                nombre = txtNombre.Text
            End If
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
        ElseIf existe Then
            MsgBox(strExiste, MsgBoxStyle.Critical)
        Else
            Dim ingresar As New GruposMusculares()
            If ingresar.ingresarGrupos(nombre, descripcion, foto, tipo) = 0 Then
                MsgBox(strCorrecto)
                'Actualizamos el combo de grupos musculares del formulario alta ejercicio
                FrmAltaEjercicio.actualizarGrupos()
                'Borra los datos ingresados, vuelve al formulario anterior y actualiza la lista
                FrmListarGruposMusculares.actualizarLista()
                txtNombre.Text = ""
                rtbDescripcion.Text = ""
                txtFotoURL.Text = ""
                cmbTipo.SelectedItem = ""
                nav.anterior()
            Else
                MsgBox(strError + ingresar.msg, MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub FrmAltaGruposMusculares_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If esIngles Then
            Me.Text = "New Muscular Group"
            lblDescripcion.Text = "Description:"
            lblFotoURL.Text = "Photo URL:"
            lblNombre.Text = "Name:"
            lblTipo.Text = "Type:"
            btnCancelar.Text = "Cancel"
            btnGuardar.Text = "Save"
        End If
    End Sub
End Class