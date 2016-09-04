Public Class Realiza
    Public documento, id_actividad As Integer
    Public posicion As String
    Public msg As String
    Public realizaActividad As Boolean = False

    Public Sub New(Optional ByVal documento As Integer = Nothing)
        If Not documento = Nothing Then
            Try
                Dim realiza = New BD("SELECT id_actividad, posicion FROM REALIZAN WHERE documento =" & documento)
                realiza.consulta.Read()
                If realiza.consulta.HasRows Then
                    Me.documento = documento
                    Me.id_actividad = realiza.consulta.GetValue(0)
                    Me.posicion = realiza.consulta.GetValue(1)
                    Me.realizaActividad = True
                Else
                    Me.msg = "NE"
                End If
            Catch ex As Exception
                Me.msg = ex.ToString
            End Try
        End If
    End Sub

    Function ingresar(ByVal documento As Integer, ByVal id_actividad As Integer, ByVal posicion As String)
        Try
            Dim realizan = New BD("INSERT INTO REALIZAN VALUES(documento ='" & documento & "','" & id_actividad & _
                                  "','" & posicion & "')")
            Return 0
        Catch ex As Exception
            Me.msg = ex.ToString
            Return 1
        End Try
    End Function

    Function modificar(ByVal documento As Integer, Optional ByVal id_actividad As Integer = Nothing, Optional ByVal posicion As String = Nothing)
        If id_actividad = Nothing Then
            id_actividad = Me.id_actividad
        End If
        If posicion Is Nothing Then
            posicion = Me.posicion
        End If
        Try
            'Porque borramos e ingresamos en lugar de hacer update? Se borra e ingresa porque con el update habría que modificar
            'claves primarias y esto no es posible.
            Dim borrar As New BD("DELETE FROM REALIZAN WHERE DOCUMENTO=" & documento)
            Dim realizan = New BD("INSERT INTO REALIZAN VALUES('" & documento & "','" & id_actividad & _
                                   "','" & posicion & "')")
            Return 0
        Catch ex As Exception
            Me.msg = ex.ToString
            MsgBox(Me.msg)
            Return -1
        End Try
    End Function

    Function listarDeportistas(ByVal id)
        Dim cantidad As Integer
        Dim deportistas() As Integer
        Try
            Dim contar = New BD("SELECT COUNT(*) FROM REALIZAN WHERE id_actividad=" & id)
            contar.consulta.Read()
            cantidad = contar.consulta.GetValue(0)
            contar.close()
            ReDim deportistas(cantidad)
        Catch ex As Exception
            Me.msg = ex.ToString
            Return 1
        End Try
        If cantidad >= 1 Then
            Try
                Dim consultar As New BD("SELECT documento FROM REALIZAN WHERE id_actividad=" & id)
                Dim i As Integer = 0
                While consultar.consulta.Read()
                    deportistas(i) = consultar.consulta.GetValue(0)
                End While
                consultar.close()
            Catch ex As Exception
                Me.msg = ex.ToString
                Return 1
            End Try
        End If
        Return deportistas
    End Function
End Class
