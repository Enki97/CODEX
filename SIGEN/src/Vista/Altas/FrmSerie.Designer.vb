<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSerie
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
        Me.lstSerie = New System.Windows.Forms.ListBox
        Me.rbnCombo = New System.Windows.Forms.RadioButton
        Me.rbnEjercicio = New System.Windows.Forms.RadioButton
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.txtCantidad = New System.Windows.Forms.TextBox
        Me.txtKcal = New System.Windows.Forms.TextBox
        Me.txtCarga = New System.Windows.Forms.TextBox
        Me.txtModo = New System.Windows.Forms.TextBox
        Me.txtRepeticiones = New System.Windows.Forms.TextBox
        Me.lblSesion = New System.Windows.Forms.Label
        Me.lblCantidad = New System.Windows.Forms.Label
        Me.lblKcal = New System.Windows.Forms.Label
        Me.lblCarga = New System.Windows.Forms.Label
        Me.lblRepeticiones = New System.Windows.Forms.Label
        Me.lblModo = New System.Windows.Forms.Label
        Me.cmbSesion = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'lstSerie
        '
        Me.lstSerie.FormattingEnabled = True
        Me.lstSerie.Location = New System.Drawing.Point(12, 52)
        Me.lstSerie.Name = "lstSerie"
        Me.lstSerie.Size = New System.Drawing.Size(120, 160)
        Me.lstSerie.TabIndex = 0
        '
        'rbnCombo
        '
        Me.rbnCombo.AutoSize = True
        Me.rbnCombo.Location = New System.Drawing.Point(12, 12)
        Me.rbnCombo.Name = "rbnCombo"
        Me.rbnCombo.Size = New System.Drawing.Size(58, 17)
        Me.rbnCombo.TabIndex = 1
        Me.rbnCombo.TabStop = True
        Me.rbnCombo.Text = "Combo"
        Me.rbnCombo.UseVisualStyleBackColor = True
        '
        'rbnEjercicio
        '
        Me.rbnEjercicio.AutoSize = True
        Me.rbnEjercicio.Location = New System.Drawing.Point(12, 29)
        Me.rbnEjercicio.Name = "rbnEjercicio"
        Me.rbnEjercicio.Size = New System.Drawing.Size(65, 17)
        Me.rbnEjercicio.TabIndex = 2
        Me.rbnEjercicio.TabStop = True
        Me.rbnEjercicio.Text = "Ejercicio"
        Me.rbnEjercicio.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.SIGEN.My.Resources.Resources.cancel
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(138, 181)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(105, 30)
        Me.btnCancelar.TabIndex = 101
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = Global.SIGEN.My.Resources.Resources.ok1
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.Location = New System.Drawing.Point(248, 181)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(105, 30)
        Me.btnGuardar.TabIndex = 100
        Me.btnGuardar.Text = "Agregar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(232, 38)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(121, 20)
        Me.txtCantidad.TabIndex = 103
        '
        'txtKcal
        '
        Me.txtKcal.Location = New System.Drawing.Point(232, 64)
        Me.txtKcal.Name = "txtKcal"
        Me.txtKcal.Size = New System.Drawing.Size(121, 20)
        Me.txtKcal.TabIndex = 104
        '
        'txtCarga
        '
        Me.txtCarga.Location = New System.Drawing.Point(232, 90)
        Me.txtCarga.Name = "txtCarga"
        Me.txtCarga.Size = New System.Drawing.Size(121, 20)
        Me.txtCarga.TabIndex = 105
        '
        'txtModo
        '
        Me.txtModo.Location = New System.Drawing.Point(232, 142)
        Me.txtModo.Name = "txtModo"
        Me.txtModo.Size = New System.Drawing.Size(121, 20)
        Me.txtModo.TabIndex = 107
        '
        'txtRepeticiones
        '
        Me.txtRepeticiones.Location = New System.Drawing.Point(232, 116)
        Me.txtRepeticiones.Name = "txtRepeticiones"
        Me.txtRepeticiones.Size = New System.Drawing.Size(121, 20)
        Me.txtRepeticiones.TabIndex = 106
        '
        'lblSesion
        '
        Me.lblSesion.AutoSize = True
        Me.lblSesion.Location = New System.Drawing.Point(135, 15)
        Me.lblSesion.Name = "lblSesion"
        Me.lblSesion.Size = New System.Drawing.Size(42, 13)
        Me.lblSesion.TabIndex = 108
        Me.lblSesion.Text = "Sesion:"
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(135, 41)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(52, 13)
        Me.lblCantidad.TabIndex = 109
        Me.lblCantidad.Text = "Cantidad:"
        '
        'lblKcal
        '
        Me.lblKcal.AutoSize = True
        Me.lblKcal.Location = New System.Drawing.Point(135, 67)
        Me.lblKcal.Name = "lblKcal"
        Me.lblKcal.Size = New System.Drawing.Size(85, 13)
        Me.lblKcal.TabIndex = 110
        Me.lblKcal.Text = "Kcal Quemadas:"
        '
        'lblCarga
        '
        Me.lblCarga.AutoSize = True
        Me.lblCarga.Location = New System.Drawing.Point(135, 93)
        Me.lblCarga.Name = "lblCarga"
        Me.lblCarga.Size = New System.Drawing.Size(38, 13)
        Me.lblCarga.TabIndex = 111
        Me.lblCarga.Text = "Carga:"
        '
        'lblRepeticiones
        '
        Me.lblRepeticiones.AutoSize = True
        Me.lblRepeticiones.Location = New System.Drawing.Point(135, 119)
        Me.lblRepeticiones.Name = "lblRepeticiones"
        Me.lblRepeticiones.Size = New System.Drawing.Size(72, 13)
        Me.lblRepeticiones.TabIndex = 112
        Me.lblRepeticiones.Text = "Repeticiones:"
        '
        'lblModo
        '
        Me.lblModo.AutoSize = True
        Me.lblModo.Location = New System.Drawing.Point(135, 145)
        Me.lblModo.Name = "lblModo"
        Me.lblModo.Size = New System.Drawing.Size(37, 13)
        Me.lblModo.TabIndex = 113
        Me.lblModo.Text = "Modo:"
        '
        'cmbSesion
        '
        Me.cmbSesion.FormattingEnabled = True
        Me.cmbSesion.Location = New System.Drawing.Point(232, 11)
        Me.cmbSesion.Name = "cmbSesion"
        Me.cmbSesion.Size = New System.Drawing.Size(121, 21)
        Me.cmbSesion.TabIndex = 114
        '
        'FrmSerie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 223)
        Me.Controls.Add(Me.cmbSesion)
        Me.Controls.Add(Me.lblModo)
        Me.Controls.Add(Me.lblRepeticiones)
        Me.Controls.Add(Me.lblCarga)
        Me.Controls.Add(Me.lblKcal)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.lblSesion)
        Me.Controls.Add(Me.txtModo)
        Me.Controls.Add(Me.txtRepeticiones)
        Me.Controls.Add(Me.txtCarga)
        Me.Controls.Add(Me.txtKcal)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.rbnEjercicio)
        Me.Controls.Add(Me.rbnCombo)
        Me.Controls.Add(Me.lstSerie)
        Me.Name = "FrmSerie"
        Me.Text = "Serie"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstSerie As System.Windows.Forms.ListBox
    Friend WithEvents rbnCombo As System.Windows.Forms.RadioButton
    Friend WithEvents rbnEjercicio As System.Windows.Forms.RadioButton
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents txtKcal As System.Windows.Forms.TextBox
    Friend WithEvents txtCarga As System.Windows.Forms.TextBox
    Friend WithEvents txtModo As System.Windows.Forms.TextBox
    Friend WithEvents txtRepeticiones As System.Windows.Forms.TextBox
    Friend WithEvents lblSesion As System.Windows.Forms.Label
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents lblKcal As System.Windows.Forms.Label
    Friend WithEvents lblCarga As System.Windows.Forms.Label
    Friend WithEvents lblRepeticiones As System.Windows.Forms.Label
    Friend WithEvents lblModo As System.Windows.Forms.Label
    Friend WithEvents cmbSesion As System.Windows.Forms.ComboBox
End Class
