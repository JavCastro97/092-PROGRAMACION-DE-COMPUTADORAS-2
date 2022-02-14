<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBoxTransaccion = New System.Windows.Forms.GroupBox()
        Me.CheckBoxVenta = New System.Windows.Forms.CheckBox()
        Me.CheckBoxCompra = New System.Windows.Forms.CheckBox()
        Me.GroupBoxCantidad = New System.Windows.Forms.GroupBox()
        Me.TextBoxVenta = New System.Windows.Forms.TextBox()
        Me.TextBoxCompra = New System.Windows.Forms.TextBox()
        Me.LabelVenta = New System.Windows.Forms.Label()
        Me.LabelCompra = New System.Windows.Forms.Label()
        Me.GroupBoxBotones = New System.Windows.Forms.GroupBox()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.ButtonLimpiar = New System.Windows.Forms.Button()
        Me.ButtonCalcular = New System.Windows.Forms.Button()
        Me.GroupBoxCompra = New System.Windows.Forms.GroupBox()
        Me.RBCColon = New System.Windows.Forms.RadioButton()
        Me.RBCEuro = New System.Windows.Forms.RadioButton()
        Me.RBCPeso = New System.Windows.Forms.RadioButton()
        Me.RBCDolar = New System.Windows.Forms.RadioButton()
        Me.GroupBoxVenta = New System.Windows.Forms.GroupBox()
        Me.RBVColon = New System.Windows.Forms.RadioButton()
        Me.RBVEuro = New System.Windows.Forms.RadioButton()
        Me.RBVPeso = New System.Windows.Forms.RadioButton()
        Me.RBVDolar = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBoxTransaccion.SuspendLayout()
        Me.GroupBoxCantidad.SuspendLayout()
        Me.GroupBoxBotones.SuspendLayout()
        Me.GroupBoxCompra.SuspendLayout()
        Me.GroupBoxVenta.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxTransaccion
        '
        Me.GroupBoxTransaccion.Controls.Add(Me.CheckBoxVenta)
        Me.GroupBoxTransaccion.Controls.Add(Me.CheckBoxCompra)
        Me.GroupBoxTransaccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxTransaccion.ForeColor = System.Drawing.Color.Black
        Me.GroupBoxTransaccion.Location = New System.Drawing.Point(21, 55)
        Me.GroupBoxTransaccion.Name = "GroupBoxTransaccion"
        Me.GroupBoxTransaccion.Size = New System.Drawing.Size(159, 135)
        Me.GroupBoxTransaccion.TabIndex = 0
        Me.GroupBoxTransaccion.TabStop = False
        Me.GroupBoxTransaccion.Text = "Seleccione el tipo de transacción:"
        '
        'CheckBoxVenta
        '
        Me.CheckBoxVenta.AutoSize = True
        Me.CheckBoxVenta.Location = New System.Drawing.Point(25, 89)
        Me.CheckBoxVenta.Name = "CheckBoxVenta"
        Me.CheckBoxVenta.Size = New System.Drawing.Size(66, 20)
        Me.CheckBoxVenta.TabIndex = 1
        Me.CheckBoxVenta.Text = "Venta"
        Me.CheckBoxVenta.UseVisualStyleBackColor = True
        '
        'CheckBoxCompra
        '
        Me.CheckBoxCompra.AutoSize = True
        Me.CheckBoxCompra.Location = New System.Drawing.Point(25, 44)
        Me.CheckBoxCompra.Name = "CheckBoxCompra"
        Me.CheckBoxCompra.Size = New System.Drawing.Size(80, 20)
        Me.CheckBoxCompra.TabIndex = 0
        Me.CheckBoxCompra.Text = "Compra"
        Me.CheckBoxCompra.UseVisualStyleBackColor = True
        '
        'GroupBoxCantidad
        '
        Me.GroupBoxCantidad.Controls.Add(Me.TextBoxVenta)
        Me.GroupBoxCantidad.Controls.Add(Me.TextBoxCompra)
        Me.GroupBoxCantidad.Controls.Add(Me.LabelVenta)
        Me.GroupBoxCantidad.Controls.Add(Me.LabelCompra)
        Me.GroupBoxCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxCantidad.ForeColor = System.Drawing.Color.Black
        Me.GroupBoxCantidad.Location = New System.Drawing.Point(212, 55)
        Me.GroupBoxCantidad.Name = "GroupBoxCantidad"
        Me.GroupBoxCantidad.Size = New System.Drawing.Size(280, 135)
        Me.GroupBoxCantidad.TabIndex = 1
        Me.GroupBoxCantidad.TabStop = False
        Me.GroupBoxCantidad.Text = "Ingrese la cantidad en quetzales que desea operar:"
        '
        'TextBoxVenta
        '
        Me.TextBoxVenta.Enabled = False
        Me.TextBoxVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxVenta.Location = New System.Drawing.Point(122, 84)
        Me.TextBoxVenta.Name = "TextBoxVenta"
        Me.TextBoxVenta.Size = New System.Drawing.Size(121, 22)
        Me.TextBoxVenta.TabIndex = 3
        '
        'TextBoxCompra
        '
        Me.TextBoxCompra.Enabled = False
        Me.TextBoxCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCompra.Location = New System.Drawing.Point(122, 38)
        Me.TextBoxCompra.Name = "TextBoxCompra"
        Me.TextBoxCompra.Size = New System.Drawing.Size(121, 22)
        Me.TextBoxCompra.TabIndex = 2
        '
        'LabelVenta
        '
        Me.LabelVenta.AutoSize = True
        Me.LabelVenta.Location = New System.Drawing.Point(32, 90)
        Me.LabelVenta.Name = "LabelVenta"
        Me.LabelVenta.Size = New System.Drawing.Size(72, 16)
        Me.LabelVenta.TabIndex = 1
        Me.LabelVenta.Text = "Venta (Q)"
        '
        'LabelCompra
        '
        Me.LabelCompra.AutoSize = True
        Me.LabelCompra.Location = New System.Drawing.Point(32, 44)
        Me.LabelCompra.Name = "LabelCompra"
        Me.LabelCompra.Size = New System.Drawing.Size(86, 16)
        Me.LabelCompra.TabIndex = 0
        Me.LabelCompra.Text = "Compra (Q)"
        '
        'GroupBoxBotones
        '
        Me.GroupBoxBotones.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBoxBotones.Controls.Add(Me.ButtonSalir)
        Me.GroupBoxBotones.Controls.Add(Me.ButtonLimpiar)
        Me.GroupBoxBotones.Controls.Add(Me.ButtonCalcular)
        Me.GroupBoxBotones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxBotones.Location = New System.Drawing.Point(540, 55)
        Me.GroupBoxBotones.Name = "GroupBoxBotones"
        Me.GroupBoxBotones.Size = New System.Drawing.Size(200, 165)
        Me.GroupBoxBotones.TabIndex = 2
        Me.GroupBoxBotones.TabStop = False
        Me.GroupBoxBotones.Text = "Opciones"
        '
        'ButtonSalir
        '
        Me.ButtonSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonSalir.ForeColor = System.Drawing.Color.White
        Me.ButtonSalir.Location = New System.Drawing.Point(49, 127)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(100, 23)
        Me.ButtonSalir.TabIndex = 2
        Me.ButtonSalir.Text = "SALIR"
        Me.ButtonSalir.UseVisualStyleBackColor = False
        '
        'ButtonLimpiar
        '
        Me.ButtonLimpiar.BackColor = System.Drawing.Color.Navy
        Me.ButtonLimpiar.ForeColor = System.Drawing.Color.White
        Me.ButtonLimpiar.Location = New System.Drawing.Point(49, 83)
        Me.ButtonLimpiar.Name = "ButtonLimpiar"
        Me.ButtonLimpiar.Size = New System.Drawing.Size(100, 23)
        Me.ButtonLimpiar.TabIndex = 1
        Me.ButtonLimpiar.Text = "LIMPIAR"
        Me.ButtonLimpiar.UseVisualStyleBackColor = False
        '
        'ButtonCalcular
        '
        Me.ButtonCalcular.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonCalcular.ForeColor = System.Drawing.Color.White
        Me.ButtonCalcular.Location = New System.Drawing.Point(49, 37)
        Me.ButtonCalcular.Name = "ButtonCalcular"
        Me.ButtonCalcular.Size = New System.Drawing.Size(100, 23)
        Me.ButtonCalcular.TabIndex = 0
        Me.ButtonCalcular.Text = "CALCULAR"
        Me.ButtonCalcular.UseVisualStyleBackColor = False
        '
        'GroupBoxCompra
        '
        Me.GroupBoxCompra.Controls.Add(Me.RBCColon)
        Me.GroupBoxCompra.Controls.Add(Me.RBCEuro)
        Me.GroupBoxCompra.Controls.Add(Me.RBCPeso)
        Me.GroupBoxCompra.Controls.Add(Me.RBCDolar)
        Me.GroupBoxCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxCompra.Location = New System.Drawing.Point(21, 215)
        Me.GroupBoxCompra.Name = "GroupBoxCompra"
        Me.GroupBoxCompra.Size = New System.Drawing.Size(192, 223)
        Me.GroupBoxCompra.TabIndex = 3
        Me.GroupBoxCompra.TabStop = False
        Me.GroupBoxCompra.Text = "Moneda de Compra"
        Me.GroupBoxCompra.Visible = False
        '
        'RBCColon
        '
        Me.RBCColon.AutoSize = True
        Me.RBCColon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBCColon.Location = New System.Drawing.Point(22, 173)
        Me.RBCColon.Name = "RBCColon"
        Me.RBCColon.Size = New System.Drawing.Size(80, 20)
        Me.RBCColon.TabIndex = 3
        Me.RBCColon.TabStop = True
        Me.RBCColon.Text = "Colón (₡)"
        Me.RBCColon.UseVisualStyleBackColor = True
        '
        'RBCEuro
        '
        Me.RBCEuro.AutoSize = True
        Me.RBCEuro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBCEuro.Location = New System.Drawing.Point(22, 128)
        Me.RBCEuro.Name = "RBCEuro"
        Me.RBCEuro.Size = New System.Drawing.Size(71, 20)
        Me.RBCEuro.TabIndex = 2
        Me.RBCEuro.TabStop = True
        Me.RBCEuro.Text = "Euro (€)"
        Me.RBCEuro.UseVisualStyleBackColor = True
        '
        'RBCPeso
        '
        Me.RBCPeso.AutoSize = True
        Me.RBCPeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBCPeso.Location = New System.Drawing.Point(22, 86)
        Me.RBCPeso.Name = "RBCPeso"
        Me.RBCPeso.Size = New System.Drawing.Size(136, 20)
        Me.RBCPeso.TabIndex = 1
        Me.RBCPeso.TabStop = True
        Me.RBCPeso.Text = "Peso mexicano ($)"
        Me.RBCPeso.UseVisualStyleBackColor = True
        '
        'RBCDolar
        '
        Me.RBCDolar.AutoSize = True
        Me.RBCDolar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBCDolar.Location = New System.Drawing.Point(22, 48)
        Me.RBCDolar.Name = "RBCDolar"
        Me.RBCDolar.Size = New System.Drawing.Size(76, 20)
        Me.RBCDolar.TabIndex = 0
        Me.RBCDolar.TabStop = True
        Me.RBCDolar.Text = "Dólar ($)"
        Me.RBCDolar.UseVisualStyleBackColor = True
        '
        'GroupBoxVenta
        '
        Me.GroupBoxVenta.Controls.Add(Me.RBVColon)
        Me.GroupBoxVenta.Controls.Add(Me.RBVEuro)
        Me.GroupBoxVenta.Controls.Add(Me.RBVPeso)
        Me.GroupBoxVenta.Controls.Add(Me.RBVDolar)
        Me.GroupBoxVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxVenta.Location = New System.Drawing.Point(247, 215)
        Me.GroupBoxVenta.Name = "GroupBoxVenta"
        Me.GroupBoxVenta.Size = New System.Drawing.Size(192, 223)
        Me.GroupBoxVenta.TabIndex = 4
        Me.GroupBoxVenta.TabStop = False
        Me.GroupBoxVenta.Text = "Moneda de Venta"
        Me.GroupBoxVenta.Visible = False
        '
        'RBVColon
        '
        Me.RBVColon.AutoSize = True
        Me.RBVColon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBVColon.Location = New System.Drawing.Point(22, 173)
        Me.RBVColon.Name = "RBVColon"
        Me.RBVColon.Size = New System.Drawing.Size(80, 20)
        Me.RBVColon.TabIndex = 3
        Me.RBVColon.TabStop = True
        Me.RBVColon.Text = "Colón (₡)"
        Me.RBVColon.UseVisualStyleBackColor = True
        '
        'RBVEuro
        '
        Me.RBVEuro.AutoSize = True
        Me.RBVEuro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBVEuro.Location = New System.Drawing.Point(22, 128)
        Me.RBVEuro.Name = "RBVEuro"
        Me.RBVEuro.Size = New System.Drawing.Size(71, 20)
        Me.RBVEuro.TabIndex = 2
        Me.RBVEuro.TabStop = True
        Me.RBVEuro.Text = "Euro (€)"
        Me.RBVEuro.UseVisualStyleBackColor = True
        '
        'RBVPeso
        '
        Me.RBVPeso.AutoSize = True
        Me.RBVPeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBVPeso.Location = New System.Drawing.Point(22, 86)
        Me.RBVPeso.Name = "RBVPeso"
        Me.RBVPeso.Size = New System.Drawing.Size(136, 20)
        Me.RBVPeso.TabIndex = 1
        Me.RBVPeso.TabStop = True
        Me.RBVPeso.Text = "Peso mexicano ($)"
        Me.RBVPeso.UseVisualStyleBackColor = True
        '
        'RBVDolar
        '
        Me.RBVDolar.AutoSize = True
        Me.RBVDolar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBVDolar.Location = New System.Drawing.Point(22, 48)
        Me.RBVDolar.Name = "RBVDolar"
        Me.RBVDolar.Size = New System.Drawing.Size(76, 20)
        Me.RBVDolar.TabIndex = 0
        Me.RBVDolar.TabStop = True
        Me.RBVDolar.Text = "Dólar ($)"
        Me.RBVDolar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global._201602920_CASACAMBIOS.My.Resources.Resources._1200x630bb
        Me.PictureBox1.Location = New System.Drawing.Point(540, 226)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 146)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Barlow Condensed SemiBold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(471, 388)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(280, 36)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "CASA DE MONEDA DE CAMBIO"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBoxVenta)
        Me.Controls.Add(Me.GroupBoxCompra)
        Me.Controls.Add(Me.GroupBoxBotones)
        Me.Controls.Add(Me.GroupBoxCantidad)
        Me.Controls.Add(Me.GroupBoxTransaccion)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBoxTransaccion.ResumeLayout(False)
        Me.GroupBoxTransaccion.PerformLayout()
        Me.GroupBoxCantidad.ResumeLayout(False)
        Me.GroupBoxCantidad.PerformLayout()
        Me.GroupBoxBotones.ResumeLayout(False)
        Me.GroupBoxCompra.ResumeLayout(False)
        Me.GroupBoxCompra.PerformLayout()
        Me.GroupBoxVenta.ResumeLayout(False)
        Me.GroupBoxVenta.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBoxTransaccion As GroupBox
    Friend WithEvents CheckBoxVenta As CheckBox
    Friend WithEvents CheckBoxCompra As CheckBox
    Friend WithEvents GroupBoxCantidad As GroupBox
    Friend WithEvents TextBoxVenta As TextBox
    Friend WithEvents TextBoxCompra As TextBox
    Friend WithEvents LabelVenta As Label
    Friend WithEvents LabelCompra As Label
    Friend WithEvents GroupBoxBotones As GroupBox
    Friend WithEvents ButtonSalir As Button
    Friend WithEvents ButtonLimpiar As Button
    Friend WithEvents ButtonCalcular As Button
    Friend WithEvents GroupBoxCompra As GroupBox
    Friend WithEvents RBCColon As RadioButton
    Friend WithEvents RBCEuro As RadioButton
    Friend WithEvents RBCPeso As RadioButton
    Friend WithEvents RBCDolar As RadioButton
    Friend WithEvents GroupBoxVenta As GroupBox
    Friend WithEvents RBVColon As RadioButton
    Friend WithEvents RBVEuro As RadioButton
    Friend WithEvents RBVPeso As RadioButton
    Friend WithEvents RBVDolar As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
