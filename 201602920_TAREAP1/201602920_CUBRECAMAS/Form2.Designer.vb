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
        Me.TextBoxVentaUnitaria = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxPrecioVenta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxCostoUnitario = New System.Windows.Forms.TextBox()
        Me.TextBoxPrecioCosto = New System.Windows.Forms.TextBox()
        Me.LabelPVenta = New System.Windows.Forms.Label()
        Me.LabelPCosto = New System.Windows.Forms.Label()
        Me.ButtonRegresar = New System.Windows.Forms.Button()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.TextBoxVentaUnitaria)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBoxPrecioVenta)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBoxCostoUnitario)
        Me.GroupBox1.Controls.Add(Me.TextBoxPrecioCosto)
        Me.GroupBox1.Controls.Add(Me.LabelPVenta)
        Me.GroupBox1.Controls.Add(Me.LabelPCosto)
        Me.GroupBox1.Font = New System.Drawing.Font("Montserrat SemiBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(678, 140)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "RESULTADOS"
        '
        'TextBoxVentaUnitaria
        '
        Me.TextBoxVentaUnitaria.Enabled = False
        Me.TextBoxVentaUnitaria.Location = New System.Drawing.Point(523, 41)
        Me.TextBoxVentaUnitaria.Name = "TextBoxVentaUnitaria"
        Me.TextBoxVentaUnitaria.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxVentaUnitaria.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(342, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "PRECIO DE VENTA TOTAL"
        '
        'TextBoxPrecioVenta
        '
        Me.TextBoxPrecioVenta.Enabled = False
        Me.TextBoxPrecioVenta.Location = New System.Drawing.Point(523, 87)
        Me.TextBoxPrecioVenta.Name = "TextBoxPrecioVenta"
        Me.TextBoxPrecioVenta.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxPrecioVenta.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(34, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "PRECIO DE COSTO TOTAL"
        '
        'TextBoxCostoUnitario
        '
        Me.TextBoxCostoUnitario.Enabled = False
        Me.TextBoxCostoUnitario.Location = New System.Drawing.Point(224, 41)
        Me.TextBoxCostoUnitario.Name = "TextBoxCostoUnitario"
        Me.TextBoxCostoUnitario.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxCostoUnitario.TabIndex = 3
        '
        'TextBoxPrecioCosto
        '
        Me.TextBoxPrecioCosto.Enabled = False
        Me.TextBoxPrecioCosto.Location = New System.Drawing.Point(224, 87)
        Me.TextBoxPrecioCosto.Name = "TextBoxPrecioCosto"
        Me.TextBoxPrecioCosto.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxPrecioCosto.TabIndex = 2
        '
        'LabelPVenta
        '
        Me.LabelPVenta.AutoSize = True
        Me.LabelPVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPVenta.ForeColor = System.Drawing.Color.Green
        Me.LabelPVenta.Location = New System.Drawing.Point(342, 41)
        Me.LabelPVenta.Name = "LabelPVenta"
        Me.LabelPVenta.Size = New System.Drawing.Size(170, 15)
        Me.LabelPVenta.TabIndex = 1
        Me.LabelPVenta.Text = "PRECIO DE VENTA UNITARIA"
        '
        'LabelPCosto
        '
        Me.LabelPCosto.AutoSize = True
        Me.LabelPCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPCosto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelPCosto.Location = New System.Drawing.Point(34, 41)
        Me.LabelPCosto.Name = "LabelPCosto"
        Me.LabelPCosto.Size = New System.Drawing.Size(175, 15)
        Me.LabelPCosto.TabIndex = 0
        Me.LabelPCosto.Text = "PRECIO DE COSTO UNITARIO"
        '
        'ButtonRegresar
        '
        Me.ButtonRegresar.BackColor = System.Drawing.Color.Navy
        Me.ButtonRegresar.ForeColor = System.Drawing.SystemColors.Control
        Me.ButtonRegresar.Location = New System.Drawing.Point(261, 175)
        Me.ButtonRegresar.Name = "ButtonRegresar"
        Me.ButtonRegresar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRegresar.TabIndex = 1
        Me.ButtonRegresar.Text = "REGRESAR"
        Me.ButtonRegresar.UseVisualStyleBackColor = False
        '
        'ButtonSalir
        '
        Me.ButtonSalir.BackColor = System.Drawing.Color.Navy
        Me.ButtonSalir.ForeColor = System.Drawing.SystemColors.Control
        Me.ButtonSalir.Location = New System.Drawing.Point(357, 175)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSalir.TabIndex = 2
        Me.ButtonSalir.Text = "SALIR"
        Me.ButtonSalir.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.BackgroundImage = Global._201602920_CUBRECAMAS.My.Resources.Resources.abstract_black_background_Design_HD_Wallpaper_2560x1600
        Me.ClientSize = New System.Drawing.Size(704, 210)
        Me.Controls.Add(Me.ButtonSalir)
        Me.Controls.Add(Me.ButtonRegresar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBoxPrecioVenta As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxCostoUnitario As TextBox
    Friend WithEvents TextBoxPrecioCosto As TextBox
    Friend WithEvents LabelPVenta As Label
    Friend WithEvents LabelPCosto As Label
    Friend WithEvents TextBoxVentaUnitaria As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonRegresar As Button
    Friend WithEvents ButtonSalir As Button
End Class
