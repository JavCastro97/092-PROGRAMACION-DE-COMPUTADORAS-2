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
        Me.GroupBoxAeronave = New System.Windows.Forms.GroupBox()
        Me.RBHelicoptero = New System.Windows.Forms.RadioButton()
        Me.RBJet = New System.Windows.Forms.RadioButton()
        Me.RBAvioneta = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBoxDestinos = New System.Windows.Forms.GroupBox()
        Me.CheckBoxPeten = New System.Windows.Forms.CheckBox()
        Me.CheckBoxIzabal = New System.Windows.Forms.CheckBox()
        Me.CheckBoxCostaSur = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBCantidadPasajeros = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.ButtonLimpiar = New System.Windows.Forms.Button()
        Me.ButtonCalcular = New System.Windows.Forms.Button()
        Me.GroupBoxAeronave.SuspendLayout()
        Me.GroupBoxDestinos.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxAeronave
        '
        Me.GroupBoxAeronave.Controls.Add(Me.RBHelicoptero)
        Me.GroupBoxAeronave.Controls.Add(Me.RBJet)
        Me.GroupBoxAeronave.Controls.Add(Me.RBAvioneta)
        Me.GroupBoxAeronave.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxAeronave.Location = New System.Drawing.Point(35, 140)
        Me.GroupBoxAeronave.Name = "GroupBoxAeronave"
        Me.GroupBoxAeronave.Size = New System.Drawing.Size(157, 173)
        Me.GroupBoxAeronave.TabIndex = 0
        Me.GroupBoxAeronave.TabStop = False
        Me.GroupBoxAeronave.Text = "TIPO DE AERONAVE"
        '
        'RBHelicoptero
        '
        Me.RBHelicoptero.AutoSize = True
        Me.RBHelicoptero.Location = New System.Drawing.Point(40, 129)
        Me.RBHelicoptero.Name = "RBHelicoptero"
        Me.RBHelicoptero.Size = New System.Drawing.Size(93, 19)
        Me.RBHelicoptero.TabIndex = 2
        Me.RBHelicoptero.TabStop = True
        Me.RBHelicoptero.Text = "Helicóptero"
        Me.RBHelicoptero.UseVisualStyleBackColor = True
        '
        'RBJet
        '
        Me.RBJet.AutoSize = True
        Me.RBJet.Location = New System.Drawing.Point(41, 84)
        Me.RBJet.Name = "RBJet"
        Me.RBJet.Size = New System.Drawing.Size(43, 19)
        Me.RBJet.TabIndex = 1
        Me.RBJet.TabStop = True
        Me.RBJet.Text = "Jet"
        Me.RBJet.UseVisualStyleBackColor = True
        '
        'RBAvioneta
        '
        Me.RBAvioneta.AutoSize = True
        Me.RBAvioneta.Location = New System.Drawing.Point(40, 43)
        Me.RBAvioneta.Name = "RBAvioneta"
        Me.RBAvioneta.Size = New System.Drawing.Size(77, 19)
        Me.RBAvioneta.TabIndex = 0
        Me.RBAvioneta.TabStop = True
        Me.RBAvioneta.Text = "Avioneta"
        Me.RBAvioneta.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ink Free", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(348, 43)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "EMPRESA ""VUELOS"""
        '
        'GroupBoxDestinos
        '
        Me.GroupBoxDestinos.Controls.Add(Me.CheckBoxPeten)
        Me.GroupBoxDestinos.Controls.Add(Me.CheckBoxIzabal)
        Me.GroupBoxDestinos.Controls.Add(Me.CheckBoxCostaSur)
        Me.GroupBoxDestinos.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxDestinos.Location = New System.Drawing.Point(210, 140)
        Me.GroupBoxDestinos.Name = "GroupBoxDestinos"
        Me.GroupBoxDestinos.Size = New System.Drawing.Size(157, 173)
        Me.GroupBoxDestinos.TabIndex = 2
        Me.GroupBoxDestinos.TabStop = False
        Me.GroupBoxDestinos.Text = "DESTINOS"
        '
        'CheckBoxPeten
        '
        Me.CheckBoxPeten.AutoSize = True
        Me.CheckBoxPeten.Location = New System.Drawing.Point(32, 129)
        Me.CheckBoxPeten.Name = "CheckBoxPeten"
        Me.CheckBoxPeten.Size = New System.Drawing.Size(61, 19)
        Me.CheckBoxPeten.TabIndex = 2
        Me.CheckBoxPeten.Text = "Petén"
        Me.CheckBoxPeten.UseVisualStyleBackColor = True
        '
        'CheckBoxIzabal
        '
        Me.CheckBoxIzabal.AutoSize = True
        Me.CheckBoxIzabal.Location = New System.Drawing.Point(32, 84)
        Me.CheckBoxIzabal.Name = "CheckBoxIzabal"
        Me.CheckBoxIzabal.Size = New System.Drawing.Size(61, 19)
        Me.CheckBoxIzabal.TabIndex = 1
        Me.CheckBoxIzabal.Text = "Izabal"
        Me.CheckBoxIzabal.UseVisualStyleBackColor = True
        '
        'CheckBoxCostaSur
        '
        Me.CheckBoxCostaSur.AutoSize = True
        Me.CheckBoxCostaSur.Location = New System.Drawing.Point(32, 43)
        Me.CheckBoxCostaSur.Name = "CheckBoxCostaSur"
        Me.CheckBoxCostaSur.Size = New System.Drawing.Size(82, 19)
        Me.CheckBoxCostaSur.TabIndex = 0
        Me.CheckBoxCostaSur.Text = "Costa Sur"
        Me.CheckBoxCostaSur.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(216, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "INGRESE LA CANTIDAD DE PASAJEROS:"
        '
        'TBCantidadPasajeros
        '
        Me.TBCantidadPasajeros.Location = New System.Drawing.Point(268, 102)
        Me.TBCantidadPasajeros.Name = "TBCantidadPasajeros"
        Me.TBCantidadPasajeros.Size = New System.Drawing.Size(99, 20)
        Me.TBCantidadPasajeros.TabIndex = 4
        Me.TBCantidadPasajeros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonSalir)
        Me.GroupBox1.Controls.Add(Me.ButtonLimpiar)
        Me.GroupBox1.Controls.Add(Me.ButtonCalcular)
        Me.GroupBox1.Font = New System.Drawing.Font("Impact", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(385, 140)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(156, 173)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MENÚ"
        '
        'ButtonSalir
        '
        Me.ButtonSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonSalir.Location = New System.Drawing.Point(40, 129)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSalir.TabIndex = 2
        Me.ButtonSalir.Text = "SALIR"
        Me.ButtonSalir.UseVisualStyleBackColor = False
        '
        'ButtonLimpiar
        '
        Me.ButtonLimpiar.BackColor = System.Drawing.Color.Blue
        Me.ButtonLimpiar.ForeColor = System.Drawing.SystemColors.Control
        Me.ButtonLimpiar.Location = New System.Drawing.Point(40, 84)
        Me.ButtonLimpiar.Name = "ButtonLimpiar"
        Me.ButtonLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonLimpiar.TabIndex = 1
        Me.ButtonLimpiar.Text = "LIMPIAR"
        Me.ButtonLimpiar.UseVisualStyleBackColor = False
        '
        'ButtonCalcular
        '
        Me.ButtonCalcular.BackColor = System.Drawing.Color.Navy
        Me.ButtonCalcular.ForeColor = System.Drawing.SystemColors.Control
        Me.ButtonCalcular.Location = New System.Drawing.Point(40, 39)
        Me.ButtonCalcular.Name = "ButtonCalcular"
        Me.ButtonCalcular.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCalcular.TabIndex = 0
        Me.ButtonCalcular.Text = "CALCULAR"
        Me.ButtonCalcular.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._201602920_VUELOS.My.Resources.Resources.banner_de_fondo_mínimo_para_viajes_modelo_avión_en_vuelo_un_color_vacío_copiar_espacio_170421780
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(834, 330)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TBCantidadPasajeros)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBoxDestinos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBoxAeronave)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBoxAeronave.ResumeLayout(False)
        Me.GroupBoxAeronave.PerformLayout()
        Me.GroupBoxDestinos.ResumeLayout(False)
        Me.GroupBoxDestinos.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBoxAeronave As GroupBox
    Friend WithEvents RBHelicoptero As RadioButton
    Friend WithEvents RBJet As RadioButton
    Friend WithEvents RBAvioneta As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBoxDestinos As GroupBox
    Friend WithEvents CheckBoxPeten As CheckBox
    Friend WithEvents CheckBoxIzabal As CheckBox
    Friend WithEvents CheckBoxCostaSur As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TBCantidadPasajeros As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButtonSalir As Button
    Friend WithEvents ButtonLimpiar As Button
    Friend WithEvents ButtonCalcular As Button
End Class
