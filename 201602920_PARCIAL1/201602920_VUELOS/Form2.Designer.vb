<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TBTotal = New System.Windows.Forms.TextBox()
        Me.TBDescuento = New System.Windows.Forms.TextBox()
        Me.TBSubtotal = New System.Windows.Forms.TextBox()
        Me.LabelTOTAL = New System.Windows.Forms.Label()
        Me.LabelDescuento = New System.Windows.Forms.Label()
        Me.LabelSubtotal = New System.Windows.Forms.Label()
        Me.ButtonRegresar = New System.Windows.Forms.Button()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TBTotal)
        Me.GroupBox1.Controls.Add(Me.TBDescuento)
        Me.GroupBox1.Controls.Add(Me.TBSubtotal)
        Me.GroupBox1.Controls.Add(Me.LabelTOTAL)
        Me.GroupBox1.Controls.Add(Me.LabelDescuento)
        Me.GroupBox1.Controls.Add(Me.LabelSubtotal)
        Me.GroupBox1.Location = New System.Drawing.Point(40, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(483, 163)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "RESULTADOS"
        '
        'TBTotal
        '
        Me.TBTotal.Enabled = False
        Me.TBTotal.Location = New System.Drawing.Point(190, 126)
        Me.TBTotal.Name = "TBTotal"
        Me.TBTotal.Size = New System.Drawing.Size(100, 20)
        Me.TBTotal.TabIndex = 5
        Me.TBTotal.Text = "0.00"
        Me.TBTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TBDescuento
        '
        Me.TBDescuento.Enabled = False
        Me.TBDescuento.Location = New System.Drawing.Point(190, 83)
        Me.TBDescuento.Name = "TBDescuento"
        Me.TBDescuento.Size = New System.Drawing.Size(100, 20)
        Me.TBDescuento.TabIndex = 4
        Me.TBDescuento.Text = "0.00"
        Me.TBDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TBSubtotal
        '
        Me.TBSubtotal.Enabled = False
        Me.TBSubtotal.Location = New System.Drawing.Point(190, 44)
        Me.TBSubtotal.Name = "TBSubtotal"
        Me.TBSubtotal.Size = New System.Drawing.Size(100, 20)
        Me.TBSubtotal.TabIndex = 3
        Me.TBSubtotal.Text = "0.00"
        Me.TBSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelTOTAL
        '
        Me.LabelTOTAL.AutoSize = True
        Me.LabelTOTAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTOTAL.Location = New System.Drawing.Point(39, 126)
        Me.LabelTOTAL.Name = "LabelTOTAL"
        Me.LabelTOTAL.Size = New System.Drawing.Size(59, 20)
        Me.LabelTOTAL.TabIndex = 2
        Me.LabelTOTAL.Text = "TOTAL"
        '
        'LabelDescuento
        '
        Me.LabelDescuento.AutoSize = True
        Me.LabelDescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDescuento.Location = New System.Drawing.Point(39, 83)
        Me.LabelDescuento.Name = "LabelDescuento"
        Me.LabelDescuento.Size = New System.Drawing.Size(87, 20)
        Me.LabelDescuento.TabIndex = 1
        Me.LabelDescuento.Text = "Descuento"
        '
        'LabelSubtotal
        '
        Me.LabelSubtotal.AutoSize = True
        Me.LabelSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSubtotal.Location = New System.Drawing.Point(39, 44)
        Me.LabelSubtotal.Name = "LabelSubtotal"
        Me.LabelSubtotal.Size = New System.Drawing.Size(69, 20)
        Me.LabelSubtotal.TabIndex = 0
        Me.LabelSubtotal.Text = "Subtotal"
        '
        'ButtonRegresar
        '
        Me.ButtonRegresar.Location = New System.Drawing.Point(171, 248)
        Me.ButtonRegresar.Name = "ButtonRegresar"
        Me.ButtonRegresar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRegresar.TabIndex = 1
        Me.ButtonRegresar.Text = "REGRESAR"
        Me.ButtonRegresar.UseVisualStyleBackColor = True
        '
        'ButtonSalir
        '
        Me.ButtonSalir.Location = New System.Drawing.Point(283, 248)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSalir.TabIndex = 2
        Me.ButtonSalir.Text = "SALIR"
        Me.ButtonSalir.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._201602920_VUELOS.My.Resources.Resources.banner_de_fondo_mínimo_para_viajes_modelo_avión_en_vuelo_un_color_vacío_copiar_espacio_170421780
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(835, 290)
        Me.Controls.Add(Me.ButtonSalir)
        Me.Controls.Add(Me.ButtonRegresar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form2"
        Me.Text = "Form 2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TBTotal As TextBox
    Friend WithEvents TBDescuento As TextBox
    Friend WithEvents TBSubtotal As TextBox
    Friend WithEvents LabelTOTAL As Label
    Friend WithEvents LabelDescuento As Label
    Friend WithEvents LabelSubtotal As Label
    Friend WithEvents ButtonRegresar As Button
    Friend WithEvents ButtonSalir As Button
End Class
