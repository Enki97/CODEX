Public Class FrmListarEjercicios
    Public esIngles As Boolean = False
    Dim nav = New Navegacion(Me)


    Public Sub actualizarLista()
        Dim strNoEjercicio = "Aún no se han registrado ejercicios."
        If esIngles Then
            strNoEjercicio = "No exercise added yet."
        End If
        lstListaEjercicios.Items.Clear()
        Dim lista As New Ejercicio()
        Dim ejercicios() As String = lista.listar()
        If Not ejercicios Is Nothing Then
            For Each e In ejercicios
                lstListaEjercicios.Items.Add(e)
            Next
        Else
            lstListaEjercicios.Items.Clear()
            lstListaEjercicios.Items.Add(strNoEjercicio)
        End If
    End Sub

    Private Sub btnAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtras.Click
        nav.anterior()
    End Sub

    Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click
        If lstListaEjercicios.SelectedItem = "" Then
            Dim strError As String = "Debe seleccionar un ejercicio"
            If esIngles Then
                strError = "You must select a exercise"
            End If
            MsgBox(strError, MsgBoxStyle.Critical)
        Else
            Dim nombre As String = lstListaEjercicios.SelectedItem.ToString
            Dim ej As New Ejercicio
            Dim id As Integer = ej.obtenerID(nombre)
            If id >= 0 Then
                Dim ejercicio = New Ejercicio(id)
                FrmEjercicio.esIngles = esIngles
                FrmEjercicio.ejercicio = ejercicio
                FrmEjercicio.actualizar()
                nav.siguiente(FrmEjercicio)
            Else
                If esIngles Then
                    MsgBox("There was an error on the database:" + vbNewLine + ej.msg, MsgBoxStyle.Critical)
                Else
                    MsgBox("Se produjo un error en la base de datos:" + vbNewLine + ej.msg, MsgBoxStyle.Critical)
                End If
            End If
        End If
    End Sub

    Private Sub btnAlta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlta.Click
        FrmAltaEjercicio.esIngles = esIngles
        'Para pasar al siguiente formulario comprobamos que se hayan ingresado grupos musculares al sistema
        'ya que la relacion entre ejercicios y grupos musculares es necesaria
        Dim g As New GruposMusculares()
        If Not g.listarIDNombre() Is Nothing Then
            nav.siguiente(FrmAltaEjercicio)
        Else
            Dim strError As String = "Debe ingresar grupos musculares"
            If esIngles Then
                strError = "You must input muscular groups."
            End If
            MsgBox(strError)
        End If
    End Sub

    Private Sub FrmListarEjercicios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.actualizarLista()
        If esIngles Then
            Me.Text = "Exercises"
            btnSeleccionar.Text = "Select"
            btnAtras.Text = "Back"
        End If
    End Sub

    Private Sub btnBaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBaja.Click
        Dim strError As String = "Debe seleccionar un ejercicio."
        If Not lstListaEjercicios.SelectedItem = "" Then
            Dim ej As New Ejercicio()
            Dim strBorrar As String = "Esta seguro? (El ejercicio sera borrado permanentemente)"
            Dim strOK As String = "Ejercicio eliminado correctamente."
            Dim nombre As String = lstListaEjercicios.SelectedItem.ToString
            Dim id As Integer = ej.obtenerID(nombre)

            If esIngles Then
                strBorrar = "Are you sure? (The exercise will be permanently deleted)"
                strOK = "Exercise deleted successfully."
            End If
            If MsgBox(strBorrar, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                ej.bajaEjercicio(id)
                Me.actualizarLista()
                MsgBox(strOK)
            End If

        Else
            If esIngles Then
                strError = "You must select a excercise."
                MsgBox(strError, MsgBoxStyle.Critical)
            Else
                MsgBox(strError, MsgBoxStyle.Critical)
            End If
        End If

    End Sub
End Class