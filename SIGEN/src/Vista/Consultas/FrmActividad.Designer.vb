<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmActividad
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
        Me.lblNombre = New System.Windows.Forms.Label
        Me.lblConsultarNombre = New System.Windows.Forms.Label
        Me.lblDescripcion = New System.Windows.Forms.Label
        Me.rtbDescripcion = New System.Windows.Forms.RichTextBox
        Me.btnModificar = New System.Windows.Forms.Button
        Me.lblDeportistas = New System.Windows.Forms.Label
        Me.lblAyudaDeportistas = New System.Windows.Forms.Label
        Me.lstDeportistas = New System.Windows.Forms.ListBox
        Me.lblSectores = New System.Windows.Forms.Label
        Me.lblSectoresAyuda = New System.Windows.Forms.Label
        Me.lstSectores = New System.Windows.Forms.ListBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.imgActividad = New System.Windows.Forms.PictureBox
        Me.lstEntrenadores = New System.Windows.Forms.ListBox
        Me.lblEntrenadores = New System.Windows.Forms.Label
        CType(Me.imgActividad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(216, 13)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre:"
        '
        'lblConsultarNombre
        '
        Me.lblConsultarNombre.AutoSize = True
        Me.lblConsultarNombre.Location = New System.Drawing.Point(269, 13)
        Me.lblConsultarNombre.Name = "lblConsultarNombre"
        Me.lblConsultarNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblConsultarNombre.TabIndex = 1
        Me.lblConsultarNombre.Text = "Nombre"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(217, 30)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(66, 13)
        Me.lblDescripcion.TabIndex = 3
        Me.lblDescripcion.Text = "Descripción:"
        '
        'rtbDescripcion
        '
        Me.rtbDescripcion.Location = New System.Drawing.Point(217, 47)
        Me.rtbDescripcion.Name = "rtbDescripcion"
        Me.rtbDescripcion.Size = New System.Drawing.Size(505, 100)
        Me.rtbDescripcion.TabIndex = 4
        Me.rtbDescripcion.Text = ""
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(506, 469)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(105, 30)
        Me.btnModificar.TabIndex = 38
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'lblDeportistas
        '
        Me.lblDeportistas.AutoSize = True
        Me.lblDeportistas.Location = New System.Drawing.Point(10, 154)
        Me.lblDeportistas.Name = "lblDeportistas"
        Me.lblDeportistas.Size = New System.Drawing.Size(63, 13)
        Me.lblDeportistas.TabIndex = 39
        Me.lblDeportistas.Text = "Deportistas:"
        '
        'lblAyudaDeportistas
        '
        Me.lblAyudaDeportistas.AutoSize = True
        Me.lblAyudaDeportistas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAyudaDeportistas.Location = New System.Drawing.Point(10, 167)
        Me.lblAyudaDeportistas.Name = "lblAyudaDeportistas"
        Me.lblAyudaDeportistas.Size = New System.Drawing.Size(192, 39)
        Me.lblAyudaDeportistas.TabIndex = 40
        Me.lblAyudaDeportistas.Text = "(Lista de deportistas que practican esta" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "actividad, haga doble click sobre un " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & _
            "deportista para ir a su perfil)"
        '
        'lstDeportistas
        '
        Me.lstDeportistas.FormattingEnabled = True
        Me.lstDeportistas.Location = New System.Drawing.Point(13, 209)
        Me.lstDeportistas.Name = "lstDeportistas"
        Me.lstDeportistas.Size = New System.Drawing.Size(195, 238)
        Me.lstDeportistas.TabIndex = 41
        '
        'lblSectores
        '
        Me.lblSectores.AutoSize = True
        Me.lblSectores.Location = New System.Drawing.Point(524, 154)
        Me.lblSectores.Name = "lblSectores"
        Me.lblSectores.Size = New System.Drawing.Size(52, 13)
        Me.lblSectores.TabIndex = 42
        Me.lblSectores.Text = "Sectores:"
        '
        'lblSectoresAyuda
        '
        Me.lblSectoresAyuda.AutoSize = True
        Me.lblSectoresAyuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSectoresAyuda.Location = New System.Drawing.Point(524, 167)
        Me.lblSectoresAyuda.Name = "lblSectoresAyuda"
        Me.lblSectoresAyuda.Size = New System.Drawing.Size(196, 26)
        Me.lblSectoresAyuda.TabIndex = 43
        Me.lblSectoresAyuda.Text = "(Sectores habilitados para la practica de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "esta actividad)"
        '
        'lstSectores
        '
        Me.lstSectores.FormattingEnabled = True
        Me.lstSectores.Location = New System.Drawing.Point(527, 209)
        Me.lstSectores.Name = "lstSectores"
        Me.lstSectores.Size = New System.Drawing.Size(195, 238)
        Me.lstSectores.TabIndex = 44
        '
        'btnCancel
        '
        Me.btnCancel.Image = Global.SIGEN.My.Resources.Resources.ok1
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.Location = New System.Drawing.Point(617, 469)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(105, 30)
        Me.btnCancel.TabIndex = 37
        Me.btnCancel.Text = "Ok"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'imgActividad
        '
        Me.imgActividad.Location = New System.Drawing.Point(13, 13)
        Me.imgActividad.Name = "imgActividad"
        Me.imgActividad.Size = New System.Drawing.Size(197, 134)
        Me.imgActividad.TabIndex = 2
        Me.imgActividad.TabStop = False
        '
        'lstEntrenadores
        '
        Me.lstEntrenadores.FormattingEnabled = True
        Me.lstEntrenadores.Location = New System.Drawing.Point(272, 209)
        Me.lstEntrenadores.Name = "lstEntrenadores"
        Me.lstEntrenadores.Size = New System.Drawing.Size(195, 238)
        Me.lstEntrenadores.TabIndex = 45
        '
        'lblEntrenadores
        '
        Me.lblEntrenadores.AutoSize = True
        Me.lblEntrenadores.Location = New System.Drawing.Point(269, 154)
        Me.lblEntrenadores.Name = "lblEntrenadores"
        Me.lblEntrenadores.Size = New System.Drawing.Size(73, 13)
        Me.lblEntrenadores.TabIndex = 46
        Me.lblEntrenadores.Text = "Entrenadores:"
        '
        'FrmActividad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 511)
        Me.Controls.Add(Me.lblEntrenadores)
        Me.Controls.Add(Me.lstEntrenadores)
        Me.Controls.Add(Me.lstSectores)
        Me.Controls.Add(Me.lblSectoresAyuda)
        Me.Controls.Add(Me.lblSectores)
        Me.Controls.Add(Me.lstDeportistas)
        Me.Controls.Add(Me.lblAyudaDeportistas)
        Me.Controls.Add(Me.lblDeportistas)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.rtbDescripcion)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.imgActividad)
        Me.Controls.Add(Me.lblConsultarNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Name = "FrmActividad"
        Me.Text = "Deporte/Actividad"
        CType(Me.imgActividad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblConsultarNombre As System.Windows.Forms.Label
    Friend WithEvents imgActividad As System.Windows.Forms.PictureBox
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents rtbDescripcion As System.Windows.Forms.RichTextBox
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblDeportistas As System.Windows.Forms.Label
    Friend WithEvents lblAyudaDeportistas As System.Windows.Forms.Label
    Friend WithEvents lstDeportistas As System.Windows.Forms.ListBox
    Friend WithEvents lblSectores As System.Windows.Forms.Label
    Friend WithEvents lblSectoresAyuda As System.Windows.Forms.Label
    Friend WithEvents lstSectores As System.Windows.Forms.ListBox
    Friend WithEvents lstEntrenadores As System.Windows.Forms.ListBox
    Friend WithEvents lblEntrenadores As System.Windows.Forms.Label
End Class
