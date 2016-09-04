Public Class FrmListarEntrenadores
    Public esIngles As Boolean = False
    Dim nav = New Navegacion(Me)
    Public Sub actualizarLista()
        Dim strNoEntrenador = "Aún no se han registrado entrenadores."
        If esIngles Then
            strNoEntrenador = "No coaches added yet."
        End If
        lstListaEntrenadores.Items.Clear()
        Dim lista As New Usuario()
        Dim entrenadores As Dictionary(Of Integer, String) = lista.listar("entrenador")
        If entrenadores.Count > 0 Then
            For Each en In entrenadores
                lstListaEntrenadores.Items.Add(en.Key.ToString & " : " & en.Value.ToString)
            Next
        Else
            lstListaEntrenadores.Items.Clear()
            lstListaEntrenadores.Items.Add(strNoEntrenador)
        End If
    End Sub
    Private Sub btnAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtras.Click
        nav.anterior()
    End Sub

    Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click
        If lstListaEntrenadores.SelectedItem = "" Then
            Dim strError As String = "Debe seleccionar un entrenador"
            If esIngles Then
                strError = "You must select a coach"
            End If
            MsgBox(strError, MsgBoxStyle.Critical)
        Else
            Dim documento As String = lstListaEntrenadores.SelectedItem.ToString
            documento = documento.Substring(0, 8)
            Dim entrenador = New Entrenador(CInt(documento))
            frmPerfilEntrenador.esIngles = esIngles
            frmPerfilEntrenador.usuario = entrenador
            frmPerfilEntrenador.cargarPerfil()
            nav.siguiente(frmPerfilEntrenador)
        End If
    End Sub

    Private Sub btnAlta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlta.Click
        FrmAltaEntrenador.esIngles = esIngles
        nav.siguiente(FrmAltaEntrenador)
    End Sub

    Private Sub FrmListarEntrenadores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If esIngles Then
            Me.Text = "Coaches"
            btnAtras.Text = "Back"
            btnSeleccionar.Text = "Select"
        End If
        actualizarLista()
    End Sub

    Private Sub btnBaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBaja.Click
        Dim strError As String = "Debe seleccionar un entrenador"
        If Not lstListaEntrenadores.SelectedItem = "" Then
            Dim usuario As New Usuario()
            Dim strBorrar As String = "Esta seguro? (Para habilitar nuevamente al entrenador contacte con un administrador)"
            Dim strOK As String = "Usuario eliminado correctamente."
            Dim documento As String = lstListaEntrenadores.SelectedItem.ToString
            documento = documento.Substring(0, 8)

            If esIngles Then
                strError = "You must select a coach."
                strBorrar = "Are you sure? (In order to enable the coach again contact an administrator)"
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