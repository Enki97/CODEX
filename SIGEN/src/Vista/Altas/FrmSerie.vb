Public Class FrmSerie
    Public esIngles As Boolean = False
    Dim nav As New Navegacion(Me)
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        txtCantidad.Text = ""
        txtCarga.Text = ""
        txtKcal.Text = ""
        txtModo.Text = ""
        txtRepeticiones.Text = ""
        cmbSesion.SelectedItem = ""
        nav.anterior()
    End Sub

    Private Sub FrmSerie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If esIngles Then
            lblCantidad.Text = "Amount:"
            lblCarga.Text = "Weight:"
            lblKcal.Text = "Burned Kcal:"
            lblModo.Text = "Mode:"
            lblRepeticiones.Text = "Repetitions:"
            rbnEjercicio.Text = "Exercice"
            cmbSesion.Items.Add("Morning")
            cmbSesion.Items.Add("Afternoon")
            cmbSesion.Items.Add("Evening")
        Else
            cmbSesion.Items.Add("Matutina")
            cmbSesion.Items.Add("Vespertina")
            cmbSesion.Items.Add("Nocturna")
        End If
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim id, cantidad, kcal_quemadas, carga, repeticiones As Integer
        Dim sesion, modo, seleccionado, nombre As String
        Dim esCombo As Boolean
        Dim strExiste As String = "Ya existe esa serie en el Plan de entrenamiento."
        Dim strFaltan As String = "Faltan campos obligatorios: "
        Dim strNumero As String = "Los siguientes campos solo admiten números: "
        Dim faltan As Boolean = False
        Dim numero As Boolean = False
        Dim existe As Boolean = False

        If esIngles Then
            strFaltan = "The following fields are required: "
            strNumero = "The following field only accepts numbers: "
            strExiste = "The serie already exist in the training plan."
        End If

        If rbnCombo.Checked Then
            esCombo = True
        ElseIf rbnEjercicio.Checked Then
            esCombo = False
        Else
            faltan = True
            strFaltan += "/Combos"
        End If
        If cmbSesion.SelectedItem = "" Then
            faltan = True
            strFaltan += "/Sesion"
        Else
            If esIngles Then
                If cmbSesion.SelectedItem = "Morning" Then
                    sesion = "Matutina"
                ElseIf cmbSesion.SelectedItem = "Afternoon" Then
                    sesion = "Vespertina"
                Else
                    sesion = "Nocturna"
                End If
            Else
                sesion = cmbSesion.SelectedItem.ToString
            End If
        End If

        For Each c As Char In txtCantidad.Text
            If Not Char.IsDigit(c) Then
                numero = True
                If esIngles Then
                    strNumero += "/Amount"
                Else
                    strNumero += "/Cantidad"
                End If
                Exit For
            End If
        Next
        If txtCantidad.Text = "" Then
            faltan = True
            If esIngles Then
                strFaltan += "/Amount"
            Else
                strFaltan += "/Cantidad"
            End If
        Else
            cantidad = txtCantidad.Text
        End If


        For Each c As Char In txtKcal.Text
            If Not Char.IsDigit(c) Then
                numero = True
                If esIngles Then
                    strNumero += "/Burned Kcal"
                Else
                    strNumero += "/Kcal Quemadas"
                End If
                Exit For
            End If
        Next
        If txtKcal.Text = "" Then
            faltan = True
            If esIngles Then
                strFaltan += "/Burned Kcal"
            Else
                strFaltan += "/Kcal Quemadas"
            End If
        Else
            kcal_quemadas = txtKcal.Text
        End If

        For Each c As Char In txtCarga.Text
            If Not Char.IsDigit(c) Then
                numero = True
                If esIngles Then
                    strNumero += "/Weight"
                Else
                    strNumero += "/Carga"
                End If
                Exit For
            End If
        Next
        If txtCarga.Text = "" Then
            faltan = True
            If esIngles Then
                strFaltan += "/Weight"
            Else
                strFaltan += "/Carga"
            End If
        Else
            carga = txtCarga.Text
        End If

        For Each c As Char In txtRepeticiones.Text
            If Not Char.IsDigit(c) Then
                numero = True
                If esIngles Then
                    strNumero += "/Repetitions"
                Else
                    strNumero += "/Repeticiones"
                End If
                Exit For
            End If
        Next
        If txtRepeticiones.Text = "" Then
            faltan = True
            If esIngles Then
                strFaltan += "/Repetitions"
            Else
                strFaltan += "/Repeticiones"
            End If
        Else
            repeticiones = txtRepeticiones.Text
        End If

        If txtModo.Text = "" Then
            modo = "--------"
        Else
            modo = txtModo.Text
        End If

        If lstSerie.SelectedItem = "" Then
            faltan = True
            If esIngles Then
                strFaltan += "/Exersice/Combo"
            Else
                strFaltan += "/Ejercicio/Combo"
            End If
        Else
            seleccionado = lstSerie.SelectedItem.ToString
        End If


        If faltan Then
            MsgBox(strFaltan + "/", MsgBoxStyle.Critical)
        ElseIf numero Then
            MsgBox(strNumero + "/", MsgBoxStyle.Critical)
        Else
            Dim s As New Dictionary(Of String, String)
            If esCombo Then
                s("tipo") = "C"
            Else
                s("tipo") = "E"
            End If

            Dim auxID As String = ""
            Dim auxNombre As String = ""
            Dim empiezaNombre As Boolean = False
            For Each c As Char In seleccionado
                If c = ":" Then
                    empiezaNombre = True
                Else
                    If empiezaNombre Then
                        auxNombre += c
                    Else
                        auxID += c
                    End If
                End If
            Next
            empiezaNombre = False
            id = auxID
            nombre = auxNombre
            s("id") = Trim(id)
            s("nombre") = Trim(nombre)
            s("sesion") = sesion
            s("cantidad") = cantidad
            s("kcal") = kcal_quemadas
            s("carga") = carga
            s("repeticiones") = repeticiones
            s("modo") = modo
            If FrmAltaPlanEntrenamiento.yaExiste(s("id"), s("tipo")) Then
                MsgBox(strExiste, MsgBoxStyle.Critical)
                s = Nothing
            Else
                FrmAltaPlanEntrenamiento.agregarSerie(s)
                s = Nothing
                txtCantidad.Text = ""
                txtCarga.Text = ""
                txtKcal.Text = ""
                txtModo.Text = ""
                txtRepeticiones.Text = ""
                cmbSesion.SelectedItem = ""
                nav.anterior()
            End If
        End If

    End Sub

    Private Sub rbnCombo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbnCombo.Click
        Dim strNoCombo = "Aún no se han registrado combos."
        If esIngles Then
            strNoCombo = "No combos added yet."
        End If
        lstSerie.Items.Clear()
        Dim lista As New Combo()
        Dim combos() As String = lista.listarIDNombre()
        If Not combos Is Nothing Then
            For Each c In combos
                lstSerie.Items.Add(c)
            Next
        Else
            lstSerie.Items.Clear()
            lstSerie.Items.Add(strNoCombo)
        End If
    End Sub

    Private Sub rbnEjercicio_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbnEjercicio.Click
        Dim strNoEjercicio = "Aún no se han registrado ejercicios."
        If esIngles Then
            strNoEjercicio = "No exercise added yet."
        End If
        lstSerie.Items.Clear()
        Dim lista As New Ejercicio()
        Dim ejercicios() As String = lista.listarIDNombre()
        If Not ejercicios Is Nothing Then
            For Each ej In ejercicios
                lstSerie.Items.Add(ej)
            Next
        Else
            lstSerie.Items.Clear()
            lstSerie.Items.Add(strNoEjercicio)
        End If
    End Sub
End Class