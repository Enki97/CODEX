Public Class FrmSector
    Public esIngles As Boolean = False
    Public sector As Sectores
    Dim nav = New Navegacion(Me)

    Public Sub cargarDatos()
        lblConsultarInstituto.Text = sector.instituto
        lblConsultarNombre.Text = sector.nombre
        lblConsultarNumero.Text = sector.nro_sector

        ltbActividades.Items.Clear()
        If sector.actividades Is Nothing Then
            ltbActividades.Items.Add("Error")
        Else
            For Each a As String In sector.actividades
                If Not a Is Nothing Then
                    ltbActividades.Items.Add(a)
                End If
            Next
        End If
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        nav.anterior()
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        FrmModificarSector.esIngles = esIngles
        FrmModificarSector.sector = sector
        FrmModificarSector.cargarDatos()
        nav.siguiente(FrmModificarSector)
    End Sub

    Private Sub FrmSector_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cargarDatos()
        If esIngles Then
            lblInstituto.Text = "Institute:"
            lblNumero.Text = "Sector's Number:"
            lblNombre.Text = "Name:"
            lblActividades.Text = "Activities:"
            btnModificar.Text = "Modify"
        End If
    End Sub

    Private Sub ltbActividades_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ltbActividades.DoubleClick
        If Not ltbActividades.SelectedItem = "" Then
            Dim auxID As String = ""
            Dim id As Integer
            For Each c As Char In ltbActividades.SelectedItem
                If c = ":" Then
                    Exit For
                Else
                    auxID += c
                End If
            Next
            id = CInt(Trim(auxID))

            Dim actividad As New Actividad(id)

            FrmActividad.actividad = actividad
            FrmActividad.esIngles = esIngles
            FrmActividad.actualizar()
            nav.siguiente(FrmActividad)

        End If
    End Sub
End Class