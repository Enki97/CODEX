Public Class FrmListarSectores
    Public esIngles As Boolean = False
    Dim nav = New Navegacion(Me)
    Public Sub actualizarLista()
        Dim strNoSector = "Aún no se han registrado sectores."
        If esIngles Then
            strNoSector = "No sector added yet."
        End If
        lstListaSectores.Items.Clear()
        Dim lista As New Sectores()
        Dim sectores() As String = lista.listarSectores()
        If Not sectores Is Nothing Then
            For Each s In sectores
                lstListaSectores.Items.Add(s)
            Next
        Else
            lstListaSectores.Items.Clear()
            lstListaSectores.Items.Add(strNoSector)
        End If
    End Sub
    Private Sub btnAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtras.Click
        nav.anterior()
    End Sub

    Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click
        If lstListaSectores.SelectedItem = "" Then
            Dim strError As String = "Debe seleccionar un instituto."
            If esIngles Then
                strError = "You must select an institute."
            End If
            MsgBox(strError, MsgBoxStyle.Critical)
        Else
            Dim substring As String
            Dim auxSector As String = ""
            Dim rut As Long
            Dim nro_sector As Integer
            Dim pasoParentesis As Boolean = False
            Dim auxRut As String = ""
            Dim auxNro As String = ""

            For Each c As Char In lstListaSectores.SelectedItem
                If c = ":" Then
                    Exit For
                Else
                    substring += c
                End If
            Next

            For Each c As Char In substring
                If c = "(" Then
                    pasoParentesis = True
                    Continue For
                ElseIf c = ")" Then
                    Exit For
                End If
                If pasoParentesis Then
                    auxNro += c
                Else
                    auxRut += c
                End If
            Next

            rut = CLng(Trim(auxRut))
            nro_sector = CInt(Trim(auxNro))


            Dim sector As New Sectores(rut, nro_sector)

            FrmSector.sector = sector
            FrmSector.esIngles = esIngles
            FrmSector.cargarDatos()
            nav.siguiente(FrmSector)
        End If
    End Sub

    Private Sub btnAlta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlta.Click
        FrmAltaSector.esIngles = esIngles
        FrmAltaSector.cargarActividades()
        FrmAltaSector.cargarInstitutos()
        nav.siguiente(FrmAltaSector)
    End Sub

    Private Sub FrmListarSectores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.actualizarLista()
        If esIngles Then
            Me.Text = "Sectors"
            btnAtras.Text = "Back"
            btnSeleccionar.Text = "Select"
        End If
    End Sub

    Private Sub btnBaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBaja.Click
        Dim strError As String = "Debe seleccionar un sector."
        If Not lstListaSectores.SelectedItem = "" Then
            Dim s As New Sectores()
            Dim strBorrar As String = "Esta seguro? (El sector sera borrado permanentemente)"
            Dim strOK As String = "Sector eliminado correctamente."
            Dim nombre As String = lstListaSectores.SelectedItem.ToString
            Dim substring As String
            Dim auxSector As String = ""
            Dim rut As Long
            Dim nro_sector As Integer
            Dim pasoParentesis As Boolean = False
            Dim auxRut As String = ""
            Dim auxNro As String = ""

            For Each c As Char In lstListaSectores.SelectedItem
                If c = ":" Then
                    Exit For
                Else
                    substring += c
                End If
            Next

            For Each c As Char In substring
                If c = "(" Then
                    pasoParentesis = True
                    Continue For
                ElseIf c = ")" Then
                    Exit For
                End If
                If pasoParentesis Then
                    auxNro += c
                Else
                    auxRut += c
                End If
            Next

            rut = CLng(Trim(auxRut))
            nro_sector = CInt(Trim(auxNro))

            If esIngles Then
                strBorrar = "Are you sure? (The sector will be permanently deleted)"
                strOK = "Sector deleted successfully."
            End If
            If MsgBox(strBorrar, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                s.bajaSectores(rut, nro_sector)
                Me.actualizarLista()
                MsgBox(strOK)
            End If

        Else
            If esIngles Then
                strError = "You must select a sector."
                MsgBox(strError, MsgBoxStyle.Critical)
            Else
                MsgBox(strError, MsgBoxStyle.Critical)
            End If
        End If
    End Sub
End Class