<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListaDeportistas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnSeleccionar = New System.Windows.Forms.Button
        Me.btnAtras = New System.Windows.Forms.Button
        Me.lstListaDeportistas = New System.Windows.Forms.ListBox
        Me.btnBaja = New System.Windows.Forms.Button
        Me.btnAlta = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.Image = Global.SIGEN.My.Resources.Resources.next1
        Me.btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSeleccionar.Location = New System.Drawing.Point(121, 469)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(124, 30)
        Me.btnSeleccionar.TabIndex = 19
        Me.btnSeleccionar.Text = "Seleccionar"
        Me.btnSeleccionar.UseVisualStyleBackColor = True
        '
        'btnAtras
        '
        Me.btnAtras.Image = Global.SIGEN.My.Resources.Resources.back
        Me.btnAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAtras.Location = New System.Drawing.Point(10, 469)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(105, 30)
        Me.btnAtras.TabIndex = 18
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'lstListaDeportistas
        '
        Me.lstListaDeportistas.FormattingEnabled = True
        Me.lstListaDeportistas.Location = New System.Drawing.Point(10, 12)
        Me.lstListaDeportistas.Name = "lstListaDeportistas"
        Me.lstListaDeportistas.Size = New System.Drawing.Size(197, 446)
        Me.lstListaDeportistas.TabIndex = 17
        '
        'btnBaja
        '
        Me.btnBaja.Location = New System.Drawing.Point(213, 41)
        Me.btnBaja.Name = "btnBaja"
        Me.btnBaja.Size = New System.Drawing.Size(32, 23)
        Me.btnBaja.TabIndex = 28
        Me.btnBaja.Text = "-"
        Me.btnBaja.UseVisualStyleBackColor = True
        '
        'btnAlta
        '
        Me.btnAlta.Location = New System.Drawing.Point(213, 12)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(32, 23)
        Me.btnAlta.TabIndex = 27
        Me.btnAlta.Text = "+"
        Me.btnAlta.UseVisualStyleBackColor = True
        '
        'FrmListaDeportistas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(254, 511)
        Me.Controls.Add(Me.btnBaja)
        Me.Controls.Add(Me.btnAlta)
        Me.Controls.Add(Me.btnSeleccionar)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.lstListaDeportistas)
        Me.Name = "FrmListaDeportistas"
        Me.Text = "Deportistas"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSeleccionar As System.Windows.Forms.Button
    Friend WithEvents btnAtras As System.Windows.Forms.Button
    Friend WithEvents lstListaDeportistas As System.Windows.Forms.ListBox
    Friend WithEvents btnBaja As System.Windows.Forms.Button
    Friend WithEvents btnAlta As System.Windows.Forms.Button
End Class
