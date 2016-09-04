Public Class FrmListarActividad
    Public esIngles As Boolean = False
    Dim nav = New Navegacion(Me)

    Public Sub actualizar()
        Dim strNoActividad = "Aún no se han registrado actividades/deportes."
        If esIngles Then
            strNoActividad = "No activity/sport added yet."
        End If
        lstListaActividades.Items.Clear()
        Dim lista As New Actividad()
        Dim actividades() As String = lista.listar()
        If Not actividades Is Nothing Then
            For Each a In actividades
                lstListaActividades.Items.Add(a)
            Next
        Else
            lstListaActividades.Items.Clear()
            lstListaActividades.Items.Add(strNoActividad)
        End If
    End Sub
    Private Sub btnAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtras.Click
        nav.anterior()
    End Sub

    Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click
        If lstListaActividades.SelectedItem = "" Then
            Dim strError As String = "Debe seleccionar una actividad/deporte."
            If esIngles Then
                strError = "You must select an activity/sport."
            End If
            MsgBox(strError, MsgBoxStyle.Critical)
        Else
            Dim nombre As String = lstListaActividades.SelectedItem.ToString
            Dim a As New Actividad
            Dim id As Integer = a.obtenerID(nombre)
            If id >= 0 Then
                Dim actividad = New Actividad(id)
                FrmEjercicio.esIngles = esIngles
                FrmActividad.actividad = actividad
                FrmActividad.actualizar()
                nav.siguiente(FrmActividad)
            Else
                If esIngles Then
                    MsgBox("There was an error on the database:" + vbNewLine + a.msg, MsgBoxStyle.Critical)
                Else
                    MsgBox("Se produjo un error en la base de datos:" + vbNewLine + a.msg, MsgBoxStyle.Critical)
                End If
            End If
        End If
    End Sub

    Private Sub btnAlta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlta.Click
        FrmAltaActividad.esIngles = esIngles
        nav.siguiente(FrmAltaActividad)
    End Sub

    Private Sub FrmListarActividad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.actualizar()
        If esIngles Then
            Me.Text = "Activities"
            btnAtras.Text = "Back"
            btnSeleccionar.Text = "Select"
        End If

    End Sub

    Private Sub btnBaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBaja.Click
        Dim strError As String = "Debe seleccionar un ejercicio."
        If Not lstListaActividades.SelectedItem = "" Then
            Dim a As New Actividad()
            Dim strBorrar As String = "Esta seguro? (La actividad/deporte sera borrado permanentemente)"
            Dim strOK As String = "Actividad/deporte eliminado correctamente."
            Dim nombre As String = lstListaActividades.SelectedItem.ToString
            Dim id As Integer = a.obtenerID(nombre)

            If esIngles Then
                strBorrar = "Are you sure? (The activity/sport will be permanently deleted)"
                strOK = "Activity/Sport deleted successfully."
            End If
            If MsgBox(strBorrar, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                a.bajaActividad(id)
                Me.actualizar()
                MsgBox(strOK)
            End If

        Else
            If esIngles Then
                strError = "You must select an activity/sport."
                MsgBox(strError, MsgBoxStyle.Critical)
            Else
                MsgBox(strError, MsgBoxStyle.Critical)
            End If
        End If

    End Sub
End Class