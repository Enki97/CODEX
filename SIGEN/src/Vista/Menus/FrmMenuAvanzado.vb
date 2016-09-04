Public Class FrmMenuAvanzado
    Public esIngles As Boolean = False
    Public usuario As Avanzado
    Dim nav = New Navegacion(Me)

    Private Sub btnPerfil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPerfil.Click
        FrmPerfilAvanzado.usuario = usuario
        FrmPerfilAvanzado.esIngles = esIngles
        nav.siguiente(FrmPerfilAvanzado)
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        nav.cerrar()
    End Sub

    Private Sub btnDeportista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeportista.Click
        FrmListaDeportistas.esIngles = esIngles
        nav.siguiente(FrmListaDeportistas)
    End Sub

    Private Sub btnEjercicios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEjercicios.Click
        FrmListarEjercicios.esIngles = esIngles
        nav.siguiente(FrmListarEjercicios)
    End Sub

    Private Sub btnGruposMusculos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGruposMusculos.Click
        FrmListarGruposMusculares.esIngles = esIngles
        nav.siguiente(FrmListarGruposMusculares)
    End Sub


    Private Sub btnAvanzado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAvanzado.Click
        FrmAltaAvanzado.esIngles = esIngles
        nav.siguiente(FrmAltaAvanzado)
    End Sub

    Private Sub btnSeleccionador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionador.Click
        FrmAltaSeleccionador.esIngles = esIngles
        nav.siguiente(FrmAltaSeleccionador)
    End Sub

    Private Sub FrmMenuAvanzado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If esIngles Then
            btnPerfil.Text = "Profile"
            btnDeportista.Text = "Sportmen"
            btnEjercicios.Text = "Exercises"
            btnGruposMusculos.Text = "Muscular Gropus"
            btnAvanzado.Text = "New Avanced User"
            btnActividades.Text = "Activities"
            btnSeleccionador.Text = "New Selecter"
            btnSalir.Text = "Log Out"
        End If
    End Sub

    Private Sub btnActividades_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActividades.Click
        FrmListarActividad.esIngles = esIngles
        nav.siguiente(FrmListarActividad)
    End Sub
End Class
