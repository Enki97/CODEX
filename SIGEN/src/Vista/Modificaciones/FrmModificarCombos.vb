Public Class frmModificarCombos
    Public esIngles As Boolean = False
    Public combo As Combo
    Dim nav = New Navegacion(Me)

    Sub cargarEjercicios()
        cmbAgregar.Items.Clear()
        Dim ej As New Ejercicio()

        For Each ejercicio As String In ej.listarIDNombre()
            cmbAgregar.Items.Add(ejercicio)
        Next
    End Sub
    Public Sub cargarDatos()
        Me.cargarEjercicios()
        txtNombre.Text = combo.nombre
        rtxDescripción.Text = combo.descripcion

        lstEjercicios.Items.Clear()
        For Each ej As String In combo.ejercicios
            If Not ej Is Nothing Then
                lstEjercicios.Items.Add(ej)
            End If
        Next
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        nav.anterior()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim nombre, descripcion As String
        Dim ejercicios() As Integer
        Dim strFaltan As String = "Faltan campos obligatorios: "
        Dim strExiste As String = "El nombre ingresado ya existe o hubo un error en la base de datos."
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

        If rtxDescripción.Text = "" Then
            faltan = True
            If esIngles Then
                strFaltan += "/Desription"
            Else
                strFaltan += "/Descripcion"
            End If
        Else
            descripcion = rtxDescripción.Text
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
        Else
            If combo.modificarcombo(combo.id_combo, nombre, descripcion) = 0 Then
                If combo.modificarAgrupan(combo.id_combo, ejercicios) = 0 Then
                    MsgBox(strCorrecto)
                    FrmCombo.combo = New Combo(combo.id_combo)
                    FrmCombo.actualizar()
                    nav.anterior()
                Else
                    MsgBox(strError + combo.msg, MsgBoxStyle.Critical)
                End If

            Else
                MsgBox(strError + combo.msg, MsgBoxStyle.Critical)
            End If

            nav.anterior()
        End If
    End Sub

    Private Sub frmModificarCombos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cargarDatos()
        If esIngles Then
            Me.Text = "Combos Modify"
            lblNombre.Text = "Name:"
            lblDescripción.Text = "Description:"
            lblEjercicios.Text = "Exercises:"
            lblSeleccioneEjercicio.Text = "Select the exercise to add:"
            btnAgregarEjercicio.Text = "Add"
            btnEliminar.Text = "Delete"
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

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If lstEjercicios.SelectedItem = "" Then
            If esIngles Then
                MsgBox("You must select an exercise.", MsgBoxStyle.Critical)
            Else
                MsgBox("Debes seleccionar un ejercicio.", MsgBoxStyle.Critical)
            End If
        Else
            lstEjercicios.Items.Remove(lstEjercicios.SelectedItem)
        End If
    End Sub
End Class