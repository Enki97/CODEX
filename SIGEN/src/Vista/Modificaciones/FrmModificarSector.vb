Public Class FrmModificarSector
    Public esIngles As Boolean = False
    Public sector As Sectores
    Dim nav = New Navegacion(Me)
    Public Sub cargarActividades()
        cklActividades.Items.Clear()
        Dim actividades As New Actividad()
        Dim lista() As String = actividades.listar()
        If Not lista Is Nothing Then
            For Each act As String In lista
                If Not act Is Nothing Then
                    cklActividades.Items.Add(act)
                End If
            Next
        End If
    End Sub
    Public Sub cargarDatos()
        txtNombre.Text = Trim(sector.nombre)
        Me.cargarActividades()
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        nav.anterior()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim actividades() As Integer
        Dim nombre As String
        Dim faltan As Boolean = False
        Dim invalido As Boolean = False
        Dim existe As Boolean = False
        Dim strFaltan, strInvalido, strCorrecto As String

        If esIngles Then
            strFaltan = "The following fields are required: "
            strCorrecto = "Successfully registered."
        Else
            strFaltan = "Faltan campos obligatorios: "
            strCorrecto = "Procedimiento Correcto."
        End If

        If txtNombre.Text = "" Then
            faltan = True
            If esIngles Then
                strFaltan += "/Name"
            Else
                strFaltan += "/Nombre"
            End If
        Else
            nombre = txtNombre.Text
        End If

        If cklActividades.CheckedItems.Count = 0 Then
            faltan = True
            If esIngles Then
                strFaltan += "/Activities"
            Else
                strFaltan += "/Actividades"
            End If
        Else
            Dim auxID As String = ""
            Dim i As Integer = 0
            ReDim actividades(cklActividades.CheckedItems.Count - 1)
            For Each a As String In cklActividades.CheckedItems
                For Each c As Char In a
                    If Char.IsDigit(c) Then
                        auxID += c
                    Else
                        Exit For
                    End If
                Next
                actividades(i) = CInt(auxID)
                i += 1
            Next
        End If

        If faltan Then
            MsgBox(strFaltan + "/", MsgBoxStyle.Critical)
        ElseIf invalido Then
            MsgBox(strInvalido + "/", MsgBoxStyle.Critical)
        Else
            'Ingresamos el sector
            sector.modificarSectores(sector.rut, sector.nro_sector, nombre)

            'Ingresamos las actividades con su id
            sector.modificarActividades(sector.rut, sector.nro_sector, actividades)

            FrmSector.sector = New Sectores(sector.rut, sector.nro_sector)
            FrmSector.cargarDatos()
            MsgBox(strCorrecto)
            nav.anterior()
        End If
    End Sub

    Private Sub FrmModificarSector_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If esIngles Then
            Me.Text = "Sector Modify"
            lblNombre.Text = "Name:"
            lblActividades.Text = "Select the activities that could practice in this sector:"
            btnCancelar.Text = "Cancel"
            btnGuardar.Text = "Save"
        End If
    End Sub
End Class