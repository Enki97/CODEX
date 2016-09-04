Public Class FrmIdioma
    Dim nav = New Navegacion(Me)
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEspañol.Click
        nav.siguiente(FrmLogin)
    End Sub

    Private Sub btnEnglish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngles.Click
        FrmLogin.esIngles = True
        nav.siguiente(FrmLogin)
    End Sub

    Private Sub btnSalirBienvenido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalirBienvenido.Click
        nav.cerrar()
    End Sub

    Private Sub btnAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbout.Click
        Dim localizadorUniformeDeRecursos As String = "http://codexsrl.herokuapp.com/"
        Shell("Explorer " + localizadorUniformeDeRecursos)
    End Sub
End Class