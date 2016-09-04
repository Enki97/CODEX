<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIdioma
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmIdioma))
        Me.btnSalirBienvenido = New System.Windows.Forms.Button
        Me.btnIngles = New System.Windows.Forms.Button
        Me.btnEspañol = New System.Windows.Forms.Button
        Me.btnAbout = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnSalirBienvenido
        '
        Me.btnSalirBienvenido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalirBienvenido.Image = Global.SIGEN.My.Resources.Resources.exit2
        Me.btnSalirBienvenido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalirBienvenido.Location = New System.Drawing.Point(12, 58)
        Me.btnSalirBienvenido.Name = "btnSalirBienvenido"
        Me.btnSalirBienvenido.Size = New System.Drawing.Size(128, 35)
        Me.btnSalirBienvenido.TabIndex = 3
        Me.btnSalirBienvenido.Text = "Salir/&Exit"
        Me.btnSalirBienvenido.UseVisualStyleBackColor = True
        '
        'btnIngles
        '
        Me.btnIngles.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngles.Image = Global.SIGEN.My.Resources.Resources.english
        Me.btnIngles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIngles.Location = New System.Drawing.Point(146, 12)
        Me.btnIngles.Name = "btnIngles"
        Me.btnIngles.Size = New System.Drawing.Size(116, 40)
        Me.btnIngles.TabIndex = 2
        Me.btnIngles.Text = "E&nglish"
        Me.btnIngles.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnIngles.UseVisualStyleBackColor = True
        '
        'btnEspañol
        '
        Me.btnEspañol.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEspañol.Image = Global.SIGEN.My.Resources.Resources.spanish
        Me.btnEspañol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEspañol.Location = New System.Drawing.Point(12, 12)
        Me.btnEspañol.Name = "btnEspañol"
        Me.btnEspañol.Size = New System.Drawing.Size(128, 40)
        Me.btnEspañol.TabIndex = 1
        Me.btnEspañol.Text = "E&spañol"
        Me.btnEspañol.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEspañol.UseVisualStyleBackColor = True
        '
        'btnAbout
        '
        Me.btnAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAbout.Location = New System.Drawing.Point(146, 58)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(116, 35)
        Me.btnAbout.TabIndex = 4
        Me.btnAbout.Text = "&CODEX"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'FrmIdioma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 101)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnSalirBienvenido)
        Me.Controls.Add(Me.btnIngles)
        Me.Controls.Add(Me.btnEspañol)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(12, 12)
        Me.Name = "FrmIdioma"
        Me.Text = "Welcome/Bienvenido"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnEspañol As System.Windows.Forms.Button
    Friend WithEvents btnIngles As System.Windows.Forms.Button
    Friend WithEvents btnSalirBienvenido As System.Windows.Forms.Button
    Friend WithEvents btnAbout As System.Windows.Forms.Button
End Class
