<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenuSeleccionador
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
        Me.btnEquipos = New System.Windows.Forms.Button
        Me.btnPerfil = New System.Windows.Forms.Button
        Me.btnEntrenadores = New System.Windows.Forms.Button
        Me.btningles = New System.Windows.Forms.Button
        Me.btnInstituto = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnSectores = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnEquipos
        '
        Me.btnEquipos.Location = New System.Drawing.Point(12, 53)
        Me.btnEquipos.Name = "btnEquipos"
        Me.btnEquipos.Size = New System.Drawing.Size(260, 35)
        Me.btnEquipos.TabIndex = 2
        Me.btnEquipos.Text = "Equipos"
        Me.btnEquipos.UseVisualStyleBackColor = True
        '
        'btnPerfil
        '
        Me.btnPerfil.Location = New System.Drawing.Point(12, 12)
        Me.btnPerfil.Name = "btnPerfil"
        Me.btnPerfil.Size = New System.Drawing.Size(260, 35)
        Me.btnPerfil.TabIndex = 1
        Me.btnPerfil.Text = "Perfil"
        Me.btnPerfil.UseVisualStyleBackColor = True
        '
        'btnEntrenadores
        '
        Me.btnEntrenadores.Location = New System.Drawing.Point(12, 94)
        Me.btnEntrenadores.Name = "btnEntrenadores"
        Me.btnEntrenadores.Size = New System.Drawing.Size(260, 35)
        Me.btnEntrenadores.TabIndex = 3
        Me.btnEntrenadores.Text = "Entrenadores"
        Me.btnEntrenadores.UseVisualStyleBackColor = True
        '
        'btningles
        '
        Me.btningles.Location = New System.Drawing.Point(818, 30)
        Me.btningles.Name = "btningles"
        Me.btningles.Size = New System.Drawing.Size(75, 23)
        Me.btningles.TabIndex = 125
        Me.btningles.Text = "English"
        Me.btningles.UseVisualStyleBackColor = True
        '
        'btnInstituto
        '
        Me.btnInstituto.Location = New System.Drawing.Point(12, 135)
        Me.btnInstituto.Name = "btnInstituto"
        Me.btnInstituto.Size = New System.Drawing.Size(260, 35)
        Me.btnInstituto.TabIndex = 4
        Me.btnInstituto.Text = "Institutos"
        Me.btnInstituto.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Image = Global.SIGEN.My.Resources.Resources.exit2
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(12, 314)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(260, 35)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnSectores
        '
        Me.btnSectores.Location = New System.Drawing.Point(12, 176)
        Me.btnSectores.Name = "btnSectores"
        Me.btnSectores.Size = New System.Drawing.Size(260, 35)
        Me.btnSectores.TabIndex = 5
        Me.btnSectores.Text = "Sectores"
        Me.btnSectores.UseVisualStyleBackColor = True
        '
        'FrmMenuSeleccionador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(284, 361)
        Me.Controls.Add(Me.btnSectores)
        Me.Controls.Add(Me.btnInstituto)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btningles)
        Me.Controls.Add(Me.btnEntrenadores)
        Me.Controls.Add(Me.btnEquipos)
        Me.Controls.Add(Me.btnPerfil)
        Me.Name = "FrmMenuSeleccionador"
        Me.Text = "Menú"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnEquipos As System.Windows.Forms.Button
    Friend WithEvents btnPerfil As System.Windows.Forms.Button
    Friend WithEvents btnEntrenadores As System.Windows.Forms.Button
    Friend WithEvents btningles As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnInstituto As System.Windows.Forms.Button
    Friend WithEvents btnSectores As System.Windows.Forms.Button

End Class
