Public Class FrmListarInstituto
    Public esIngles As Boolean = False
    Dim nav = New Navegacion(Me)
    Public Sub actualizarLista()
        Dim strNoInstituto = "Aún no se han registrado institutos."
        If esIngles Then
            strNoInstituto = "No institutes added yet."
        End If
        lstListaInstituto.Items.Clear()
        Dim lista As New Instituto()
        Dim institutos() As String = lista.listarIDNombre()
        If Not institutos Is Nothing Then
            For Each ins In institutos
                lstListaInstituto.Items.Add(ins)
            Next
        Else
            lstListaInstituto.Items.Clear()
            lstListaInstituto.Items.Add(strNoInstituto)
        End If
    End Sub
    Private Sub btnAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtras.Click
        nav.anterior()
    End Sub

    Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click
        If lstListaInstituto.SelectedItem = "" Then
            Dim strError As String = "Debe seleccionar un instituto."
            If esIngles Then
                strError = "You must select an institute."
            End If
            MsgBox(strError, MsgBoxStyle.Critical)
        Else
            Dim nombre As String = lstListaInstituto.SelectedItem.ToString
            Dim instituto As New Instituto()
            Dim auxID As String = ""
            Dim rut As Long

            For Each c As Char In lstListaInstituto.SelectedItem
                If c = ":" Then
                    Exit For
                Else
                    auxID += c
                End If
            Next

            rut = CLng(Trim(auxID))

            instituto = New Instituto(rut)
            FrmInstituto.instituto = instituto
            FrmInstituto.esIngles = esIngles
            FrmInstituto.cargarDatos()
            nav.siguiente(FrmInstituto)
        End If
    End Sub

    Private Sub btnAlta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlta.Click
        FrmAltaInstituto.esIngles = esIngles
        nav.siguiente(FrmAltaInstituto)
    End Sub

    Private Sub FrmListarInstituto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.actualizarLista()
        If esIngles Then
            Me.Text = "Institutes"
            btnAtras.Text = "Back"
            btnSeleccionar.Text = "Select"
        End If
    End Sub

    Private Sub btnBaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBaja.Click
        Dim strError As String = "Debe seleccionar un instituto."
        If Not lstListaInstituto.SelectedItem = "" Then
            Dim strBorrar As String = "Esta seguro? (El instituto sera borrado permanentemente)"
            Dim strOK As String = "Instituto eliminado correctamente."
            Dim nombre As String = lstListaInstituto.SelectedItem.ToString
            Dim instituto As New Instituto()
            Dim auxID As String = ""
            Dim rut As Long

            For Each c As Char In lstListaInstituto.SelectedItem
                If c = ":" Then
                    Exit For
                Else
                    auxID += c
                End If
            Next

            rut = CLng(Trim(auxID))

            If esIngles Then
                strBorrar = "Are you sure? (The institute will be permanently deleted)"
                strOK = "Institute deleted successfully."
            End If
            If MsgBox(strBorrar, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                instituto.bajaInstituto(rut)
                Me.actualizarLista()
                MsgBox(strOK)
            End If

        Else
            If esIngles Then
                strError = "You must select a Institute."
                MsgBox(strError, MsgBoxStyle.Critical)
            Else
                MsgBox(strError, MsgBoxStyle.Critical)
            End If
        End If
    End Sub
End Class