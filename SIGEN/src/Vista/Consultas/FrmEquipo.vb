Public Class FrmEquipo
    Public equipo As Equipos
    Public esIngles As Boolean = False
    Dim nav = New Navegacion(Me)

    Public Sub actualizar()
        lstDeportistas.Items.Clear()
        lblConsultarNombre.Text = equipo.categoria
        lblConsultarActividad.Text = equipo.actividad.nombre
        If equipo.esSeleccion Then
            If esIngles Then
                lblConsultarEsSeleccion.Text = "Yes"
            Else
                lblConsultarEsSeleccion.Text = "Si"
            End If
        Else
            lblConsultarEsSeleccion.Text = "No"
        End If
        If Not equipo.deportistas Is Nothing Then
            For Each d As String In equipo.deportistas
                If Not d Is Nothing Then
                    lstDeportistas.Items.Add(d)
                End If
            Next
        End If

    End Sub
    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        FrmModificarEquipo.equipo = equipo
        FrmModificarEquipo.esIngles = esIngles
        FrmModificarEquipo.cargarDatos()
        nav.siguiente(FrmModificarEquipo)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        nav.anterior()
    End Sub

    Private Sub FrmEquipo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.actualizar()
        If esIngles Then
            Me.Text = "Team"
            lblNombre.Text = "Name:"
            lblActividad.Text = "Activity/Sport:"
            lblEsSeleccion.Text = "It's a Selection:"
            lblDeportistas.Text = "Sportmen in the team:"
            btnModificar.Text = "Modify"
        End If
    End Sub

    Private Sub lstDeportistas_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstDeportistas.MouseDoubleClick
        If Not lstDeportistas.SelectedItem = "" Then
            Dim strCi As String = ""
            Dim ci As Integer
            For Each c As Char In lstDeportistas.SelectedItem.ToString
                If c = ":" Then
                    Exit For
                Else
                    strCi += c
                End If
            Next
            ci = CInt(Trim(strCi))
            Dim deportista As New Deportista(ci)
            FrmPerfilDeportista.esIngles = esIngles
            FrmPerfilDeportista.usuario = deportista

            nav.siguiente(FrmPerfilDeportista)
        End If
    End Sub
End Class