<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPlanEntrenamiento
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
        Me.lblFase = New System.Windows.Forms.Label
        Me.lblConsultarFase = New System.Windows.Forms.Label
        Me.lblPeriodo = New System.Windows.Forms.Label
        Me.lblDesde = New System.Windows.Forms.Label
        Me.lblConsultarDesde = New System.Windows.Forms.Label
        Me.lblHasta = New System.Windows.Forms.Label
        Me.lblConsultarHasta = New System.Windows.Forms.Label
        Me.lblDescripcion = New System.Windows.Forms.Label
        Me.rtbDescripcion = New System.Windows.Forms.RichTextBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.gbxCombos = New System.Windows.Forms.GroupBox
        Me.lblMostrarModo = New System.Windows.Forms.Label
        Me.lblModo = New System.Windows.Forms.Label
        Me.lblMostrarRepeticiones = New System.Windows.Forms.Label
        Me.lblRepeticiones = New System.Windows.Forms.Label
        Me.lblMostrarCarga = New System.Windows.Forms.Label
        Me.lblCarga = New System.Windows.Forms.Label
        Me.lblMostrarKcal = New System.Windows.Forms.Label
        Me.lblKcal = New System.Windows.Forms.Label
        Me.lblMostrarCantidad = New System.Windows.Forms.Label
        Me.lblCantidad = New System.Windows.Forms.Label
        Me.lblMostrarSesion = New System.Windows.Forms.Label
        Me.lblSesion = New System.Windows.Forms.Label
        Me.lstCombos = New System.Windows.Forms.ListBox
        Me.lblCombos = New System.Windows.Forms.Label
        Me.gbxCombos.SuspendLayout()
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
        'lblConsultarNombre
        '
        Me.lblConsultarNombre.AutoSize = True
        Me.lblConsultarNombre.Location = New System.Drawing.Point(66, 13)
        Me.lblConsultarNombre.Name = "lblConsultarNombre"
        Me.lblConsultarNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblConsultarNombre.TabIndex = 1
        Me.lblConsultarNombre.Text = "Nombre"
        '
        'lblFase
        '
        Me.lblFase.AutoSize = True
        Me.lblFase.Location = New System.Drawing.Point(13, 26)
        Me.lblFase.Name = "lblFase"
        Me.lblFase.Size = New System.Drawing.Size(33, 13)
        Me.lblFase.TabIndex = 2
        Me.lblFase.Text = "Fase:"
        '
        'lblConsultarFase
        '
        Me.lblConsultarFase.AutoSize = True
        Me.lblConsultarFase.Location = New System.Drawing.Point(53, 26)
        Me.lblConsultarFase.Name = "lblConsultarFase"
        Me.lblConsultarFase.Size = New System.Drawing.Size(30, 13)
        Me.lblConsultarFase.TabIndex = 3
        Me.lblConsultarFase.Text = "Fase"
        '
        'lblPeriodo
        '
        Me.lblPeriodo.AutoSize = True
        Me.lblPeriodo.Location = New System.Drawing.Point(191, 13)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(48, 13)
        Me.lblPeriodo.TabIndex = 4
        Me.lblPeriodo.Text = "Período:"
        '
        'lblDesde
        '
        Me.lblDesde.AutoSize = True
        Me.lblDesde.Location = New System.Drawing.Point(191, 26)
        Me.lblDesde.Name = "lblDesde"
        Me.lblDesde.Size = New System.Drawing.Size(41, 13)
        Me.lblDesde.TabIndex = 5
        Me.lblDesde.Text = "Desde:"
        '
        'lblConsultarDesde
        '
        Me.lblConsultarDesde.AutoSize = True
        Me.lblConsultarDesde.Location = New System.Drawing.Point(235, 26)
        Me.lblConsultarDesde.Name = "lblConsultarDesde"
        Me.lblConsultarDesde.Size = New System.Drawing.Size(57, 13)
        Me.lblConsultarDesde.TabIndex = 6
        Me.lblConsultarDesde.Text = "dd/mm/aa"
        '
        'lblHasta
        '
        Me.lblHasta.AutoSize = True
        Me.lblHasta.Location = New System.Drawing.Point(191, 39)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(38, 13)
        Me.lblHasta.TabIndex = 7
        Me.lblHasta.Text = "Hasta:"
        '
        'lblConsultarHasta
        '
        Me.lblConsultarHasta.AutoSize = True
        Me.lblConsultarHasta.Location = New System.Drawing.Point(236, 39)
        Me.lblConsultarHasta.Name = "lblConsultarHasta"
        Me.lblConsultarHasta.Size = New System.Drawing.Size(57, 13)
        Me.lblConsultarHasta.TabIndex = 8
        Me.lblConsultarHasta.Text = "dd/mm/aa"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(16, 81)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(66, 13)
        Me.lblDescripcion.TabIndex = 9
        Me.lblDescripcion.Text = "Descripción:"
        '
        'rtbDescripcion
        '
        Me.rtbDescripcion.Location = New System.Drawing.Point(19, 97)
        Me.rtbDescripcion.Name = "rtbDescripcion"
        Me.rtbDescripcion.Size = New System.Drawing.Size(274, 366)
        Me.rtbDescripcion.TabIndex = 10
        Me.rtbDescripcion.Text = ""
        '
        'btnCancel
        '
        Me.btnCancel.Image = Global.SIGEN.My.Resources.Resources.ok1
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.Location = New System.Drawing.Point(617, 469)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(105, 30)
        Me.btnCancel.TabIndex = 39
        Me.btnCancel.Text = "Ok"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'gbxCombos
        '
        Me.gbxCombos.Controls.Add(Me.lblMostrarModo)
        Me.gbxCombos.Controls.Add(Me.lblModo)
        Me.gbxCombos.Controls.Add(Me.lblMostrarRepeticiones)
        Me.gbxCombos.Controls.Add(Me.lblRepeticiones)
        Me.gbxCombos.Controls.Add(Me.lblMostrarCarga)
        Me.gbxCombos.Controls.Add(Me.lblCarga)
        Me.gbxCombos.Controls.Add(Me.lblMostrarKcal)
        Me.gbxCombos.Controls.Add(Me.lblKcal)
        Me.gbxCombos.Controls.Add(Me.lblMostrarCantidad)
        Me.gbxCombos.Controls.Add(Me.lblCantidad)
        Me.gbxCombos.Controls.Add(Me.lblMostrarSesion)
        Me.gbxCombos.Controls.Add(Me.lblSesion)
        Me.gbxCombos.Controls.Add(Me.lstCombos)
        Me.gbxCombos.Controls.Add(Me.lblCombos)
        Me.gbxCombos.Location = New System.Drawing.Point(299, 13)
        Me.gbxCombos.Name = "gbxCombos"
        Me.gbxCombos.Size = New System.Drawing.Size(423, 450)
        Me.gbxCombos.TabIndex = 40
        Me.gbxCombos.TabStop = False
        Me.gbxCombos.Text = "Series"
        '
        'lblMostrarModo
        '
        Me.lblMostrarModo.AutoSize = True
        Me.lblMostrarModo.Location = New System.Drawing.Point(297, 97)
        Me.lblMostrarModo.Name = "lblMostrarModo"
        Me.lblMostrarModo.Size = New System.Drawing.Size(34, 13)
        Me.lblMostrarModo.TabIndex = 13
        Me.lblMostrarModo.Text = "Modo"
        '
        'lblModo
        '
        Me.lblModo.AutoSize = True
        Me.lblModo.Location = New System.Drawing.Point(205, 97)
        Me.lblModo.Name = "lblModo"
        Me.lblModo.Size = New System.Drawing.Size(37, 13)
        Me.lblModo.TabIndex = 12
        Me.lblModo.Text = "Modo:"
        '
        'lblMostrarRepeticiones
        '
        Me.lblMostrarRepeticiones.AutoSize = True
        Me.lblMostrarRepeticiones.Location = New System.Drawing.Point(297, 84)
        Me.lblMostrarRepeticiones.Name = "lblMostrarRepeticiones"
        Me.lblMostrarRepeticiones.Size = New System.Drawing.Size(69, 13)
        Me.lblMostrarRepeticiones.TabIndex = 11
        Me.lblMostrarRepeticiones.Text = "Repeticiones"
        '
        'lblRepeticiones
        '
        Me.lblRepeticiones.AutoSize = True
        Me.lblRepeticiones.Location = New System.Drawing.Point(205, 84)
        Me.lblRepeticiones.Name = "lblRepeticiones"
        Me.lblRepeticiones.Size = New System.Drawing.Size(72, 13)
        Me.lblRepeticiones.TabIndex = 10
        Me.lblRepeticiones.Text = "Repeticiones:"
        '
        'lblMostrarCarga
        '
        Me.lblMostrarCarga.AutoSize = True
        Me.lblMostrarCarga.Location = New System.Drawing.Point(297, 71)
        Me.lblMostrarCarga.Name = "lblMostrarCarga"
        Me.lblMostrarCarga.Size = New System.Drawing.Size(35, 13)
        Me.lblMostrarCarga.TabIndex = 9
        Me.lblMostrarCarga.Text = "Carga"
        '
        'lblCarga
        '
        Me.lblCarga.AutoSize = True
        Me.lblCarga.Location = New System.Drawing.Point(205, 71)
        Me.lblCarga.Name = "lblCarga"
        Me.lblCarga.Size = New System.Drawing.Size(38, 13)
        Me.lblCarga.TabIndex = 8
        Me.lblCarga.Text = "Carga:"
        '
        'lblMostrarKcal
        '
        Me.lblMostrarKcal.AutoSize = True
        Me.lblMostrarKcal.Location = New System.Drawing.Point(297, 58)
        Me.lblMostrarKcal.Name = "lblMostrarKcal"
        Me.lblMostrarKcal.Size = New System.Drawing.Size(28, 13)
        Me.lblMostrarKcal.TabIndex = 7
        Me.lblMostrarKcal.Text = "Kcal"
        '
        'lblKcal
        '
        Me.lblKcal.AutoSize = True
        Me.lblKcal.Location = New System.Drawing.Point(205, 58)
        Me.lblKcal.Name = "lblKcal"
        Me.lblKcal.Size = New System.Drawing.Size(31, 13)
        Me.lblKcal.TabIndex = 6
        Me.lblKcal.Text = "Kcal:"
        '
        'lblMostrarCantidad
        '
        Me.lblMostrarCantidad.AutoSize = True
        Me.lblMostrarCantidad.Location = New System.Drawing.Point(297, 45)
        Me.lblMostrarCantidad.Name = "lblMostrarCantidad"
        Me.lblMostrarCantidad.Size = New System.Drawing.Size(49, 13)
        Me.lblMostrarCantidad.TabIndex = 5
        Me.lblMostrarCantidad.Text = "Cantidad"
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(204, 45)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(52, 13)
        Me.lblCantidad.TabIndex = 4
        Me.lblCantidad.Text = "Cantidad:"
        '
        'lblMostrarSesion
        '
        Me.lblMostrarSesion.AutoSize = True
        Me.lblMostrarSesion.Location = New System.Drawing.Point(297, 32)
        Me.lblMostrarSesion.Name = "lblMostrarSesion"
        Me.lblMostrarSesion.Size = New System.Drawing.Size(39, 13)
        Me.lblMostrarSesion.TabIndex = 3
        Me.lblMostrarSesion.Text = "Sesion"
        '
        'lblSesion
        '
        Me.lblSesion.AutoSize = True
        Me.lblSesion.Location = New System.Drawing.Point(204, 32)
        Me.lblSesion.Name = "lblSesion"
        Me.lblSesion.Size = New System.Drawing.Size(42, 13)
        Me.lblSesion.TabIndex = 2
        Me.lblSesion.Text = "Sesion:"
        '
        'lstCombos
        '
        Me.lstCombos.FormattingEnabled = True
        Me.lstCombos.Location = New System.Drawing.Point(9, 32)
        Me.lstCombos.Name = "lstCombos"
        Me.lstCombos.Size = New System.Drawing.Size(190, 407)
        Me.lstCombos.TabIndex = 1
        '
        'lblCombos
        '
        Me.lblCombos.AutoSize = True
        Me.lblCombos.Location = New System.Drawing.Point(6, 16)
        Me.lblCombos.Name = "lblCombos"
        Me.lblCombos.Size = New System.Drawing.Size(193, 13)
        Me.lblCombos.TabIndex = 0
        Me.lblCombos.Text = "Doble click en un item para visualizarlo."
        '
        'FrmPlanEntrenamiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 511)
        Me.Controls.Add(Me.gbxCombos)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.rtbDescripcion)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.lblConsultarHasta)
        Me.Controls.Add(Me.lblHasta)
        Me.Controls.Add(Me.lblConsultarDesde)
        Me.Controls.Add(Me.lblDesde)
        Me.Controls.Add(Me.lblPeriodo)
        Me.Controls.Add(Me.lblConsultarFase)
        Me.Controls.Add(Me.lblFase)
        Me.Controls.Add(Me.lblConsultarNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Name = "FrmPlanEntrenamiento"
        Me.Text = "Plan de Entrenamiento"
        Me.gbxCombos.ResumeLayout(False)
        Me.gbxCombos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblConsultarNombre As System.Windows.Forms.Label
    Friend WithEvents lblFase As System.Windows.Forms.Label
    Friend WithEvents lblConsultarFase As System.Windows.Forms.Label
    Friend WithEvents lblPeriodo As System.Windows.Forms.Label
    Friend WithEvents lblDesde As System.Windows.Forms.Label
    Friend WithEvents lblConsultarDesde As System.Windows.Forms.Label
    Friend WithEvents lblHasta As System.Windows.Forms.Label
    Friend WithEvents lblConsultarHasta As System.Windows.Forms.Label
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents rtbDescripcion As System.Windows.Forms.RichTextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents gbxCombos As System.Windows.Forms.GroupBox
    Friend WithEvents lstCombos As System.Windows.Forms.ListBox
    Friend WithEvents lblCombos As System.Windows.Forms.Label
    Friend WithEvents lblMostrarSesion As System.Windows.Forms.Label
    Friend WithEvents lblSesion As System.Windows.Forms.Label
    Friend WithEvents lblRepeticiones As System.Windows.Forms.Label
    Friend WithEvents lblMostrarCarga As System.Windows.Forms.Label
    Friend WithEvents lblCarga As System.Windows.Forms.Label
    Friend WithEvents lblMostrarKcal As System.Windows.Forms.Label
    Friend WithEvents lblKcal As System.Windows.Forms.Label
    Friend WithEvents lblMostrarCantidad As System.Windows.Forms.Label
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents lblMostrarModo As System.Windows.Forms.Label
    Friend WithEvents lblModo As System.Windows.Forms.Label
    Friend WithEvents lblMostrarRepeticiones As System.Windows.Forms.Label
End Class
