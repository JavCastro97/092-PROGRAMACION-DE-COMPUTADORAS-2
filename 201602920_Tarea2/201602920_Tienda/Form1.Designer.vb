<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBoxAzucar = New System.Windows.Forms.TextBox()
        Me.TextBoxFrijol = New System.Windows.Forms.TextBox()
        Me.TextBoxArroz = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LabelR5 = New System.Windows.Forms.Label()
        Me.LabelR4 = New System.Windows.Forms.Label()
        Me.LabelR3 = New System.Windows.Forms.Label()
        Me.LabelR2 = New System.Windows.Forms.Label()
        Me.LabelR1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BotonSalir = New System.Windows.Forms.Button()
        Me.BotonLimpiar = New System.Windows.Forms.Button()
        Me.BotonAceptar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat Light", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Libras de Arroz"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat Light", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Libras de Frijol"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat Light", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Libras de Azucar"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.TextBoxAzucar)
        Me.GroupBox1.Controls.Add(Me.TextBoxFrijol)
        Me.GroupBox1.Controls.Add(Me.TextBoxArroz)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(30, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(317, 160)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Ingreso"
        '
        'TextBoxAzucar
        '
        Me.TextBoxAzucar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAzucar.Location = New System.Drawing.Point(179, 114)
        Me.TextBoxAzucar.Name = "TextBoxAzucar"
        Me.TextBoxAzucar.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxAzucar.TabIndex = 5
        '
        'TextBoxFrijol
        '
        Me.TextBoxFrijol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxFrijol.Location = New System.Drawing.Point(179, 72)
        Me.TextBoxFrijol.Name = "TextBoxFrijol"
        Me.TextBoxFrijol.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxFrijol.TabIndex = 4
        '
        'TextBoxArroz
        '
        Me.TextBoxArroz.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxArroz.Location = New System.Drawing.Point(179, 31)
        Me.TextBoxArroz.Name = "TextBoxArroz"
        Me.TextBoxArroz.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxArroz.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.LabelR5)
        Me.GroupBox2.Controls.Add(Me.LabelR4)
        Me.GroupBox2.Controls.Add(Me.LabelR3)
        Me.GroupBox2.Controls.Add(Me.LabelR2)
        Me.GroupBox2.Controls.Add(Me.LabelR1)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(32, 196)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(315, 257)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultados en Quetzales (Q)"
        '
        'LabelR5
        '
        Me.LabelR5.AutoSize = True
        Me.LabelR5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelR5.Location = New System.Drawing.Point(214, 213)
        Me.LabelR5.Name = "LabelR5"
        Me.LabelR5.Size = New System.Drawing.Size(44, 20)
        Me.LabelR5.TabIndex = 9
        Me.LabelR5.Text = "0.00"
        '
        'LabelR4
        '
        Me.LabelR4.AutoSize = True
        Me.LabelR4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelR4.Location = New System.Drawing.Point(214, 172)
        Me.LabelR4.Name = "LabelR4"
        Me.LabelR4.Size = New System.Drawing.Size(31, 16)
        Me.LabelR4.TabIndex = 8
        Me.LabelR4.Text = "0.00"
        '
        'LabelR3
        '
        Me.LabelR3.AutoSize = True
        Me.LabelR3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelR3.Location = New System.Drawing.Point(214, 130)
        Me.LabelR3.Name = "LabelR3"
        Me.LabelR3.Size = New System.Drawing.Size(31, 16)
        Me.LabelR3.TabIndex = 7
        Me.LabelR3.Text = "0.00"
        '
        'LabelR2
        '
        Me.LabelR2.AutoSize = True
        Me.LabelR2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelR2.Location = New System.Drawing.Point(214, 84)
        Me.LabelR2.Name = "LabelR2"
        Me.LabelR2.Size = New System.Drawing.Size(31, 16)
        Me.LabelR2.TabIndex = 6
        Me.LabelR2.Text = "0.00"
        '
        'LabelR1
        '
        Me.LabelR1.AutoSize = True
        Me.LabelR1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelR1.Location = New System.Drawing.Point(214, 43)
        Me.LabelR1.Name = "LabelR1"
        Me.LabelR1.Size = New System.Drawing.Size(31, 16)
        Me.LabelR1.TabIndex = 5
        Me.LabelR1.Text = "0.00"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(34, 213)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(146, 22)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "TOTAL A PAGAR"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(34, 172)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 18)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Descuento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(34, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 18)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Pago con el IVA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(34, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 18)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Valor del IVA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 18)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Pago antes del IVA"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Controls.Add(Me.BotonSalir)
        Me.GroupBox3.Controls.Add(Me.BotonLimpiar)
        Me.GroupBox3.Controls.Add(Me.BotonAceptar)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox3.Location = New System.Drawing.Point(368, 22)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(315, 160)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Opciones"
        '
        'BotonSalir
        '
        Me.BotonSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BotonSalir.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonSalir.ForeColor = System.Drawing.Color.White
        Me.BotonSalir.Location = New System.Drawing.Point(110, 108)
        Me.BotonSalir.Name = "BotonSalir"
        Me.BotonSalir.Size = New System.Drawing.Size(100, 24)
        Me.BotonSalir.TabIndex = 2
        Me.BotonSalir.Text = "SALIR"
        Me.BotonSalir.UseVisualStyleBackColor = False
        '
        'BotonLimpiar
        '
        Me.BotonLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BotonLimpiar.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonLimpiar.ForeColor = System.Drawing.Color.White
        Me.BotonLimpiar.Location = New System.Drawing.Point(110, 66)
        Me.BotonLimpiar.Name = "BotonLimpiar"
        Me.BotonLimpiar.Size = New System.Drawing.Size(100, 24)
        Me.BotonLimpiar.TabIndex = 1
        Me.BotonLimpiar.Text = "LIMPIAR"
        Me.BotonLimpiar.UseVisualStyleBackColor = False
        '
        'BotonAceptar
        '
        Me.BotonAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BotonAceptar.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonAceptar.ForeColor = System.Drawing.Color.White
        Me.BotonAceptar.Location = New System.Drawing.Point(110, 29)
        Me.BotonAceptar.Name = "BotonAceptar"
        Me.BotonAceptar.Size = New System.Drawing.Size(100, 22)
        Me.BotonAceptar.TabIndex = 0
        Me.BotonAceptar.Text = "ACEPTAR"
        Me.BotonAceptar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(360, 298)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(323, 155)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox1.Font = New System.Drawing.Font("Caveat", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBox1.Location = New System.Drawing.Point(32, 459)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(651, 52)
        Me.TextBox1.TabIndex = 7
        Me.TextBox1.Text = "GRACIAS POR TU COMPRA"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(800, 537)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "201602920_Tienda"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBoxAzucar As TextBox
    Friend WithEvents TextBoxFrijol As TextBox
    Friend WithEvents TextBoxArroz As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LabelR5 As Label
    Friend WithEvents LabelR4 As Label
    Friend WithEvents LabelR3 As Label
    Friend WithEvents LabelR2 As Label
    Friend WithEvents LabelR1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents BotonSalir As Button
    Friend WithEvents BotonLimpiar As Button
    Friend WithEvents BotonAceptar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox1 As TextBox
End Class
