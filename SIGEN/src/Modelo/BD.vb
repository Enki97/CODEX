Public Class BD
    Public consulta As Odbc.OdbcDataReader
    'Se define como public para poder acceder a la consulta desde otras clases

    Public err As Exception = Nothing


    Private conexion As New Odbc.OdbcConnection
    'se define como variable de clase ya que necesitamos acceder a esta variable desde dos
    'metodos.



    'CONFIGURACION
    Dim ruta As String = Configuracion.getRutaDNS()
    Dim UID As String = Configuracion.getUID()
    Dim PWD As String = Configuracion.getPWD()

    Sub New(ByVal sql As String)
        'Se define la variable de conexion
        Dim strConexion As String

        strConexion = "FileDsn=" & ruta & ";UID=" & UID & ";PWD=" & PWD

        conexion.ConnectionString = strConexion

        'se utiliza try para poder capturar una exepcion en caso que halla un error
        Try
            conexion.Open()
            'abrimos la conexion

            Dim comando = New Odbc.OdbcCommand(sql, conexion)
            'se le pasa a comando la sentencia sql y la variable conexion


            'Comprueba la primera letra del string sql, pasando CChar a un strin devuelve la primera letra
            'por tanto si el comando empieza con:
            'I: Alta (Insert)
            'D: Baja (Delete)
            'U: Modificación (Update)
            'S: Consulta (Select)

            Dim ABMC = CChar(sql)

            Select Case ABMC
                Case "I"
                    Dim adaptador = New Odbc.OdbcDataAdapter()
                    comando.ExecuteNonQuery()
                    adaptador.InsertCommand = comando
                    conexion.Close()
                Case "D"
                    Dim adaptador = New Odbc.OdbcDataAdapter()
                    comando.ExecuteNonQuery()
                    adaptador.DeleteCommand = comando
                    conexion.Close()
                Case "U"
                    Dim adaptador = New Odbc.OdbcDataAdapter()
                    comando.ExecuteNonQuery()
                    adaptador.UpdateCommand = comando
                    conexion.Close()
                Case "S"
                    consulta = comando.ExecuteReader()
                    'En el caso de las consultas es necesario ejecutar el metodo
                    ' .close() ya que si se cierra todo en esta parte no seria posible
                    'acceder a la consulta desde el formulario. 
                    'Tambien el .read debera ser ejecutado externamente ya que a priori no se sabe
                    'si se consultara un elemento o varios, es decir, si el read debe usarse con while o no.
            End Select

        Catch ex As Exception
            Me.err = ex
        End Try
    End Sub
    Sub close()
        conexion.Close()
    End Sub
End Class


