Public Class FrmGruposMusculares
    Public esIngles As Boolean = False
    Public grupo As GruposMusculares
    Dim nav = New Navegacion(Me)

    Public Sub actualizar()
        lblMostrarNombre.Text = grupo.nombre
        lblMostrarTipo.Text = grupo.tipo
        rtbDescripcion.Text = grupo.descripcion
        imgMusculo.LoadAsync(grupo.foto)
        imgMusculo.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        FrmModificarGruposMusculares.esIngles = esIngles
        FrmModificarGruposMusculares.grupos = grupo
        FrmModificarGruposMusculares.cargarDatos()
        nav.siguiente(FrmModificarGruposMusculares)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        nav.anterior()
    End Sub

    Private Sub FrmGruposMusculares_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.actualizar()

        If esIngles Then
            Me.Text = "Muscular Group"
            lblNombre.Text = "Name:"
            lblTipo.Text = "Type:"
            lblDescripcion.Text = "Description:"
            btnModificar.Text = "Modify"
        End If
    End Sub
End Class