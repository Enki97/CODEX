Public Class FrmAltaSector
    Public esIngles As Boolean = False
    Dim nav = New Navegacion(Me)

    Public Sub cargarInstitutos()
        cmbInstituto.Items.Clear()
        Dim institutos As New Instituto()
        Dim lista() As String = institutos.listarIDNombre()
        If Not lista Is Nothing Then
            For Each ins As String In lista
                If Not ins Is Nothing Then
                    cmbInstituto.Items.Add(ins)
                End If
            Next
        End If
    End Sub

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

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        nav.anterior()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim rut As Long
        Dim nro_sector, actividades() As Integer
        Dim nombre As String
        Dim faltan As Boolean = False
        Dim invalido As Boolean = False
        Dim existe As Boolean = False
        Dim strFaltan, strExiste, strInvalido, strCorrecto As String
        Dim sector As New Sectores()

        If esIngles Then
            strFaltan = "The following fields are required: "
            strExiste = "The entered sector already exist. "
            strInvalido = "The following fields are invalid: "
            strCorrecto = "Successfully registered."
        Else
            strFaltan = "Faltan campos obligatorios: "
            strExiste = "El sector ingresado ya existe."
            strInvalido = "Los siguientes campos son inválidos: "
            strCorrecto = "Procedimiento Correcto."
        End If

        If cmbInstituto.SelectedItem = "" Then
            faltan = True
            If esIngles Then
                strFaltan += "/Institute"
            Else
                strFaltan += "/Instituto"
            End If
        Else
            Dim auxId As String = ""
            For Each c As Char In cmbInstituto.SelectedItem.ToString
                If c = ":" Then
                    Exit For
                Else
                    auxId += c
                End If
            Next
            rut = CLng(Trim(auxId))
        End If

        If txtNumeroSector.Text = "" Then
            faltan = True
            If esIngles Then
                strFaltan += "/Sector's Number"
            Else
                strFaltan += "/Número de Sector"
            End If
        Else
            For Each c As Char In txtNumeroSector.Text
                If Not Char.IsDigit(c) Then
                    invalido = True
                    If esIngles Then
                        strInvalido += "/Sector's Number"
                    Else
                        strInvalido += "/Número de Sector"
                    End If
                End If
            Next
            If Not invalido Then
                If sector.yaExiste(rut, CInt(Trim(txtNumeroSector.Text))) Then
                    existe = True
                Else
                    nro_sector = CInt(txtNumeroSector.Text)
                End If

            End If
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
        ElseIf existe Then
            MsgBox(strExiste + "/", MsgBoxStyle.Critical)
        Else
            'Ingresamos el sector
            sector.ingresarSector(rut, nro_sector, nombre)

            'Ingresamos las actividades con su id
            sector.ingresarActividades(rut, nro_sector, actividades)

            MsgBox(strCorrecto)
            txtNombre.Text = ""
            txtNumeroSector.Text = ""
            cmbInstituto.Items.Clear()
            cklActividades.Items.Clear()
            nav.anterior()
        End If
    End Sub

    Private Sub FrmAltaSector_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If esIngles Then
            Me.Text = "New Sector"
            lblNumeroSector.Text = "Sector's Number:"
            lblNombre.Text = "Name:"
            lblInstituto.Text = "Institute:"
            lblActividades.Text = "Select the activities that could practice in this sector:"
            btnCancelar.Text = "Cancel"
            btnGuardar.Text = "Save"
        End If
    End Sub
End Class