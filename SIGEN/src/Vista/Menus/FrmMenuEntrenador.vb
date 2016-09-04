Public Class FrmMenuEntrenador
    Public usuario As Entrenador
    Public esIngles As Boolean = False
    Dim nav = New Navegacion(Me)

    Private Sub btnPerfilEntrenador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPerfilEntrenador.Click
        frmPerfilEntrenador.esIngles = esIngles
        frmPerfilEntrenador.usuario = usuario
        nav.siguiente(frmPerfilEntrenador)
    End Sub

    Private Sub btnListaDeportistas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListaDeportistas.Click
        FrmListaDeportistas.esIngles = esIngles
        nav.siguiente(FrmListaDeportistas)
    End Sub

    Private Sub btnPlanesEntrenamiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlanesEntrenamiento.Click
        FrmAltaPlanEntrenamiento.esIngles = esIngles
        FrmAltaPlanEntrenamiento.actualizarDeportistas()
        nav.siguiente(FrmAltaPlanEntrenamiento)
    End Sub

    Private Sub btnListarCombos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListarCombos.Click
        FrmListarCombos.esIngles = esIngles
        nav.siguiente(FrmListarCombos)
    End Sub

    Private Sub btnTablaCompatibilidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTablaCompatibilidad.Click
        nav.siguiente(FrmTablaCompatibilidad)
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        nav.cerrar()
    End Sub

    Private Sub FrmMenuEntrenador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If esIngles Then
            Me.Text = "Menu"
            btnPerfilEntrenador.Text = "Profile"
            btnListaDeportistas.Text = "Sportmen"
            btnPlanesEntrenamiento.Text = "Training Plans"
            btnTablaCompatibilidad.Text = "Compatibility Table"
            btnCalificar.Text = "Qualify"
            btnSalir.Text = "Log Out"
        End If
    End Sub

    Private Sub btnCalificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalificar.Click
        FrmAltaEvolucion.esIngles = esIngles
        FrmAltaEvolucion.actualizarLista()
        nav.siguiente(FrmAltaEvolucion)
    End Sub
End Class
