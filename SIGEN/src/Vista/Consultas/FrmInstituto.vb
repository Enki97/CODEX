Public Class FrmInstituto
    Public esIngles As Boolean = False
    Public instituto As Instituto
    Dim nav = New Navegacion(Me)
    Public Sub cargarDatos()
        Dim strNoTel = "No se han ingresado telefonos."
        Dim strNoSocios = "No se han ingresado socios."
        Dim strNoSectores = "No se han ingresado sectores."

        If esIngles Then
            strNoTel = "No phone added yet."
            strNoSectores = "No sectors added yet."
            strNoSocios = "No members added yet."
        End If

        lblConsultarRUT.Text = instituto.rut.ToString
        lblConsultarNombre.Text = instituto.nombre
        lblConsultarEmail.Text = instituto.email
        lblConsultarSitioWeb.Text = instituto.web
        lblConsultarCalle.Text = instituto.dCalle
        lblConsultarNumero.Text = instituto.dNumero.ToString
        If instituto.dBis Then
            ckbBIS.Checked = True
        End If


        ltbTelefono.Items.Clear()
        If Not instituto.telefono Is Nothing Then
            For Each tel As Integer In instituto.telefono
                If Not tel = 0 Then
                    ltbTelefono.Items.Add(tel)
                End If
            Next
        Else
            ltbTelefono.Items.Add(strNoTel)
        End If

        ltbSectores.Items.Clear()
        If Not instituto.sectores Is Nothing Then
            For Each sector As String In instituto.sectores
                If Not sector Is Nothing Then
                    ltbSectores.Items.Add(sector)
                End If
            Next
        Else
            ltbSectores.Items.Add(strNoSectores)
        End If

        ltbSocios.Items.Clear()
        If Not instituto.usuarios Is Nothing Then
            For Each socio As String In instituto.usuarios
                If Not socio Is Nothing Then
                    ltbSocios.Items.Add(socio)
                End If
            Next
        Else
            ltbSocios.Items.Add(strNoSocios)
        End If

    End Sub
    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        FrmModificarInstituto.esIngles = esIngles
        FrmModificarInstituto.instituto = instituto
        FrmModificarInstituto.cargarDatos()
        nav.siguiente(FrmModificarInstituto)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        nav.anterior()
    End Sub

    Private Sub FrmInstituto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cargarDatos()
        If esIngles Then
            Me.Text = "Institute"
            lblNombre.Text = "Name:"
            lblSitioWeb.Text = "Website:"
            gbxDireccion.Text = "Address"
            lblCalle.Text = "Street:"
            lblNumero.Text = "Door's Number"
            lblTelefono.Text = "Phone:"
            lblSectores.Text = "Sectors"
            lblSocios.Text = "Members"
            btnModificar.Text = "Modify"
        End If
    End Sub

    Private Sub ltbSectores_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ltbSectores.DoubleClick
        If Not ltbSectores.SelectedItem = "" Then
            Dim nro_sector As Integer
            Dim auxId As String = ""
            For Each c As Char In ltbSectores.SelectedItem
                If c = ":" Then
                    Exit For
                Else
                    auxId += c
                End If
            Next
            nro_sector = CInt(Trim(auxId))

            Dim sector As New Sectores(instituto.rut, nro_sector)

            'IR A SECTORR
        End If
    End Sub


    Private Sub ltbSocios_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ltbSocios.DoubleClick
        If Not ltbSocios.SelectedItem = "" Then
            Dim documento As Integer
            Dim auxCI As String = ""
            For Each c As Char In ltbSocios.SelectedItem
                If c = ":" Then
                    Exit For
                Else
                    auxCI += c
                End If
            Next
            documento = CInt(Trim(auxCI))

            Dim socio As New Usuario(documento)
            If Trim(socio.rol) = "avanzado" Then
                Dim usuario As New Avanzado(documento)
                FrmPerfilAvanzado.esIngles = esIngles
                FrmPerfilAvanzado.usuario = usuario
                FrmPerfilAvanzado.cargar()
                nav.siguiente(FrmPerfilAvanzado)
            ElseIf Trim(socio.rol) = "deportista" Then
                Dim usuario As New Deportista(documento)
                FrmPerfilDeportista.usuario = usuario
                FrmPerfilDeportista.esIngles = esIngles
                FrmPerfilDeportista.cargarPerfil()
                nav.siguiente(FrmPerfilDeportista)
            ElseIf Trim(socio.rol) = "seleccionador" Then
                Dim usuario As New Seleccionador(documento)
                FrmPerfilSeleccionador.usuario = usuario
                FrmPerfilSeleccionador.esIngles = esIngles
                FrmPerfilSeleccionador.cargarPerfil()
                nav.siguiente(FrmPerfilSeleccionador)
            Else
                Dim usuario As New Entrenador(documento)
                frmPerfilEntrenador.usuario = usuario
                frmPerfilEntrenador.esIngles = esIngles
                frmPerfilEntrenador.cargarPerfil()
                nav.siguiente(frmPerfilEntrenador)
            End If
        End If
    End Sub
End Class