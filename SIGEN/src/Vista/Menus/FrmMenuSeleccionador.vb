Public Class FrmMenuSeleccionador
    Public usuario As Seleccionador
    Public esIngles As Boolean = False
    Dim nav = New Navegacion(Me)
    Private Sub btnperfil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPerfil.Click
        FrmPerfilSeleccionador.esIngles = esIngles
        FrmPerfilSeleccionador.usuario = usuario
        nav.siguiente(FrmPerfilSeleccionador)
    End Sub

    Private Sub btbnequipos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEquipos.Click
        FrmListarEquipos.esIngles = esIngles
        nav.siguiente(FrmListarEquipos)
    End Sub

    Private Sub btnentrenadores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntrenadores.Click
        FrmListarEntrenadores.esIngles = esIngles
        nav.siguiente(FrmListarEntrenadores)
    End Sub

    Private Sub btnInstituto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInstituto.Click
        FrmListarInstituto.esIngles = esIngles
        nav.siguiente(FrmListarInstituto)
    End Sub

    Private Sub btnSectores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSectores.Click
        FrmListarSectores.esIngles = esIngles
        nav.siguiente(FrmListarSectores)
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        nav.cerrar()
    End Sub

    Private Sub FrmMenuSeleccionador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If esIngles Then
            Me.Text = "Menu"
            btnPerfil.Text = "Profile"
            btnEquipos.Text = "Teams"
            btnEntrenadores.Text = "Coaches"
            btnInstituto.Text = "Institutes"
            btnSectores.Text = "Sectors"
            btnSalir.Text = "Log Out"
        End If
    End Sub
End Class
