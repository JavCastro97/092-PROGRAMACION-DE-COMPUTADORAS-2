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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RBLarge = New System.Windows.Forms.RadioButton()
        Me.RBMedium = New System.Windows.Forms.RadioButton()
        Me.RBSmall = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RBLona = New System.Windows.Forms.RadioButton()
        Me.RBSeda = New System.Windows.Forms.RadioButton()
        Me.RBAlgodon = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBCantidadChumpas = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.ButtonLimpiar = New System.Windows.Forms.Button()
        Me.ButtonCalcular = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RBLarge)
        Me.GroupBox1.Controls.Add(Me.RBMedium)
        Me.GroupBox1.Controls.Add(Me.RBSmall)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(24, 109)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(117, 164)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TAMAÑOS DE CHUMPAS"
        '
        'RBLarge
        '
        Me.RBLarge.AutoSize = True
        Me.RBLarge.Location = New System.Drawing.Point(20, 125)
        Me.RBLarge.Name = "RBLarge"
        Me.RBLarge.Size = New System.Drawing.Size(60, 20)
        Me.RBLarge.TabIndex = 2
        Me.RBLarge.TabStop = True
        Me.RBLarge.Text = "Large"
        Me.RBLarge.UseVisualStyleBackColor = True
        '
        'RBMedium
        '
        Me.RBMedium.AutoSize = True
        Me.RBMedium.Location = New System.Drawing.Point(20, 82)
        Me.RBMedium.Name = "RBMedium"
        Me.RBMedium.Size = New System.Drawing.Size(73, 20)
        Me.RBMedium.TabIndex = 1
        Me.RBMedium.TabStop = True
        Me.RBMedium.Text = "Medium"
        Me.RBMedium.UseVisualStyleBackColor = True
        '
        'RBSmall
        '
        Me.RBSmall.AutoSize = True
        Me.RBSmall.Location = New System.Drawing.Point(20, 42)
        Me.RBSmall.Name = "RBSmall"
        Me.RBSmall.Size = New System.Drawing.Size(59, 20)
        Me.RBSmall.TabIndex = 0
        Me.RBSmall.TabStop = True
        Me.RBSmall.Text = "Small"
        Me.RBSmall.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RBLona)
        Me.GroupBox2.Controls.Add(Me.RBSeda)
        Me.GroupBox2.Controls.Add(Me.RBAlgodon)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(181, 109)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(106, 164)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "MATERIAL"
        '
        'RBLona
        '
        Me.RBLona.AutoSize = True
        Me.RBLona.Location = New System.Drawing.Point(16, 125)
        Me.RBLona.Name = "RBLona"
        Me.RBLona.Size = New System.Drawing.Size(55, 20)
        Me.RBLona.TabIndex = 2
        Me.RBLona.TabStop = True
        Me.RBLona.Text = "Lona"
        Me.RBLona.UseVisualStyleBackColor = True
        '
        'RBSeda
        '
        Me.RBSeda.AutoSize = True
        Me.RBSeda.Location = New System.Drawing.Point(16, 82)
        Me.RBSeda.Name = "RBSeda"
        Me.RBSeda.Size = New System.Drawing.Size(58, 20)
        Me.RBSeda.TabIndex = 1
        Me.RBSeda.TabStop = True
        Me.RBSeda.Text = "Seda"
        Me.RBSeda.UseVisualStyleBackColor = True
        '
        'RBAlgodon
        '
        Me.RBAlgodon.AutoSize = True
        Me.RBAlgodon.Location = New System.Drawing.Point(15, 42)
        Me.RBAlgodon.Name = "RBAlgodon"
        Me.RBAlgodon.Size = New System.Drawing.Size(76, 20)
        Me.RBAlgodon.TabIndex = 0
        Me.RBAlgodon.TabStop = True
        Me.RBAlgodon.Text = "Algodón"
        Me.RBAlgodon.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ingrese la cantidad de chumpas "
        '
        'TBCantidadChumpas
        '
        Me.TBCantidadChumpas.Location = New System.Drawing.Point(237, 59)
        Me.TBCantidadChumpas.Name = "TBCantidadChumpas"
        Me.TBCantidadChumpas.Size = New System.Drawing.Size(50, 20)
        Me.TBCantidadChumpas.TabIndex = 3
        Me.TBCantidadChumpas.Text = "0"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ButtonSalir)
        Me.GroupBox3.Controls.Add(Me.ButtonLimpiar)
        Me.GroupBox3.Controls.Add(Me.ButtonCalcular)
        Me.GroupBox3.Location = New System.Drawing.Point(328, 109)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(129, 164)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "OPCIONES"
        '
        'ButtonSalir
        '
        Me.ButtonSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSalir.ForeColor = System.Drawing.Color.White
        Me.ButtonSalir.Location = New System.Drawing.Point(19, 125)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(91, 23)
        Me.ButtonSalir.TabIndex = 2
        Me.ButtonSalir.Text = "SALIR"
        Me.ButtonSalir.UseVisualStyleBackColor = False
        '
        'ButtonLimpiar
        '
        Me.ButtonLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLimpiar.ForeColor = System.Drawing.Color.White
        Me.ButtonLimpiar.Location = New System.Drawing.Point(19, 82)
        Me.ButtonLimpiar.Name = "ButtonLimpiar"
        Me.ButtonLimpiar.Size = New System.Drawing.Size(91, 23)
        Me.ButtonLimpiar.TabIndex = 1
        Me.ButtonLimpiar.Text = "LIMPIAR"
        Me.ButtonLimpiar.UseVisualStyleBackColor = False
        '
        'ButtonCalcular
        '
        Me.ButtonCalcular.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCalcular.ForeColor = System.Drawing.Color.White
        Me.ButtonCalcular.Location = New System.Drawing.Point(19, 39)
        Me.ButtonCalcular.Name = "ButtonCalcular"
        Me.ButtonCalcular.Size = New System.Drawing.Size(91, 23)
        Me.ButtonCalcular.TabIndex = 0
        Me.ButtonCalcular.Text = "CALCULAR"
        Me.ButtonCalcular.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ink Free", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(109, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(348, 36)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "FÁBRICA DE CHUMPAS "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._201602920_CUBRECAMAS.My.Resources.Resources.Chumpa
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(584, 312)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.TBCantidadChumpas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RBLarge As RadioButton
    Friend WithEvents RBMedium As RadioButton
    Friend WithEvents RBSmall As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RBLona As RadioButton
    Friend WithEvents RBSeda As RadioButton
    Friend WithEvents RBAlgodon As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents TBCantidadChumpas As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ButtonSalir As Button
    Friend WithEvents ButtonLimpiar As Button
    Friend WithEvents ButtonCalcular As Button
    Friend WithEvents Label2 As Label
End Class
