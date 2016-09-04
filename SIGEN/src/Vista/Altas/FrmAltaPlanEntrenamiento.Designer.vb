<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAltaPlanEntrenamiento
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
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.lblFase = New System.Windows.Forms.Label
        Me.cmbFase = New System.Windows.Forms.ComboBox
        Me.lblDescripcion = New System.Windows.Forms.Label
        Me.rtbDescripcion = New System.Windows.Forms.RichTextBox
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker
        Me.lblHasta = New System.Windows.Forms.Label
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker
        Me.lblDesde = New System.Windows.Forms.Label
        Me.lblSeries = New System.Windows.Forms.Label
        Me.cklDeportistas = New System.Windows.Forms.CheckedListBox
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.lstSeries = New System.Windows.Forms.ListBox
        Me.gbxDeportistas = New System.Windows.Forms.GroupBox
        Me.gbxPeriodo = New System.Windows.Forms.GroupBox
        Me.gbxDeportistas.SuspendLayout()
        Me.gbxPeriodo.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(13, 13)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(66, 10)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(190, 20)
        Me.txtNombre.TabIndex = 100
        '
        'lblFase
        '
        Me.lblFase.AutoSize = True
        Me.lblFase.Location = New System.Drawing.Point(262, 13)
        Me.lblFase.Name = "lblFase"
        Me.lblFase.Size = New System.Drawing.Size(33, 13)
        Me.lblFase.TabIndex = 101
        Me.lblFase.Text = "Fase:"
        '
        'cmbFase
        '
        Me.cmbFase.FormattingEnabled = True
        Me.cmbFase.Location = New System.Drawing.Point(309, 10)
        Me.cmbFase.Name = "cmbFase"
        Me.cmbFase.Size = New System.Drawing.Size(163, 21)
        Me.cmbFase.TabIndex = 102
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(13, 33)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(66, 13)
        Me.lblDescripcion.TabIndex = 103
        Me.lblDescripcion.Text = "Descripción:"
        '
        'rtbDescripcion
        '
        Me.rtbDescripcion.Location = New System.Drawing.Point(16, 49)
        Me.rtbDescripcion.Name = "rtbDescripcion"
        Me.rtbDescripcion.Size = New System.Drawing.Size(456, 96)
        Me.rtbDescripcion.TabIndex = 104
        Me.rtbDescripcion.Text = ""
        '
        'dtpHasta
        '
        Me.dtpHasta.Location = New System.Drawing.Point(269, 37)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(181, 20)
        Me.dtpHasta.TabIndex = 3
        '
        'lblHasta
        '
        Me.lblHasta.AutoSize = True
        Me.lblHasta.Location = New System.Drawing.Point(266, 20)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(38, 13)
        Me.lblHasta.TabIndex = 2
        Me.lblHasta.Text = "Hasta:"
        '
        'dtpDesde
        '
        Me.dtpDesde.Location = New System.Drawing.Point(10, 37)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(181, 20)
        Me.dtpDesde.TabIndex = 1
        '
        'lblDesde
        '
        Me.lblDesde.AutoSize = True
        Me.lblDesde.Location = New System.Drawing.Point(7, 20)
        Me.lblDesde.Name = "lblDesde"
        Me.lblDesde.Size = New System.Drawing.Size(41, 13)
        Me.lblDesde.TabIndex = 0
        Me.lblDesde.Text = "Desde:"
        '
        'lblSeries
        '
        Me.lblSeries.AutoSize = True
        Me.lblSeries.Location = New System.Drawing.Point(257, 225)
        Me.lblSeries.Name = "lblSeries"
        Me.lblSeries.Size = New System.Drawing.Size(39, 13)
        Me.lblSeries.TabIndex = 122
        Me.lblSeries.Text = "Series:"
        '
        'cklDeportistas
        '
        Me.cklDeportistas.FormattingEnabled = True
        Me.cklDeportistas.Location = New System.Drawing.Point(7, 20)
        Me.cklDeportistas.Name = "cklDeportistas"
        Me.cklDeportistas.Size = New System.Drawing.Size(221, 139)
        Me.cklDeportistas.TabIndex = 0
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.SIGEN.My.Resources.Resources.cancel
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(256, 369)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(105, 30)
        Me.btnCancelar.TabIndex = 99
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = Global.SIGEN.My.Resources.Resources.ok1
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.Location = New System.Drawing.Point(367, 369)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(105, 30)
        Me.btnGuardar.TabIndex = 98
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(447, 244)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 22)
        Me.Button1.TabIndex = 124
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lstSeries
        '
        Me.lstSeries.FormattingEnabled = True
        Me.lstSeries.Location = New System.Drawing.Point(260, 244)
        Me.lstSeries.Name = "lstSeries"
        Me.lstSeries.Size = New System.Drawing.Size(181, 121)
        Me.lstSeries.TabIndex = 125
        '
        'gbxDeportistas
        '
        Me.gbxDeportistas.Controls.Add(Me.cklDeportistas)
        Me.gbxDeportistas.Location = New System.Drawing.Point(16, 224)
        Me.gbxDeportistas.Name = "gbxDeportistas"
        Me.gbxDeportistas.Size = New System.Drawing.Size(234, 175)
        Me.gbxDeportistas.TabIndex = 121
        Me.gbxDeportistas.TabStop = False
        Me.gbxDeportistas.Text = "Selaccione Deportistas"
        '
        'gbxPeriodo
        '
        Me.gbxPeriodo.Controls.Add(Me.dtpHasta)
        Me.gbxPeriodo.Controls.Add(Me.lblHasta)
        Me.gbxPeriodo.Controls.Add(Me.dtpDesde)
        Me.gbxPeriodo.Controls.Add(Me.lblDesde)
        Me.gbxPeriodo.Location = New System.Drawing.Point(16, 151)
        Me.gbxPeriodo.Name = "gbxPeriodo"
        Me.gbxPeriodo.Size = New System.Drawing.Size(456, 67)
        Me.gbxPeriodo.TabIndex = 105
        Me.gbxPeriodo.TabStop = False
        Me.gbxPeriodo.Text = "Período"
        '
        'FrmAltaPlanEntrenamiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 411)
        Me.Controls.Add(Me.lstSeries)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.gbxPeriodo)
        Me.Controls.Add(Me.lblSeries)
        Me.Controls.Add(Me.rtbDescripcion)
        Me.Controls.Add(Me.gbxDeportistas)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.cmbFase)
        Me.Controls.Add(Me.lblFase)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.lblNombre)
        Me.Name = "FrmAltaPlanEntrenamiento"
        Me.Text = "Nuevo Plan de Entrenamiento"
        Me.gbxDeportistas.ResumeLayout(False)
        Me.gbxPeriodo.ResumeLayout(False)
        Me.gbxPeriodo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblFase As System.Windows.Forms.Label
    Friend WithEvents cmbFase As System.Windows.Forms.ComboBox
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents rtbDescripcion As System.Windows.Forms.RichTextBox
    Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblHasta As System.Windows.Forms.Label
    Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDesde As System.Windows.Forms.Label
    Friend WithEvents lblSeries As System.Windows.Forms.Label
    Friend WithEvents cklDeportistas As System.Windows.Forms.CheckedListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lstSeries As System.Windows.Forms.ListBox
    Friend WithEvents gbxDeportistas As System.Windows.Forms.GroupBox
    Friend WithEvents gbxPeriodo As System.Windows.Forms.GroupBox
End Class
