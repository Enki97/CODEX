Public Class FrmListaDeportistas
    Public esIngles As Boolean = False
    Dim nav = New Navegacion(Me)
    Public Sub actualizarLista()
        Dim strNoDeportista = "Aún no se han registrado deportistas."
        If esIngles Then
            strNoDeportista = "No sportmen added yet."
        End If
        lstListaDeportistas.Items.Clear()
        Dim lista As New Usuario()
        Dim deportistas As Dictionary(Of Integer, String) = lista.listar("deportista")
        If deportistas.Count > 0 Then
            For Each d In deportistas
                lstListaDeportistas.Items.Add(d.Key.ToString & " : " & d.Value.ToString)
            Next
        Else
            lstListaDeportistas.Items.Clear()
            lstListaDeportistas.Items.Add(strNoDeportista)
        End If
    End Sub
    Private Sub btnAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtras.Click
        nav.anterior()
    End Sub

    Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click
        If lstListaDeportistas.SelectedItem = "" Then
            Dim strError As String = "Debe seleccionar un deportista"
            If esIngles Then
                strError = "You must select a sportman"
            End If
            MsgBox(strError, MsgBoxStyle.Critical)
        Else
            Dim documento As String = lstListaDeportistas.SelectedItem.ToString
            documento = documento.Substring(0, 8)
            Dim deportista = New Deportista(CInt(documento))
            FrmPerfilDeportista.esIngles = esIngles
            FrmPerfilDeportista.usuario = deportista
            FrmPerfilDeportista.cargarPerfil()
            nav.siguiente(FrmPerfilDeportista)
        End If
    End Sub

    Private Sub btnAlta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmAltaDeportista.esIngles = esIngles
        nav.siguiente(FrmAltaDeportista)
    End Sub

    Private Sub FrmListaDeportistas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Sistema Bilingüe
        If esIngles Then
            Me.Text = "Sportmen"
            btnSeleccionar.Text = "Select"
            btnAtras.Text = "Back"
        End If
        actualizarLista()
    End Sub

    Private Sub btnBaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim strError As String = "Debe seleccionar un deportista"
        If Not lstListaDeportistas.SelectedItem = "" Then
            Dim usuario As New Usuario()
            Dim strBorrar As String = "Esta seguro? (Para habilitar nuevamente al deportista contacte con un administrador)"
            Dim strOK As String = "Usuario eliminado correctamente."
            Dim documento As String = lstListaDeportistas.SelectedItem.ToString
            documento = documento.Substring(0, 8)

            If esIngles Then
                strBorrar = "Are you sure? (In order to enable the sportman again contact an administrator)"
                strOK = "User deleted successfully."
            End If
            If MsgBox(strBorrar, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                usuario.bajaUsuario(CInt(documento))
                Me.actualizarLista()
                MsgBox(strOK)
            End If

        Else
            If esIngles Then
                strError = "You must select a sportman."
                MsgBox(strError, MsgBoxStyle.Critical)
            Else
                MsgBox(strError, MsgBoxStyle.Critical)
            End If
        End If

    End Sub

    Private Sub btnAlta_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlta.Click
        FrmAltaEntrenador.esIngles = esIngles
        nav.siguiente(FrmAltaDeportista)
    End Sub

    Private Sub btnBaja_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBaja.Click
        Dim strError As String = "Debe seleccionar un deportista"
        If Not lstListaDeportistas.SelectedItem = "" Then
            Dim usuario As New Usuario()
            Dim strBorrar As String = "Esta seguro? (Para habilitar nuevamente al deportista contacte con un administrador)"
            Dim strOK As String = "Usuario eliminado correctamente."
            Dim documento As String = lstListaDeportistas.SelectedItem.ToString
            documento = documento.Substring(0, 8)

            If esIngles Then
                strError = "You must select a sportman."
                strBorrar = "Are you sure? (In order to enable the sportman again contact an administrator)"
                strOK = "User deleted successfully."
            End If
            If MsgBox(strBorrar, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                usuario.bajaUsuario(CInt(documento))
                Me.actualizarLista()
                MsgBox(strOK)
            End If

        Else
            If esIngles Then
                strError = "You must select a coach."
                MsgBox(strError, MsgBoxStyle.Critical)
            Else
                MsgBox(strError, MsgBoxStyle.Critical)
            End If
        End If
    End Sub
End Class