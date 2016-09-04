Public Class FrmEjercicio
    Public esIngles As Boolean = False
    Public ejercicio As Ejercicio
    Dim nav = New Navegacion(Me)

    Public Sub actualizar()
        lblMostrarNombre.Text = ejercicio.nombre
        rtbDescripcion.Text = ejercicio.descripcion
        imgEjercicio.LoadAsync(Trim(ejercicio.foto))
        imgEjercicio.SizeMode = PictureBoxSizeMode.StretchImage
        wbVideo.DocumentText() = "<iframe width='710' height='250' src='http://www.youtube.com/embed/" & Trim(ejercicio.video) & "' frameborder='0' allowfullscreen></iframe>"
        lstGruposMusculares.Items.Clear
        For Each g As String In ejercicio.grupos
            If Not g Is Nothing Then
                lstGruposMusculares.Items.Add(g)
            End If
        Next
    End Sub
    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        FrmModificarEjercicio.esIngles = esIngles
        FrmModificarEjercicio.ejercicio = ejercicio
        FrmModificarEjercicio.cargarDatos()
        nav.siguiente(FrmModificarEjercicio)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        nav.anterior()
    End Sub

    Private Sub FrmEjercicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.actualizar()

        If esIngles Then
            Me.Text = "Exercise"
            lblNombre.Text = "Name:"
            lblDescripcion.Text = "Description:"
            lblGruposMusculares.Text = "Train the following Muscular Groups:"
            btnModificar.Text = "Modify"
        End If
    End Sub

    Private Sub lstGruposMusculares_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstGruposMusculares.MouseDoubleClick
        Dim nombre As String = lstGruposMusculares.SelectedItem.ToString
        Dim grupo As New GruposMusculares()
        grupo = New GruposMusculares(grupo.obtenerID(nombre))
        FrmGruposMusculares.esIngles = esIngles
        FrmGruposMusculares.grupo = grupo
        FrmGruposMusculares.actualizar()
        nav.siguiente(FrmGruposMusculares)
    End Sub
End Class