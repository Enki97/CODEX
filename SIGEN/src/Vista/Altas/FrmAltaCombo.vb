Public Class FrmAltaCombo
    Public esIngles As Boolean = False
    Dim nav = New Navegacion(Me)

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        nav.anterior()
    End Sub

    Sub actualizarEjercicios()
        cmbAgregar.Items.Clear()
        Dim ej As New Ejercicio()

        For Each ejercicio As String In ej.listarIDNombre()
            cmbAgregar.Items.Add(ejercicio)
        Next
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim combo As New Combo()
        Dim nombre, descripcion As String
        Dim ejercicios() As Integer
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
        ElseIf combo.yaExiste(txtNombre.Text) Then
            existe = True
            strExiste += combo.msg
        Else
            nombre = txtNombre.Text
        End If

        If rtxDescripcion.Text = "" Then
            faltan = True
            If esIngles Then
                strFaltan += "/Desription"
            Else
                strFaltan += "/Descripcion"
            End If
        Else
            descripcion = rtxDescripcion.Text
        End If

        If lstEjercicios.Items.Count = 0 Then
            faltan = True
            If esIngles Then
                strFaltan += "/Exercises"
            Else
                strFaltan += "/Ejercicios"
            End If
        Else
            ReDim ejercicios(lstEjercicios.Items.Count - 1)
            Dim i As Integer = 0
            For Each ej As String In lstEjercicios.Items
                Dim id As String = ""
                For Each c As Char In ej
                    If Char.IsDigit(c) Then
                        id += c
                    Else
                        Exit For
                    End If
                Next
                ejercicios(i) = CInt(id)
                i += 1
            Next
        End If

        'Ingresa nuevo combo
        If faltan Then
            MsgBox(strFaltan + "/", MsgBoxStyle.Critical)
        ElseIf existe Then
            MsgBox(strExiste, MsgBoxStyle.Critical)
        Else
            Dim ingresar As New Combo()
            If ingresar.ingresarCombo(nombre, descripcion) = 0 Then
                Dim id_combo As Integer = ingresar.obtenerID(nombre)
                If ingresar.agrupan(id_combo, ejercicios) = 0 Then
                    MsgBox(strCorrecto)
                    'Borra los datos ingresados, vuelve al formulario anterior y actualiza la lista
                    FrmListarCombos.actualizarLista()
                    txtNombre.Text = ""
                    rtxDescripcion.Text = ""
                    ingresar = Nothing
                    ejercicios = Nothing
                    Me.actualizarEjercicios()
                    lstEjercicios.Items.Clear()
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

    Private Sub FrmAltaCombo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.actualizarEjercicios()

        If esIngles Then
            Me.Text = "New Combo"
            lblDescripcion.Text = "Description:"
            lblEjercicios.Text = "Exercises:"
            lblNombre.Text = "Name:"
            lblSeleccioneEjercicio.Text = "Select the exercise to add:"
            btnAgregarEjercicio.Text = "Add"
            btnCancelar.Text = "Cancel"
            btnGuardar.Text = "Save"
        End If
    End Sub

    Private Sub btnAgregarEjercicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarEjercicio.Click
        If cmbAgregar.SelectedItem = "" Then
            If esIngles Then
                MsgBox("You must select an exercise.", MsgBoxStyle.Critical)
            Else
                MsgBox("Debes seleccionar un ejercicio.", MsgBoxStyle.Critical)
            End If
        Else
            lstEjercicios.Items.Add(cmbAgregar.SelectedItem.ToString)
            cmbAgregar.Items.Remove(cmbAgregar.SelectedItem)
        End If
    End Sub
End Class