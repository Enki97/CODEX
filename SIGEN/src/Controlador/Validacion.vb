Public Class Validacion
    'Clase de validación creada por CODEX
    'El objetivo de esta clase es validar textbox

    Dim text As String

    Sub New(ByVal txt As String)
        Me.text = txt
    End Sub

    Function cedula()
        Dim soloNumero As Boolean = True
        For Each caracter As Char In Me.text
            If Not Char.IsDigit(caracter) Then
                soloNumero = False
            End If
        Next

        If Me.text.Length = 8 And soloNumero Then

            'Algoritmo para verificar si existe la cedula

            Dim ci = Me.text

            'Se debe multiplicar cada uno de los digitos de la cédula
            'por cada uno de los digitos del número 2987634.
            'Es decir, primero por primero, segundo por segundo y así
            'susesivamente. Ej: Si la ci es 4908877(El último digito
            'llamado verificador aún no se toma en cuenta)
            'El cálculo sería 4*2+9*9+8*0+8*7+8*6+7*3+7*4

            'Lo primero que se hará será almacenar c/resultado de
            'multiplicar los dígitos por separado y luego se los
            'sumara a todos en el resultado.
            Dim resultado, primero, segundo, tercero, cuarto, quinto, sexto, septimo As Integer

            Dim i, mayor As Integer 'Se utilizará más adelante en una iteración

            Dim verificador, resta As Integer 'Para verificar

            'No es posible convertir caracteres con CInt, por tanto se debe utilizar el siguiente metodo
            primero = ci(0).GetNumericValue(ci(0)) * 2
            segundo = ci(1).GetNumericValue(ci(1)) * 9
            tercero = ci(2).GetNumericValue(ci(2)) * 8
            cuarto = ci(3).GetNumericValue(ci(3)) * 7
            quinto = ci(4).GetNumericValue(ci(4)) * 6
            sexto = ci(5).GetNumericValue(ci(5)) * 3
            septimo = ci(6).GetNumericValue(ci(6)) * 4

            resultado = primero + segundo + tercero + cuarto + quinto + sexto + septimo

            'Ahora se debe buscar el primer número mayor al resultado que termine en 0
            i = resultado
            While True
                'Si al convertirlo a string el último caracter es igual a 0 entonces terminamos
                If i.ToString()(i.ToString.Length - 1) = "0" Then
                    mayor = i
                    Exit While
                End If
                i += 1
            End While

            'El último paso es trabajar con el verificador, primero lo igualamos al fin del string ci
            verificador = ci(7).GetNumericValue(ci(7))

            'Lo que nos dice el algoritmo, es que, al restar el digito verificador al mayor numero que termine
            'en cero después del resultado, es decir, la variable mayor, entonces el resultado de restar 
            'mayor - resultado de la primer cuenta, debe ser igual a verificador

            resta = mayor - resultado

            If resta = verificador Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function

    Function mail()
        Dim email As String = Me.text
        Dim tieneArroba As Boolean = False
        Dim tienePunto As Boolean = False

        For Each elemento As Char In email
            If elemento = "@" Then
                tieneArroba = True
            ElseIf elemento = "." Then
                tienePunto = True
            End If
        Next

        If tieneArroba And tienePunto Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
