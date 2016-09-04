Public Class Navegacion
    'Esta es una clase creada por CODEX, con el fin de no repetir código en la navegación
    'La instancia de esta clase será declarada en el evento Load del formulario
    'Se declara de esta manera Dim formulario = New Navegacion (Me)
    Dim actual As Form

    Public rutaRecursos As String = Configuracion.getRutaRecursos()

    Sub New(ByVal frmActual As Form)

        Me.actual = frmActual

        'Setea un icono a la ventana
        Me.actual.Icon = New Icon(rutaRecursos + "icono.ico")

    End Sub
    Public Sub anterior()
        'Vuelve al formulario anterior, se usan los ownedForms como forma de avisar que ese fue el formulario anterior._
        'Se utiliza en casos donde pueda devolverse a mas de dos ventanas, como los perfiles, que pueden ser consultados_
        'desde distintos formularios.


        Me.actual.OwnedForms(Me.actual.OwnedForms().Length - 1).Show() 'Esto accede al último formulario del array y lo muestra
        Me.actual.Hide()
    End Sub
    Public Sub siguiente(ByVal frmDestino As Form)
        'Se avisa al siguiente formulario que el actual formulario será su anterior. Además muestra el siguiente formulario_
        'y esconde el actual.
        frmDestino.AddOwnedForm(Me.actual)
        frmDestino.Show()
        Me.actual.Hide()
    End Sub
    Public Sub cerrar()

        Application.Exit()
    End Sub
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class
