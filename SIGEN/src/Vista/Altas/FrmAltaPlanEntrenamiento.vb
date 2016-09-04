Public Class FrmAltaPlanEntrenamiento
    Public esIngles As Boolean = False

    Dim series() As Dictionary(Of String, String) = Nothing
    Dim nav = New Navegacion(Me)

    Public Sub actualizarDeportistas()
        Dim strNoDeportista = "Aún no se han registrado deportistas."
        If esIngles Then
            strNoDeportista = "No sportmen added yet."
        End If
        cklDeportistas.Items.Clear()
        Dim lista As New Usuario()
        Dim deportistas As Dictionary(Of Integer, String) = lista.listar("deportista")
        If deportistas.Count > 0 Then
            For Each d In deportistas
                cklDeportistas.Items.Add(d.Key.ToString & " : " & d.Value.ToString)
            Next
        Else
            cklDeportistas.Items.Clear()
            cklDeportistas.Items.Add(strNoDeportista)
        End If
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        txtNombre.Text = ""
        cmbFase.SelectedItem = ""
        cmbFase.Items.Clear()
        rtbDescripcion.Text = ""
        dtpDesde.Value = Now
        dtpHasta.Value = Now
        For Each d As Integer In cklDeportistas.SelectedIndices
            cklDeportistas.SetSelected(d, False)
        Next
        lstSeries.Items.Clear()
        nav.anterior()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim plan As New PlanesEntrenamiento()
        Dim nombre, descripcion, fase As String
        Dim deportistas() As Integer
        Dim fechaDesde, fechaHasta As Date
        Dim strFaltan As String = "Faltan campos obligatorios: "
        Dim strExiste As String = "El nombre ingresado ya existe o hubo un error en la base de datos."
        Dim strCorrecto As String = "Procedimiento correcto."
        Dim strError As String = "Se produjo un error: " + vbNewLine
        Dim strErrorFecha As String = "La fecha de inicio es posterior a la de culminación."
        Dim faltan As Boolean = False
        Dim errorFecha As Boolean = False

        If esIngles Then
            strFaltan = "The following fields are required: "
            strExiste = "The entered name already exists or there was an error in the database."
            strCorrecto = "Successful procedure." + vbNewLine
            strError = "There was an error: "
            strErrorFecha = "The start date is later than the completion."
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

        If cmbFase.SelectedItem = "" Then
            faltan = True
            If esIngles Then
                strFaltan += "/Phase"
            Else
                strFaltan += "/Fase"
            End If
        Else
            fase = cmbFase.SelectedItem.ToString()
        End If

        If rtbDescripcion.Text = "" Then
            faltan = True
            If esIngles Then
                strFaltan += "/Description"
            Else
                strFaltan += "/Descripcion"
            End If
        Else
            descripcion = rtbDescripcion.Text
        End If

        If cklDeportistas.CheckedItems.Count = 0 Then
            faltan = True
            If esIngles Then
                strFaltan += "/Sportman"
            Else
                strFaltan += "/Deportistas"
            End If
        Else
            Dim auxID As String = ""
            Dim i As Integer = 0
            ReDim deportistas(cklDeportistas.CheckedItems.Count)
            For Each d As String In cklDeportistas.CheckedItems
                For Each c As Char In d
                    If Char.IsDigit(c) Then
                        auxID += c
                    Else
                        Exit For
                    End If
                Next
                deportistas(i) = CInt(auxID)
                i += 1
            Next
        End If
        fechaDesde = dtpDesde.Value
        If dtpHasta.Value < dtpDesde.Value Then
            errorFecha = True
        Else
            fechaHasta = dtpHasta.Value
        End If

        If faltan Then
            MsgBox(strFaltan, MsgBoxStyle.Critical)
        ElseIf errorFecha Then
            MsgBox(strErrorFecha, MsgBoxStyle.Critical)
        Else
            Dim id As Integer = plan.ingresarPlan(nombre, descripcion, fase, fechaDesde, fechaHasta)
            If id >= 0 Then
                For Each s In Me.series
                    If Not s Is Nothing Then
                        If s("tipo") = "C" Then
                            plan.pla_com(id, s("id"), s("sesion"), s("cantidad"), s("kcal"), _
                                         s("carga"), s("repeticiones"), s("modo"))
                        ElseIf s("tipo") = "E" Then
                            plan.pla_ej(id, s("id"), s("sesion"), s("cantidad"), s("kcal"), _
                                        s("carga"), s("repeticiones"), s("modo"))
                        End If
                    End If
                Next
                plan.cumple(id, deportistas)
                MsgBox(strCorrecto)

                txtNombre.Text = ""
                cmbFase.SelectedItem = ""
                cmbFase.Items.Clear()
                rtbDescripcion.Text = ""
                dtpDesde.Value = Now
                dtpHasta.Value = Now
                For Each d As Integer In cklDeportistas.SelectedIndices
                    cklDeportistas.SetSelected(d, False)
                Next
                lstSeries.Items.Clear()
                Me.series = Nothing
                nav.anterior()
            End If
        End If

    End Sub

    Private Sub FrmAltaPlanEntrenamiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.actualizarDeportistas()
        If esIngles Then
            Me.Text = "New Training Plan"
            lblNombre.Text = "Name:"
            lblFase.Text = "Phase:"
            lblDescripcion.Text = "Description:"
            gbxPeriodo.Text = "Period"
            lblDesde.Text = "From:"
            lblHasta.Text = "To:"
            gbxDeportistas.Text = "Select Sportmen"
            lblSeries.Text = "Select Combos and exercices:"
            cmbFase.Items.Add("Definition")
            cmbFase.Items.Add("Hipertrophy")
            cmbFase.Items.Add("Cardiovascular")
            cmbFase.Items.Add("Recovery")
            cmbFase.Items.Add("Adaptation")
            cmbFase.Items.Add("Others")
            btnCancelar.Text = "Cancel"
            btnGuardar.Text = "Save"
        Else
            cmbFase.Items.Add("Definición")
            cmbFase.Items.Add("Hipertrofia")
            cmbFase.Items.Add("Cardiovascular")
            cmbFase.Items.Add("Recuperacion")
            cmbFase.Items.Add("Adaptacion")
            cmbFase.Items.Add("Otros")
        End If
    End Sub

    Public Sub agregarSerie(ByVal serie As Dictionary(Of String, String))
        If Not Me.series Is Nothing Then
            Dim aux = Me.series
            Dim cantidad As Integer = series.Count()
            Me.series = Nothing
            ReDim Me.series(cantidad + 1)
            Dim i As Integer = 0
            For Each s In aux
                Me.series(i) = s
                i += 1
            Next
            Me.series(i) = serie
        Else
            ReDim Me.series(0)
            Me.series(0) = serie
        End If
        lstSeries.Items.Add(serie("nombre"))
    End Sub

    Function yaExiste(ByVal id As Integer, ByVal tipo As String)
        If series Is Nothing Then
            Return False
        Else
            For Each s In series
                If Not s Is Nothing Then
                    If s("id") = id And s("tipo") = tipo Then
                        Return True
                    End If
                End If
              
            Next
        End If
        Return False
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FrmSerie.esIngles = esIngles
        nav.siguiente(FrmSerie)
    End Sub
End Class