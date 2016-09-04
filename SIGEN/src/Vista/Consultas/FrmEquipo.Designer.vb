<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEquipo
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
        Me.btnModificar = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.lblNombre = New System.Windows.Forms.Label
        Me.lblActividad = New System.Windows.Forms.Label
        Me.lblConsultarNombre = New System.Windows.Forms.Label
        Me.lblConsultarActividad = New System.Windows.Forms.Label
        Me.lblEsSeleccion = New System.Windows.Forms.Label
        Me.lblConsultarEsSeleccion = New System.Windows.Forms.Label
        Me.lblDeportistas = New System.Windows.Forms.Label
        Me.lstDeportistas = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(506, 469)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(105, 30)
        Me.btnModificar.TabIndex = 70
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Image = Global.SIGEN.My.Resources.Resources.ok1
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.Location = New System.Drawing.Point(617, 469)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(105, 30)
        Me.btnCancel.TabIndex = 69
        Me.btnCancel.Text = "Ok"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(12, 9)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(55, 13)
        Me.lblNombre.TabIndex = 71
        Me.lblNombre.Text = "Categoria:"
        '
        'lblActividad
        '
        Me.lblActividad.AutoSize = True
        Me.lblActividad.Location = New System.Drawing.Point(12, 30)
        Me.lblActividad.Name = "lblActividad"
        Me.lblActividad.Size = New System.Drawing.Size(97, 13)
        Me.lblActividad.TabIndex = 72
        Me.lblActividad.Text = "Actividad/Deporte:"
        '
        'lblConsultarNombre
        '
        Me.lblConsultarNombre.AutoSize = True
        Me.lblConsultarNombre.Location = New System.Drawing.Point(125, 9)
        Me.lblConsultarNombre.Name = "lblConsultarNombre"
        Me.lblConsultarNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblConsultarNombre.TabIndex = 73
        Me.lblConsultarNombre.Text = "Nombre"
        '
        'lblConsultarActividad
        '
        Me.lblConsultarActividad.AutoSize = True
        Me.lblConsultarActividad.Location = New System.Drawing.Point(125, 30)
        Me.lblConsultarActividad.Name = "lblConsultarActividad"
        Me.lblConsultarActividad.Size = New System.Drawing.Size(51, 13)
        Me.lblConsultarActividad.TabIndex = 74
        Me.lblConsultarActividad.Text = "Actividad"
        '
        'lblEsSeleccion
        '
        Me.lblEsSeleccion.AutoSize = True
        Me.lblEsSeleccion.Location = New System.Drawing.Point(12, 55)
        Me.lblEsSeleccion.Name = "lblEsSeleccion"
        Me.lblEsSeleccion.Size = New System.Drawing.Size(91, 13)
        Me.lblEsSeleccion.TabIndex = 75
        Me.lblEsSeleccion.Text = "Es una selección:"
        '
        'lblConsultarEsSeleccion
        '
        Me.lblConsultarEsSeleccion.AutoSize = True
        Me.lblConsultarEsSeleccion.Location = New System.Drawing.Point(125, 55)
        Me.lblConsultarEsSeleccion.Name = "lblConsultarEsSeleccion"
        Me.lblConsultarEsSeleccion.Size = New System.Drawing.Size(35, 13)
        Me.lblConsultarEsSeleccion.TabIndex = 76
        Me.lblConsultarEsSeleccion.Text = "Si/No"
        '
        'lblDeportistas
        '
        Me.lblDeportistas.AutoSize = True
        Me.lblDeportistas.Location = New System.Drawing.Point(12, 78)
        Me.lblDeportistas.Name = "lblDeportistas"
        Me.lblDeportistas.Size = New System.Drawing.Size(124, 13)
        Me.lblDeportistas.TabIndex = 77
        Me.lblDeportistas.Text = "Deportistas en el equipo:"
        '
        'lstDeportistas
        '
        Me.lstDeportistas.FormattingEnabled = True
        Me.lstDeportistas.Location = New System.Drawing.Point(15, 94)
        Me.lstDeportistas.Name = "lstDeportistas"
        Me.lstDeportistas.Size = New System.Drawing.Size(707, 355)
        Me.lstDeportistas.TabIndex = 78
        '
        'FrmEquipo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 511)
        Me.Controls.Add(Me.lstDeportistas)
        Me.Controls.Add(Me.lblDeportistas)
        Me.Controls.Add(Me.lblConsultarEsSeleccion)
        Me.Controls.Add(Me.lblEsSeleccion)
        Me.Controls.Add(Me.lblConsultarActividad)
        Me.Controls.Add(Me.lblConsultarNombre)
        Me.Controls.Add(Me.lblActividad)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnCancel)
        Me.Name = "FrmEquipo"
        Me.Text = "Equipo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblActividad As System.Windows.Forms.Label
    Friend WithEvents lblConsultarNombre As System.Windows.Forms.Label
    Friend WithEvents lblConsultarActividad As System.Windows.Forms.Label
    Friend WithEvents lblEsSeleccion As System.Windows.Forms.Label
    Friend WithEvents lblConsultarEsSeleccion As System.Windows.Forms.Label
    Friend WithEvents lblDeportistas As System.Windows.Forms.Label
    Friend WithEvents lstDeportistas As System.Windows.Forms.ListBox
End Class
