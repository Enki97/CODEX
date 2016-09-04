Public Class FrmTablaCompatibilidad
    Dim nav = New Navegacion(Me)
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        nav.anterior()
    End Sub
End Class