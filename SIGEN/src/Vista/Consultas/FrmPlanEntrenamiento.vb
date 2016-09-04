Public Class FrmPlanEntrenamiento
    Public esIngles As Boolean = False
    Public plan As PlanesEntrenamiento
    Dim nav = New Navegacion(Me)
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        nav.anterior()
    End Sub

    Private Sub FrmPlanEntrenamiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim desde, hasta As String
        desde = plan.fecha_desde.Day.ToString + "/" + plan.fecha_desde.Month.ToString + "/" + plan.fecha_desde.Year.ToString
        hasta = plan.fecha_hasta.Day.ToString + "/" + plan.fecha_hasta.Month.ToString + "/" + plan.fecha_hasta.Year.ToString
        lblConsultarNombre.Text = plan.nombre
        lblConsultarFase.Text = plan.fase
        lblConsultarDesde.Text = desde
        lblConsultarHasta.Text = hasta
        rtbDescripcion.Text = plan.descripcion
        For Each com In plan.combos
            If Not com Is Nothing Then
                lstCombos.Items.Add(com)
            End If
        Next
        For Each ej In plan.ejercicios
            If Not ej Is Nothing Then
                lstCombos.Items.Add(ej)
            End If
        Next
        lblMostrarCantidad.Text = "--------"
        lblMostrarCarga.Text = "--------"
        lblMostrarKcal.Text = "--------"
        lblMostrarModo.Text = "--------"
        lblMostrarRepeticiones.Text = "--------"
        lblMostrarSesion.Text = "--------"

        If esIngles Then
            Me.Text = "Training Plan"
            lblNombre.Text = "Name:"
            lblFase.Text = "Phase:"
            lblPeriodo.Text = "Period:"
            lblDesde.Text = "From:"
            lblHasta.Text = "To:"
            lblDescripcion.Text = "Description:"
            lblCombos.Text = "Double click an item to visualize it."
        End If
    End Sub

    Private Sub lstCombos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstCombos.Click
        Dim i As Integer
        If Not lstCombos.SelectedItem = "" Then
            If lstCombos.SelectedIndex < plan.combos.Length - 1 Then
                i = lstCombos.SelectedIndex
                lblMostrarCantidad.Text = plan.comCantidad(i).ToString
                lblMostrarCarga.Text = plan.comCarga(i).ToString
                lblMostrarKcal.Text = plan.comKcal(i).ToString
                lblMostrarModo.Text = plan.comModo(i)
                lblMostrarRepeticiones.Text = plan.comRepeticiones(i).ToString
                lblMostrarSesion.Text = plan.comSesion(i)
            Else
                Dim cantidad As Integer = plan.combos.Length - 1
                i = lstCombos.SelectedIndex - cantidad
                lblMostrarCantidad.Text = plan.ejCantidad(i).ToString
                lblMostrarCarga.Text = plan.ejCarga(i).ToString
                lblMostrarKcal.Text = plan.ejKcal(i).ToString
                lblMostrarModo.Text = plan.ejModo(i)
                lblMostrarRepeticiones.Text = plan.ejRepeticiones(i).ToString
                lblMostrarSesion.Text = plan.ejSesion(i)
            End If
        End If
    End Sub


    Private Sub lstCombos_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstCombos.MouseDoubleClick
        Dim id As Integer
        If Not lstCombos.SelectedItem = "" Then
            If lstCombos.SelectedIndex < plan.combos.Length - 1 Then
                id = plan.comID(lstCombos.SelectedIndex)
                Dim combo As New Combo(id)
                FrmCombo.combo = combo
                FrmCombo.esIngles = esIngles
                FrmCombo.actualizar()
                nav.siguiente(FrmCombo)
            Else
                Dim cantidad As Integer = plan.combos.Length - 1
                id = plan.ejID(lstCombos.SelectedIndex - cantidad)
                Dim ejercicio As New Ejercicio(id)
                FrmEjercicio.ejercicio = ejercicio
                FrmEjercicio.esIngles = esIngles
                FrmEjercicio.actualizar()
                nav.siguiente(FrmEjercicio)
            End If
        End If

    End Sub
End Class