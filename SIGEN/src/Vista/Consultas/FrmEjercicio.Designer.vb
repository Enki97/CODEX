<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEjercicio
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
        Me.wbVideo = New System.Windows.Forms.WebBrowser
        Me.imgEjercicio = New System.Windows.Forms.PictureBox
        Me.lblMostrarNombre = New System.Windows.Forms.Label
        Me.lblDescripcion = New System.Windows.Forms.Label
        Me.rtbDescripcion = New System.Windows.Forms.RichTextBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.lblGruposMusculares = New System.Windows.Forms.Label
        Me.lstGruposMusculares = New System.Windows.Forms.ListBox
        Me.btnModificar = New System.Windows.Forms.Button
        CType(Me.imgEjercicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(163, 268)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre:"
        '
        'wbVideo
        '
        Me.wbVideo.Location = New System.Drawing.Point(12, 12)
        Me.wbVideo.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbVideo.Name = "wbVideo"
        Me.wbVideo.Size = New System.Drawing.Size(710, 250)
        Me.wbVideo.TabIndex = 1
        '
        'imgEjercicio
        '
        Me.imgEjercicio.Location = New System.Drawing.Point(12, 268)
        Me.imgEjercicio.Name = "imgEjercicio"
        Me.imgEjercicio.Size = New System.Drawing.Size(145, 190)
        Me.imgEjercicio.TabIndex = 2
        Me.imgEjercicio.TabStop = False
        '
        'lblMostrarNombre
        '
        Me.lblMostrarNombre.AutoSize = True
        Me.lblMostrarNombre.Location = New System.Drawing.Point(216, 268)
        Me.lblMostrarNombre.Name = "lblMostrarNombre"
        Me.lblMostrarNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblMostrarNombre.TabIndex = 3
        Me.lblMostrarNombre.Text = "Nombre"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.Location = New System.Drawing.Point(163, 295)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(66, 13)
        Me.lblDescripcion.TabIndex = 4
        Me.lblDescripcion.Text = "Descripción:"
        '
        'rtbDescripcion
        '
        Me.rtbDescripcion.Location = New System.Drawing.Point(166, 311)
        Me.rtbDescripcion.Name = "rtbDescripcion"
        Me.rtbDescripcion.Size = New System.Drawing.Size(312, 147)
        Me.rtbDescripcion.TabIndex = 5
        Me.rtbDescripcion.Text = ""
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
        'lblGruposMusculares
        '
        Me.lblGruposMusculares.AutoSize = True
        Me.lblGruposMusculares.Location = New System.Drawing.Point(488, 268)
        Me.lblGruposMusculares.Name = "lblGruposMusculares"
        Me.lblGruposMusculares.Size = New System.Drawing.Size(205, 13)
        Me.lblGruposMusculares.TabIndex = 39
        Me.lblGruposMusculares.Text = "Ejercita los siguientes Grupos Musculares:"
        '
        'lstGruposMusculares
        '
        Me.lstGruposMusculares.FormattingEnabled = True
        Me.lstGruposMusculares.Location = New System.Drawing.Point(491, 285)
        Me.lstGruposMusculares.Name = "lstGruposMusculares"
        Me.lstGruposMusculares.Size = New System.Drawing.Size(231, 173)
        Me.lstGruposMusculares.TabIndex = 40
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(506, 469)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(105, 30)
        Me.btnModificar.TabIndex = 41
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'FrmEjercicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 511)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.lstGruposMusculares)
        Me.Controls.Add(Me.lblGruposMusculares)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.rtbDescripcion)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.lblMostrarNombre)
        Me.Controls.Add(Me.imgEjercicio)
        Me.Controls.Add(Me.wbVideo)
        Me.Controls.Add(Me.lblNombre)
        Me.Name = "FrmEjercicio"
        Me.Text = "Ejercicio"
        CType(Me.imgEjercicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents wbVideo As System.Windows.Forms.WebBrowser
    Friend WithEvents imgEjercicio As System.Windows.Forms.PictureBox
    Friend WithEvents lblMostrarNombre As System.Windows.Forms.Label
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents rtbDescripcion As System.Windows.Forms.RichTextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblGruposMusculares As System.Windows.Forms.Label
    Friend WithEvents lstGruposMusculares As System.Windows.Forms.ListBox
    Friend WithEvents btnModificar As System.Windows.Forms.Button
End Class
