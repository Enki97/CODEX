Public Class FrmListarCombos
    Public esIngles As Boolean = False
    Dim nav = New Navegacion(Me)

    Public Sub actualizarLista()
        Dim strNoCombo = "Aún no se han registrado combos."
        If esIngles Then
            strNoCombo = "No combos added yet."
        End If
        lstListaCombos.Items.Clear()
        Dim lista As New Combo()
        Dim combos() As String = lista.listar()
        If Not combos Is Nothing Then
            For Each c In combos
                lstListaCombos.Items.Add(c)
            Next
        Else
            lstListaCombos.Items.Clear()
            lstListaCombos.Items.Add(strNoCombo)
        End If
    End Sub

    Private Sub btnAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtras.Click
        nav.anterior()
    End Sub

    Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click
        If lstListaCombos.SelectedItem = "" Then
            Dim strError As String = "Debe seleccionar un combo."
            If esIngles Then
                strError = "You must select a combo."
            End If
            MsgBox(strError, MsgBoxStyle.Critical)
        Else
            Dim nombre As String = lstListaCombos.SelectedItem.ToString
            Dim com As New Combo
            Dim id As Integer = com.obtenerID(nombre)
            If id >= 0 Then
                Dim combo = New Combo(id)
                FrmCombo.esIngles = esIngles
                FrmCombo.combo = combo
                FrmCombo.actualizar()
                nav.siguiente(FrmCombo)
            Else
                If esIngles Then
                    MsgBox("There was an error on the database:" + vbNewLine + com.msg, MsgBoxStyle.Critical)
                Else
                    MsgBox("Se produjo un error en la base de datos:" + vbNewLine + com.msg, MsgBoxStyle.Critical)
                End If
            End If
        End If
    End Sub

    Private Sub btnAlta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlta.Click
        FrmAltaEjercicio.esIngles = esIngles
        'Para pasar al siguiente formulario comprobamos que se hayan ingresado ejercicios al sistema
        'ya que la relacion entre combos y ejercicios es necesaria
        Dim ej As New Ejercicio()
        If Not ej.listarIDNombre() Is Nothing Then
            nav.siguiente(FrmAltaCombo)
        Else
            Dim strError As String = "Debe ingresar ejercicios."
            If esIngles Then
                strError = "You must input exercises."
            End If
            MsgBox(strError)
        End If
    End Sub

    Private Sub FrmListarCombos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.actualizarLista()

        If esIngles Then
            Me.Text = "Combos"
            btnSeleccionar.Text = "Select"
            btnAtras.Text = "Back"
        End If
    End Sub

    Private Sub btnBaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBaja.Click
        Dim strError As String = "Debe seleccionar un combo."
        If Not lstListaCombos.SelectedItem = "" Then
            Dim com As New Combo()
            Dim strBorrar As String = "Esta seguro? (El combo sera borrado permanentemente)"
            Dim strOK As String = "Combo eliminado correctamente."
            Dim nombre As String = lstListaCombos.SelectedItem.ToString
            Dim id As Integer = com.obtenerID(nombre)

            If esIngles Then
                strBorrar = "Are you sure? (The combo will be permanently deleted)"
                strOK = "Combo deleted successfully."
            End If
            If MsgBox(strBorrar, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                com.bajaCombo(id)
                Me.actualizarLista()
                MsgBox(strOK)
            End If

        Else
            If esIngles Then
                strError = "You must select a combo."
                MsgBox(strError, MsgBoxStyle.Critical)
            Else
                MsgBox(strError, MsgBoxStyle.Critical)
            End If
        End If

    End Sub
End Class