Public Class FrmLogin
    Public esIngles As Boolean = False
    Dim nav = New Navegacion(Me)

    'Para determinar que usuario esta en uso desde otras clases
    Dim usuarioLogeado As Usuario

    'Definimos los strings
    Dim strAutenticacion As String = "Las credenciales ingresadas son incorrectas o el usuario está inactivo"
    Dim strCedula As String = "El documento ingresado es inválido"

    Private Sub btnSalirEsp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        nav.cerrar()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar.Click
        Dim vCI As New Validacion(txtDocumento.Text)
        If vCI.cedula() Then
            Dim u = New Usuario(CInt(txtDocumento.Text))
            If u.msg = "NE" Then
                Dim strNE As String = "El usuario ingresado no existe"
                If esIngles Then
                    strNE = "The user doesn't exist"
                End If
                txtContrasenia.Text = ""
                txtDocumento.Text = ""
                MsgBox(strNE, MsgBoxStyle.Critical)
            Else
                If u.autenticar(txtDocumento.Text, txtContrasenia.Text) Then
                    Select Case u.rol
                        Case "avanzado                                "
                            Dim usuario = New Avanzado(u.documento)
                            FrmMenuAvanzado.usuario = usuario
                            usuarioLogeado = u
                            FrmMenuAvanzado.esIngles = esIngles
                            nav.siguiente(FrmMenuAvanzado)
                        Case "deportista                              "
                            Dim usuario As New Deportista(u.documento)
                            FrmMenuDeportista.usuario = usuario
                            usuarioLogeado = u
                            FrmMenuDeportista.esIngles = esIngles
                            nav.siguiente(FrmMenuDeportista)
                        Case "entrenador                              "
                            Dim usuario As New Entrenador(u.documento)
                            FrmMenuEntrenador.usuario = usuario
                            usuarioLogeado = u
                            FrmMenuEntrenador.esIngles = esIngles
                            nav.siguiente(FrmMenuEntrenador)
                        Case "seleccionador                           "
                            Dim usuario As New Seleccionador(u.documento)
                            FrmMenuSeleccionador.usuario = usuario
                            usuarioLogeado = u
                            FrmMenuSeleccionador.esIngles = esIngles
                            nav.siguiente(FrmMenuSeleccionador)
                    End Select
                Else
                    MsgBox(strAutenticacion, MsgBoxStyle.Critical)
                    txtContrasenia.Text = ""
                End If
            End If
        Else
            MsgBox(strCedula, MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub FrmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If esIngles Then
            Me.Text = "Sign In"
            strAutenticacion = "The passwords doesn't match or the user is unactive"
            strCedula = "The document ins't valid."
            btnIngresar.Text = "&Sign In"
            btnSalir.Text = "&Exit"
            lblContrasenia.Text = "Password:"
            lblDocumento.Text = "Document:"
        End If

        'Si es la primera vez que se usa el programa configura un usuario avanzado
        Try
            Dim consultar = New BD("SELECT * FROM avanzado")
            consultar.consulta.Read()
            If Not consultar.consulta.HasRows Then
                FrmAltaAvanzado.esIngles = esIngles
                nav.siguiente(FrmAltaAvanzado)
            End If
            consultar.close()
        Catch ex As Exception

        End Try
    End Sub

    Function obtenerSesion()
        Return usuarioLogeado
    End Function

End Class