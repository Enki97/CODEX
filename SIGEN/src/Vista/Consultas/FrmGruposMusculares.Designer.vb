<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGruposMusculares
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
        Me.rtbDescripcion = New System.Windows.Forms.RichTextBox
        Me.lblDescripcion = New System.Windows.Forms.Label
        Me.lblMostrarNombre = New System.Windows.Forms.Label
        Me.imgMusculo = New System.Windows.Forms.PictureBox
        Me.lblNombre = New System.Windows.Forms.Label
        Me.lblTipo = New System.Windows.Forms.Label
        Me.lblMostrarTipo = New System.Windows.Forms.Label
        Me.btnModificar = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        CType(Me.imgMusculo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rtbDescripcion
        '
        Me.rtbDescripcion.Location = New System.Drawing.Point(12, 185)
        Me.rtbDescripcion.Name = "rtbDescripcion"
        Me.rtbDescripcion.Size = New System.Drawing.Size(710, 278)
        Me.rtbDescripcion.TabIndex = 12
        Me.rtbDescripcion.Text = ""
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.Location = New System.Drawing.Point(12, 169)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(66, 13)
        Me.lblDescripcion.TabIndex = 11
        Me.lblDescripcion.Text = "Descripción:"
        '
        'lblMostrarNombre
        '
        Me.lblMostrarNombre.AutoSize = True
        Me.lblMostrarNombre.Location = New System.Drawing.Point(250, 12)
        Me.lblMostrarNombre.Name = "lblMostrarNombre"
        Me.lblMostrarNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblMostrarNombre.TabIndex = 10
        Me.lblMostrarNombre.Text = "Nombre"
        '
        'imgMusculo
        '
        Me.imgMusculo.Location = New System.Drawing.Point(12, 12)
        Me.imgMusculo.Name = "imgMusculo"
        Me.imgMusculo.Size = New System.Drawing.Size(179, 154)
        Me.imgMusculo.TabIndex = 9
        Me.imgMusculo.TabStop = False
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(197, 12)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 8
        Me.lblNombre.Text = "Nombre:"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.Location = New System.Drawing.Point(197, 36)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(31, 13)
        Me.lblTipo.TabIndex = 15
        Me.lblTipo.Text = "Tipo:"
        '
        'lblMostrarTipo
        '
        Me.lblMostrarTipo.AutoSize = True
        Me.lblMostrarTipo.Location = New System.Drawing.Point(250, 36)
        Me.lblMostrarTipo.Name = "lblMostrarTipo"
        Me.lblMostrarTipo.Size = New System.Drawing.Size(28, 13)
        Me.lblMostrarTipo.TabIndex = 16
        Me.lblMostrarTipo.Text = "Tipo"
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
        'FrmGruposMusculares
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 511)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblMostrarTipo)
        Me.Controls.Add(Me.lblTipo)
        Me.Controls.Add(Me.rtbDescripcion)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.lblMostrarNombre)
        Me.Controls.Add(Me.imgMusculo)
        Me.Controls.Add(Me.lblNombre)
        Me.Name = "FrmGruposMusculares"
        Me.Text = "Grupo Muscular"
        CType(Me.imgMusculo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rtbDescripcion As System.Windows.Forms.RichTextBox
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents lblMostrarNombre As System.Windows.Forms.Label
    Friend WithEvents imgMusculo As System.Windows.Forms.PictureBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents lblMostrarTipo As System.Windows.Forms.Label
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
