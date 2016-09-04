Public Class FrmCombo
    Public esIngles As Boolean = False
    Public combo As Combo
    Dim nav = New Navegacion(Me)
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        nav.anterior()
    End Sub

    Public Sub actualizar()
        lblConsultarNombre.Text = combo.nombre
        rtbDescripcion.Text = combo.descripcion
        lstEjercicios.Items.Clear()
        For Each ej As String In combo.ejercicios
            If Not ej Is Nothing Then
                lstEjercicios.Items.Add(ej)
            End If
        Next
    End Sub

    Private Sub btnModificarCombo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        frmModificarCombos.esIngles = esIngles
        frmModificarCombos.combo = combo
        nav.siguiente(frmModificarCombos)
    End Sub

    Private Sub FrmCombo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.actualizar()

        If esIngles Then
            Me.Text = "Query Combo"
            lblNombre.Text = "Name:"
            lblDescripcion.Text = "Description:"
            lblEjercicios.Text = "Exercises"
            btnModificar.Text = "Modify"
        End If
    End Sub

    Private Sub lstEjercicios_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstEjercicios.DoubleClick
        If Not lstEjercicios.SelectedItem = "" Then
            Dim nombre As String = lstEjercicios.SelectedItem.ToString
            Dim ejercicio As New Ejercicio()
            ejercicio = New Ejercicio(ejercicio.obtenerID(nombre))
            FrmEjercicio.esIngles = esIngles
            FrmEjercicio.ejercicio = ejercicio
            FrmEjercicio.actualizar()
            nav.siguiente(FrmEjercicio)
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        nav.anterior()
    End Sub
End Class