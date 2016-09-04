Public Class FrmMenuDeportista
    Public usuario As Deportista
    Public esIngles As Boolean = False
    Dim nav = New Navegacion(Me)
    Private Sub btnPerfil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPerfil.Click
        FrmPerfilDeportista.esIngles = esIngles
        FrmPerfilDeportista.usuario = usuario
        nav.siguiente(FrmPerfilDeportista)
    End Sub

    Private Sub btnPlanEntrenamiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmPlanEntrenamiento.esIngles = esIngles
        nav.siguiente(FrmPlanEntrenamiento)
    End Sub

    Private Sub btnTablaCompatibilidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTablaCompatibilidad.Click
        nav.siguiente(FrmTablaCompatibilidad)
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        nav.cerrar()
    End Sub

    Private Sub FrmMenuDeportista_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If esIngles Then
            Me.Text = "Menu"
            btnPerfil.Text = "Profile"
            btnTablaCompatibilidad.Text = "Compatibility Table"
            btnSalir.Text = "Log Out"
        End If
    End Sub
End Class