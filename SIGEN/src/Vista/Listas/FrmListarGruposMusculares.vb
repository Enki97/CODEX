Public Class FrmListarGruposMusculares
    Public esIngles As Boolean = False
    Dim nav = New Navegacion(Me)

    Public Sub actualizarLista()
        Dim strNoGrupo = "Aún no se han registrado grupos musculares."
        If esIngles Then
            strNoGrupo = "No muscular group added yet."
        End If
        lstListaMusculos.Items.Clear()
        Dim lista As New GruposMusculares()
        Dim grupos() As String = lista.listarGrupos()
        If Not grupos Is Nothing Then
            For Each g In grupos
                lstListaMusculos.Items.Add(g)
            Next
        Else
            lstListaMusculos.Items.Clear()
            lstListaMusculos.Items.Add(strNoGrupo)
        End If
    End Sub
    Private Sub btnAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtras.Click
        nav.anterior()
    End Sub

    Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click
        If lstListaMusculos.SelectedItem = "" Then
            Dim strError As String = "Debe seleccionar un grupo muscular"
            If esIngles Then
                strError = "You must select a muscular group"
            End If
            MsgBox(strError, MsgBoxStyle.Critical)
        Else
            Dim nombre As String = lstListaMusculos.SelectedItem.ToString
            Dim g As New GruposMusculares
            Dim id As Integer = g.obtenerID(nombre)
            If id >= 0 Then
                Dim grupo = New GruposMusculares(id)
                FrmGruposMusculares.esIngles = esIngles
                FrmGruposMusculares.grupo = grupo
                FrmGruposMusculares.actualizar()
                nav.siguiente(FrmGruposMusculares)
            Else
                If esIngles Then
                    MsgBox("There was an error on the database:" + vbNewLine + g.msg, MsgBoxStyle.Critical)
                Else
                    MsgBox("Se produjo un error en la base de datos:" + vbNewLine + g.msg, MsgBoxStyle.Critical)
                End If
            End If
        End If
    End Sub

    Private Sub btnAlta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlta.Click
        FrmAltaGruposMusculares.esIngles = esIngles
        nav.siguiente(FrmAltaGruposMusculares)
    End Sub

    Private Sub FrmListarGruposMusculares_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.actualizarLista()
        If esIngles Then
            Me.Text = "Muscular Groups"
            btnAtras.Text = "Back"
            btnSeleccionar.Text = "Select"
        End If
    End Sub

    Private Sub btnBaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBaja.Click
        Dim strError As String = "Debe seleccionar un grupo muscular."
        If Not lstListaMusculos.SelectedItem = "" Then
            Dim g As New GruposMusculares()
            Dim strBorrar As String = "Esta seguro? (El grupo muscular sera borrado permanentemente)"
            Dim strOK As String = "Grupo Muscular eliminado correctamente."
            Dim nombre As String = lstListaMusculos.SelectedItem.ToString
            Dim id As String = g.obtenerID(nombre)

            If esIngles Then
                strBorrar = "Are you sure? (The muscular group will be permanently deleted)"
                strOK = "Muscular group deleted successfully."
            End If
            If MsgBox(strBorrar, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                g.bajaGrupo(id)
                Me.actualizarLista()
                MsgBox(strOK)
            End If

        Else
            If esIngles Then
                strError = "You must select a muscular group."
                MsgBox(strError, MsgBoxStyle.Critical)
            Else
                MsgBox(strError, MsgBoxStyle.Critical)
            End If
        End If
    End Sub
End Class