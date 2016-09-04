Public Class FrmListarEquipos
    Public esIngles As Boolean = False
    Dim nav = New Navegacion(Me)

    Public Sub actualizarLista()
        Dim strNoEquipo = "Aún no se han registrado equipos."
        If esIngles Then
            strNoEquipo = "No teams added yet."
        End If
        lstListaEquipos.Items.Clear()
        Dim lista As New Equipos()
        Dim equipos() As String = lista.listarIDNombre()
        If Not equipos Is Nothing Then
            For Each eq In equipos
                If Not eq Is Nothing Then
                    lstListaEquipos.Items.Add(eq)
                End If
            Next
        Else
            lstListaEquipos.Items.Clear()
            lstListaEquipos.Items.Add(strNoEquipo)
        End If
    End Sub
    Private Sub btnAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtras.Click
        nav.anterior()
    End Sub

    Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click
        If lstListaEquipos.SelectedItem = "" Then
            Dim strError As String = "Debe seleccionar un equipo"
            If esIngles Then
                strError = "You must select a team"
            End If
            MsgBox(strError, MsgBoxStyle.Critical)
        Else
            Dim nombre As String = lstListaEquipos.SelectedItem.ToString
            Dim strID As String = ""
            Dim id As Integer

            For Each c As Char In nombre
                If c = ":" Then
                    Exit For
                Else
                    strID += c
                End If
            Next

            id = CInt(Trim(strID))

            Dim equipo As New Equipos(id)

            FrmEquipo.esIngles = esIngles
            FrmEquipo.equipo = equipo
            FrmEquipo.actualizar()
            nav.siguiente(FrmEquipo)
        End If

    End Sub

    Private Sub btnAlta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlta.Click
        FrmAltaEquipo.esIngles = esIngles
        nav.siguiente(FrmAltaEquipo)
    End Sub

    Private Sub FrmListarEquipos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.actualizarLista()
        If esIngles Then
            Me.Text = "Teams"
            btnAtras.Text = "Back"
            btnSeleccionar.Text = "Select"
        End If
    End Sub

    Private Sub btnBaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBaja.Click
        Dim strError As String = "Debe seleccionar un equipo."
        If Not lstListaEquipos.SelectedItem = "" Then
            Dim strBorrar As String = "Esta seguro? (El ejercicio sera borrado permanentemente)"
            Dim strOK As String = "Ejercicio eliminado correctamente."
            If esIngles Then
                strBorrar = "Are you sure? (The exercise will be permanently deleted)"
                strOK = "Exercise deleted successfully."
            End If
            If MsgBox(strBorrar, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim strId As String = ""
                Dim id As Integer
                For Each c As Char In lstListaEquipos.SelectedItem.ToString
                    If c = ":" Then
                        Exit For
                    Else
                        strId += c
                    End If
                Next
                id = CInt(Trim(strId))
                Dim eq As New Equipos(id)
                eq.bajaEquipo(id)
                Me.actualizarLista()
                MsgBox(strOK)
            End If

        Else
            If esIngles Then
                strError = "You must select a team."
                MsgBox(strError, MsgBoxStyle.Critical)
            Else
                MsgBox(strError, MsgBoxStyle.Critical)
            End If
        End If
    End Sub
End Class