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
        Me.Lbl1Empresa = New System.Windows.Forms.Label()
        Me.TextBoxMensajero = New System.Windows.Forms.TextBox()
        Me.Lbl2Mensajero = New System.Windows.Forms.Label()
        Me.RB1RegNorte = New System.Windows.Forms.RadioButton()
        Me.GroupBoxRegion = New System.Windows.Forms.GroupBox()
        Me.RB4RegOccidente = New System.Windows.Forms.RadioButton()
        Me.RB3RegOriente = New System.Windows.Forms.RadioButton()
        Me.RB2RegSur = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RB6SegAccidente = New System.Windows.Forms.RadioButton()
        Me.RB5SegVehículo = New System.Windows.Forms.RadioButton()
        Me.B1Calcular = New System.Windows.Forms.Button()
        Me.B2Limpiar = New System.Windows.Forms.Button()
        Me.B3Salir = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBoxSueldoFinal = New System.Windows.Forms.TextBox()
        Me.TextBoxMontoSeguro = New System.Windows.Forms.TextBox()
        Me.LblTOTAL = New System.Windows.Forms.Label()
        Me.Lbl4MontoSeguro = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxMontoEnvio = New System.Windows.Forms.TextBox()
        Me.GroupBoxRegion.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl1Empresa
        '
        Me.Lbl1Empresa.AutoSize = True
        Me.Lbl1Empresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl1Empresa.Location = New System.Drawing.Point(134, 9)
        Me.Lbl1Empresa.Name = "Lbl1Empresa"
        Me.Lbl1Empresa.Size = New System.Drawing.Size(298, 25)
        Me.Lbl1Empresa.TabIndex = 0
        Me.Lbl1Empresa.Text = "MENSAJERÍA ENVÍOS S.A."
        '
        'TextBoxMensajero
        '
        Me.TextBoxMensajero.Location = New System.Drawing.Point(176, 60)
        Me.TextBoxMensajero.Name = "TextBoxMensajero"
        Me.TextBoxMensajero.Size = New System.Drawing.Size(265, 20)
        Me.TextBoxMensajero.TabIndex = 1
        '
        'Lbl2Mensajero
        '
        Me.Lbl2Mensajero.AutoSize = True
        Me.Lbl2Mensajero.Location = New System.Drawing.Point(37, 60)
        Me.Lbl2Mensajero.Name = "Lbl2Mensajero"
        Me.Lbl2Mensajero.Size = New System.Drawing.Size(112, 13)
        Me.Lbl2Mensajero.TabIndex = 2
        Me.Lbl2Mensajero.Text = "Nombre del mensajero"
        '
        'RB1RegNorte
        '
        Me.RB1RegNorte.AutoSize = True
        Me.RB1RegNorte.Location = New System.Drawing.Point(17, 33)
        Me.RB1RegNorte.Name = "RB1RegNorte"
        Me.RB1RegNorte.Size = New System.Drawing.Size(88, 17)
        Me.RB1RegNorte.TabIndex = 3
        Me.RB1RegNorte.TabStop = True
        Me.RB1RegNorte.Text = "Región Norte"
        Me.RB1RegNorte.UseVisualStyleBackColor = True
        '
        'GroupBoxRegion
        '
        Me.GroupBoxRegion.Controls.Add(Me.RB4RegOccidente)
        Me.GroupBoxRegion.Controls.Add(Me.RB3RegOriente)
        Me.GroupBoxRegion.Controls.Add(Me.RB2RegSur)
        Me.GroupBoxRegion.Controls.Add(Me.RB1RegNorte)
        Me.GroupBoxRegion.Location = New System.Drawing.Point(40, 149)
        Me.GroupBoxRegion.Name = "GroupBoxRegion"
        Me.GroupBoxRegion.Size = New System.Drawing.Size(138, 211)
        Me.GroupBoxRegion.TabIndex = 4
        Me.GroupBoxRegion.TabStop = False
        Me.GroupBoxRegion.Text = "REGIÓN DEL PAÍS"
        '
        'RB4RegOccidente
        '
        Me.RB4RegOccidente.AutoSize = True
        Me.RB4RegOccidente.Location = New System.Drawing.Point(17, 149)
        Me.RB4RegOccidente.Name = "RB4RegOccidente"
        Me.RB4RegOccidente.Size = New System.Drawing.Size(111, 17)
        Me.RB4RegOccidente.TabIndex = 6
        Me.RB4RegOccidente.TabStop = True
        Me.RB4RegOccidente.Text = "Región Occidente"
        Me.RB4RegOccidente.UseVisualStyleBackColor = True
        '
        'RB3RegOriente
        '
        Me.RB3RegOriente.AutoSize = True
        Me.RB3RegOriente.Location = New System.Drawing.Point(17, 111)
        Me.RB3RegOriente.Name = "RB3RegOriente"
        Me.RB3RegOriente.Size = New System.Drawing.Size(96, 17)
        Me.RB3RegOriente.TabIndex = 5
        Me.RB3RegOriente.TabStop = True
        Me.RB3RegOriente.Text = "Región Oriente"
        Me.RB3RegOriente.UseVisualStyleBackColor = True
        '
        'RB2RegSur
        '
        Me.RB2RegSur.AutoSize = True
        Me.RB2RegSur.Location = New System.Drawing.Point(17, 70)
        Me.RB2RegSur.Name = "RB2RegSur"
        Me.RB2RegSur.Size = New System.Drawing.Size(78, 17)
        Me.RB2RegSur.TabIndex = 4
        Me.RB2RegSur.TabStop = True
        Me.RB2RegSur.Text = "Región Sur"
        Me.RB2RegSur.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RB6SegAccidente)
        Me.GroupBox1.Controls.Add(Me.RB5SegVehículo)
        Me.GroupBox1.Location = New System.Drawing.Point(203, 149)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(238, 105)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SEGURO"
        '
        'RB6SegAccidente
        '
        Me.RB6SegAccidente.AutoSize = True
        Me.RB6SegAccidente.Location = New System.Drawing.Point(57, 70)
        Me.RB6SegAccidente.Name = "RB6SegAccidente"
        Me.RB6SegAccidente.Size = New System.Drawing.Size(124, 17)
        Me.RB6SegAccidente.TabIndex = 1
        Me.RB6SegAccidente.TabStop = True
        Me.RB6SegAccidente.Text = "Seguro de accidente"
        Me.RB6SegAccidente.UseVisualStyleBackColor = True
        '
        'RB5SegVehículo
        '
        Me.RB5SegVehículo.AutoSize = True
        Me.RB5SegVehículo.Location = New System.Drawing.Point(57, 33)
        Me.RB5SegVehículo.Name = "RB5SegVehículo"
        Me.RB5SegVehículo.Size = New System.Drawing.Size(144, 17)
        Me.RB5SegVehículo.TabIndex = 0
        Me.RB5SegVehículo.TabStop = True
        Me.RB5SegVehículo.Text = "Seguro sobre el vehículo"
        Me.RB5SegVehículo.UseVisualStyleBackColor = True
        '
        'B1Calcular
        '
        Me.B1Calcular.Location = New System.Drawing.Point(28, 25)
        Me.B1Calcular.Name = "B1Calcular"
        Me.B1Calcular.Size = New System.Drawing.Size(75, 23)
        Me.B1Calcular.TabIndex = 6
        Me.B1Calcular.Text = "CALCULAR"
        Me.B1Calcular.UseVisualStyleBackColor = True
        '
        'B2Limpiar
        '
        Me.B2Limpiar.Location = New System.Drawing.Point(28, 62)
        Me.B2Limpiar.Name = "B2Limpiar"
        Me.B2Limpiar.Size = New System.Drawing.Size(75, 23)
        Me.B2Limpiar.TabIndex = 7
        Me.B2Limpiar.Text = "LIMPIAR"
        Me.B2Limpiar.UseVisualStyleBackColor = True
        '
        'B3Salir
        '
        Me.B3Salir.Location = New System.Drawing.Point(28, 103)
        Me.B3Salir.Name = "B3Salir"
        Me.B3Salir.Size = New System.Drawing.Size(75, 23)
        Me.B3Salir.TabIndex = 8
        Me.B3Salir.Text = "SALIR"
        Me.B3Salir.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.B1Calcular)
        Me.GroupBox2.Controls.Add(Me.B3Salir)
        Me.GroupBox2.Controls.Add(Me.B2Limpiar)
        Me.GroupBox2.Location = New System.Drawing.Point(465, 151)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(128, 147)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "OPCIONES"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBoxSueldoFinal)
        Me.GroupBox3.Controls.Add(Me.TextBoxMontoSeguro)
        Me.GroupBox3.Controls.Add(Me.LblTOTAL)
        Me.GroupBox3.Controls.Add(Me.Lbl4MontoSeguro)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(43, 369)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(398, 107)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "RESULTADOS (Cantidades en quetzales)"
        '
        'TextBoxSueldoFinal
        '
        Me.TextBoxSueldoFinal.Enabled = False
        Me.TextBoxSueldoFinal.Location = New System.Drawing.Point(153, 62)
        Me.TextBoxSueldoFinal.Name = "TextBoxSueldoFinal"
        Me.TextBoxSueldoFinal.Size = New System.Drawing.Size(188, 22)
        Me.TextBoxSueldoFinal.TabIndex = 15
        '
        'TextBoxMontoSeguro
        '
        Me.TextBoxMontoSeguro.Enabled = False
        Me.TextBoxMontoSeguro.Location = New System.Drawing.Point(153, 31)
        Me.TextBoxMontoSeguro.Name = "TextBoxMontoSeguro"
        Me.TextBoxMontoSeguro.Size = New System.Drawing.Size(188, 22)
        Me.TextBoxMontoSeguro.TabIndex = 14
        '
        'LblTOTAL
        '
        Me.LblTOTAL.AutoSize = True
        Me.LblTOTAL.Location = New System.Drawing.Point(23, 62)
        Me.LblTOTAL.Name = "LblTOTAL"
        Me.LblTOTAL.Size = New System.Drawing.Size(121, 16)
        Me.LblTOTAL.TabIndex = 13
        Me.LblTOTAL.Text = "SUELDO TOTAL"
        '
        'Lbl4MontoSeguro
        '
        Me.Lbl4MontoSeguro.AutoSize = True
        Me.Lbl4MontoSeguro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl4MontoSeguro.Location = New System.Drawing.Point(23, 30)
        Me.Lbl4MontoSeguro.Name = "Lbl4MontoSeguro"
        Me.Lbl4MontoSeguro.Size = New System.Drawing.Size(113, 16)
        Me.Lbl4MontoSeguro.TabIndex = 11
        Me.Lbl4MontoSeguro.Text = "Monto del Seguro"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Monto de Envío (Q)"
        '
        'TextBoxMontoEnvio
        '
        Me.TextBoxMontoEnvio.Location = New System.Drawing.Point(176, 106)
        Me.TextBoxMontoEnvio.Name = "TextBoxMontoEnvio"
        Me.TextBoxMontoEnvio.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxMontoEnvio.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 509)
        Me.Controls.Add(Me.TextBoxMontoEnvio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBoxRegion)
        Me.Controls.Add(Me.Lbl2Mensajero)
        Me.Controls.Add(Me.TextBoxMensajero)
        Me.Controls.Add(Me.Lbl1Empresa)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBoxRegion.ResumeLayout(False)
        Me.GroupBoxRegion.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl1Empresa As Label
    Friend WithEvents TextBoxMensajero As TextBox
    Friend WithEvents Lbl2Mensajero As Label
    Friend WithEvents RB1RegNorte As RadioButton
    Friend WithEvents GroupBoxRegion As GroupBox
    Friend WithEvents RB4RegOccidente As RadioButton
    Friend WithEvents RB3RegOriente As RadioButton
    Friend WithEvents RB2RegSur As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RB6SegAccidente As RadioButton
    Friend WithEvents RB5SegVehículo As RadioButton
    Friend WithEvents B1Calcular As Button
    Friend WithEvents B2Limpiar As Button
    Friend WithEvents B3Salir As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents LblTOTAL As Label
    Friend WithEvents Lbl4MontoSeguro As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxSueldoFinal As TextBox
    Friend WithEvents TextBoxMontoSeguro As TextBox
    Friend WithEvents TextBoxMontoEnvio As TextBox
End Class
