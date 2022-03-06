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
        Me.GroupBoxPaciente = New System.Windows.Forms.GroupBox()
        Me.LabelHonorarios = New System.Windows.Forms.Label()
        Me.TextBoxHonorarios = New System.Windows.Forms.TextBox()
        Me.TextBoxDíasHospitalizado = New System.Windows.Forms.TextBox()
        Me.LabelDiasHospitalizado = New System.Windows.Forms.Label()
        Me.TextBoxNIT = New System.Windows.Forms.TextBox()
        Me.LabelNIT = New System.Windows.Forms.Label()
        Me.TextBoxPaciente = New System.Windows.Forms.TextBox()
        Me.LabelPaciente = New System.Windows.Forms.Label()
        Me.GroupBoxDatos = New System.Windows.Forms.GroupBox()
        Me.GroupBoxPago = New System.Windows.Forms.GroupBox()
        Me.ComboBoxPago = New System.Windows.Forms.ComboBox()
        Me.GroupBoxServicio = New System.Windows.Forms.GroupBox()
        Me.CBMaternidad = New System.Windows.Forms.CheckBox()
        Me.CBOperacion = New System.Windows.Forms.CheckBox()
        Me.CBEncamamiento = New System.Windows.Forms.CheckBox()
        Me.GroupBoxHabitacion = New System.Windows.Forms.GroupBox()
        Me.RBNoPrivada = New System.Windows.Forms.RadioButton()
        Me.RBSemiprivada = New System.Windows.Forms.RadioButton()
        Me.RBPrivada = New System.Windows.Forms.RadioButton()
        Me.GroupBoxResultados = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox9 = New System.Windows.Forms.ListBox()
        Me.ListBox8 = New System.Windows.Forms.ListBox()
        Me.ListBox7 = New System.Windows.Forms.ListBox()
        Me.ListBox6 = New System.Windows.Forms.ListBox()
        Me.ListBox5 = New System.Windows.Forms.ListBox()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox10 = New System.Windows.Forms.ListBox()
        Me.CALCULARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARENTRADASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARVECTORESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GroupBoxPaciente.SuspendLayout()
        Me.GroupBoxDatos.SuspendLayout()
        Me.GroupBoxPago.SuspendLayout()
        Me.GroupBoxServicio.SuspendLayout()
        Me.GroupBoxHabitacion.SuspendLayout()
        Me.GroupBoxResultados.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxPaciente
        '
        Me.GroupBoxPaciente.BackColor = System.Drawing.Color.White
        Me.GroupBoxPaciente.Controls.Add(Me.LabelHonorarios)
        Me.GroupBoxPaciente.Controls.Add(Me.TextBoxHonorarios)
        Me.GroupBoxPaciente.Controls.Add(Me.TextBoxDíasHospitalizado)
        Me.GroupBoxPaciente.Controls.Add(Me.LabelDiasHospitalizado)
        Me.GroupBoxPaciente.Controls.Add(Me.TextBoxNIT)
        Me.GroupBoxPaciente.Controls.Add(Me.LabelNIT)
        Me.GroupBoxPaciente.Controls.Add(Me.TextBoxPaciente)
        Me.GroupBoxPaciente.Controls.Add(Me.LabelPaciente)
        Me.GroupBoxPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxPaciente.Location = New System.Drawing.Point(12, 42)
        Me.GroupBoxPaciente.Name = "GroupBoxPaciente"
        Me.GroupBoxPaciente.Size = New System.Drawing.Size(355, 165)
        Me.GroupBoxPaciente.TabIndex = 1
        Me.GroupBoxPaciente.TabStop = False
        Me.GroupBoxPaciente.Text = "REGISTRO DEL PACIENTE"
        '
        'LabelHonorarios
        '
        Me.LabelHonorarios.AutoSize = True
        Me.LabelHonorarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHonorarios.Location = New System.Drawing.Point(19, 136)
        Me.LabelHonorarios.Name = "LabelHonorarios"
        Me.LabelHonorarios.Size = New System.Drawing.Size(95, 13)
        Me.LabelHonorarios.TabIndex = 7
        Me.LabelHonorarios.Text = "Honorarios médico"
        '
        'TextBoxHonorarios
        '
        Me.TextBoxHonorarios.Location = New System.Drawing.Point(176, 133)
        Me.TextBoxHonorarios.Name = "TextBoxHonorarios"
        Me.TextBoxHonorarios.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxHonorarios.TabIndex = 6
        '
        'TextBoxDíasHospitalizado
        '
        Me.TextBoxDíasHospitalizado.Location = New System.Drawing.Point(176, 98)
        Me.TextBoxDíasHospitalizado.Name = "TextBoxDíasHospitalizado"
        Me.TextBoxDíasHospitalizado.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxDíasHospitalizado.TabIndex = 5
        '
        'LabelDiasHospitalizado
        '
        Me.LabelDiasHospitalizado.AutoSize = True
        Me.LabelDiasHospitalizado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDiasHospitalizado.Location = New System.Drawing.Point(19, 98)
        Me.LabelDiasHospitalizado.Name = "LabelDiasHospitalizado"
        Me.LabelDiasHospitalizado.Size = New System.Drawing.Size(147, 13)
        Me.LabelDiasHospitalizado.TabIndex = 4
        Me.LabelDiasHospitalizado.Text = "Número de días hospitalizado"
        '
        'TextBoxNIT
        '
        Me.TextBoxNIT.Location = New System.Drawing.Point(176, 67)
        Me.TextBoxNIT.Name = "TextBoxNIT"
        Me.TextBoxNIT.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNIT.TabIndex = 3
        '
        'LabelNIT
        '
        Me.LabelNIT.AutoSize = True
        Me.LabelNIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNIT.Location = New System.Drawing.Point(19, 67)
        Me.LabelNIT.Name = "LabelNIT"
        Me.LabelNIT.Size = New System.Drawing.Size(25, 13)
        Me.LabelNIT.TabIndex = 2
        Me.LabelNIT.Text = "NIT"
        '
        'TextBoxPaciente
        '
        Me.TextBoxPaciente.Location = New System.Drawing.Point(176, 34)
        Me.TextBoxPaciente.Name = "TextBoxPaciente"
        Me.TextBoxPaciente.Size = New System.Drawing.Size(162, 20)
        Me.TextBoxPaciente.TabIndex = 1
        '
        'LabelPaciente
        '
        Me.LabelPaciente.AutoSize = True
        Me.LabelPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPaciente.Location = New System.Drawing.Point(19, 34)
        Me.LabelPaciente.Name = "LabelPaciente"
        Me.LabelPaciente.Size = New System.Drawing.Size(105, 13)
        Me.LabelPaciente.TabIndex = 0
        Me.LabelPaciente.Text = "Nombre del paciente"
        '
        'GroupBoxDatos
        '
        Me.GroupBoxDatos.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxDatos.Controls.Add(Me.GroupBoxPago)
        Me.GroupBoxDatos.Controls.Add(Me.GroupBoxServicio)
        Me.GroupBoxDatos.Controls.Add(Me.GroupBoxHabitacion)
        Me.GroupBoxDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxDatos.Location = New System.Drawing.Point(373, 42)
        Me.GroupBoxDatos.Name = "GroupBoxDatos"
        Me.GroupBoxDatos.Size = New System.Drawing.Size(454, 165)
        Me.GroupBoxDatos.TabIndex = 8
        Me.GroupBoxDatos.TabStop = False
        Me.GroupBoxDatos.Text = "INGRESO DE DATOS"
        '
        'GroupBoxPago
        '
        Me.GroupBoxPago.Controls.Add(Me.ComboBoxPago)
        Me.GroupBoxPago.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxPago.Location = New System.Drawing.Point(297, 34)
        Me.GroupBoxPago.Name = "GroupBoxPago"
        Me.GroupBoxPago.Size = New System.Drawing.Size(140, 122)
        Me.GroupBoxPago.TabIndex = 7
        Me.GroupBoxPago.TabStop = False
        Me.GroupBoxPago.Text = "FORMA DE PAGO"
        '
        'ComboBoxPago
        '
        Me.ComboBoxPago.FormattingEnabled = True
        Me.ComboBoxPago.Location = New System.Drawing.Point(13, 36)
        Me.ComboBoxPago.Name = "ComboBoxPago"
        Me.ComboBoxPago.Size = New System.Drawing.Size(121, 28)
        Me.ComboBoxPago.TabIndex = 0
        '
        'GroupBoxServicio
        '
        Me.GroupBoxServicio.Controls.Add(Me.CBMaternidad)
        Me.GroupBoxServicio.Controls.Add(Me.CBOperacion)
        Me.GroupBoxServicio.Controls.Add(Me.CBEncamamiento)
        Me.GroupBoxServicio.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxServicio.Location = New System.Drawing.Point(151, 31)
        Me.GroupBoxServicio.Name = "GroupBoxServicio"
        Me.GroupBoxServicio.Size = New System.Drawing.Size(140, 122)
        Me.GroupBoxServicio.TabIndex = 6
        Me.GroupBoxServicio.TabStop = False
        Me.GroupBoxServicio.Text = "SERVICIO"
        '
        'CBMaternidad
        '
        Me.CBMaternidad.AutoSize = True
        Me.CBMaternidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBMaternidad.Location = New System.Drawing.Point(23, 99)
        Me.CBMaternidad.Name = "CBMaternidad"
        Me.CBMaternidad.Size = New System.Drawing.Size(98, 17)
        Me.CBMaternidad.TabIndex = 2
        Me.CBMaternidad.Text = "MATERNIDAD"
        Me.CBMaternidad.UseVisualStyleBackColor = True
        '
        'CBOperacion
        '
        Me.CBOperacion.AutoSize = True
        Me.CBOperacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBOperacion.Location = New System.Drawing.Point(23, 70)
        Me.CBOperacion.Name = "CBOperacion"
        Me.CBOperacion.Size = New System.Drawing.Size(89, 17)
        Me.CBOperacion.TabIndex = 1
        Me.CBOperacion.Text = "OPERACIÓN"
        Me.CBOperacion.UseVisualStyleBackColor = True
        '
        'CBEncamamiento
        '
        Me.CBEncamamiento.AutoSize = True
        Me.CBEncamamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBEncamamiento.Location = New System.Drawing.Point(23, 40)
        Me.CBEncamamiento.Name = "CBEncamamiento"
        Me.CBEncamamiento.Size = New System.Drawing.Size(113, 17)
        Me.CBEncamamiento.TabIndex = 0
        Me.CBEncamamiento.Text = "ENCAMAMIENTO"
        Me.CBEncamamiento.UseVisualStyleBackColor = True
        '
        'GroupBoxHabitacion
        '
        Me.GroupBoxHabitacion.Controls.Add(Me.RBNoPrivada)
        Me.GroupBoxHabitacion.Controls.Add(Me.RBSemiprivada)
        Me.GroupBoxHabitacion.Controls.Add(Me.RBPrivada)
        Me.GroupBoxHabitacion.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxHabitacion.Location = New System.Drawing.Point(14, 30)
        Me.GroupBoxHabitacion.Name = "GroupBoxHabitacion"
        Me.GroupBoxHabitacion.Size = New System.Drawing.Size(131, 122)
        Me.GroupBoxHabitacion.TabIndex = 4
        Me.GroupBoxHabitacion.TabStop = False
        Me.GroupBoxHabitacion.Text = "TIPO DE HABITACIÓN"
        '
        'RBNoPrivada
        '
        Me.RBNoPrivada.AutoSize = True
        Me.RBNoPrivada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBNoPrivada.Location = New System.Drawing.Point(18, 99)
        Me.RBNoPrivada.Name = "RBNoPrivada"
        Me.RBNoPrivada.Size = New System.Drawing.Size(91, 17)
        Me.RBNoPrivada.TabIndex = 5
        Me.RBNoPrivada.TabStop = True
        Me.RBNoPrivada.Text = "NO PRIVADA"
        Me.RBNoPrivada.UseVisualStyleBackColor = True
        '
        'RBSemiprivada
        '
        Me.RBSemiprivada.AutoSize = True
        Me.RBSemiprivada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBSemiprivada.Location = New System.Drawing.Point(18, 69)
        Me.RBSemiprivada.Name = "RBSemiprivada"
        Me.RBSemiprivada.Size = New System.Drawing.Size(98, 17)
        Me.RBSemiprivada.TabIndex = 4
        Me.RBSemiprivada.TabStop = True
        Me.RBSemiprivada.Text = "SEMIPRIVADA"
        Me.RBSemiprivada.UseVisualStyleBackColor = True
        '
        'RBPrivada
        '
        Me.RBPrivada.AutoSize = True
        Me.RBPrivada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBPrivada.Location = New System.Drawing.Point(18, 40)
        Me.RBPrivada.Name = "RBPrivada"
        Me.RBPrivada.Size = New System.Drawing.Size(72, 17)
        Me.RBPrivada.TabIndex = 3
        Me.RBPrivada.TabStop = True
        Me.RBPrivada.Text = "PRIVADA"
        Me.RBPrivada.UseVisualStyleBackColor = True
        '
        'GroupBoxResultados
        '
        Me.GroupBoxResultados.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxResultados.Controls.Add(Me.Label10)
        Me.GroupBoxResultados.Controls.Add(Me.Label9)
        Me.GroupBoxResultados.Controls.Add(Me.Label8)
        Me.GroupBoxResultados.Controls.Add(Me.Label7)
        Me.GroupBoxResultados.Controls.Add(Me.Label6)
        Me.GroupBoxResultados.Controls.Add(Me.Label5)
        Me.GroupBoxResultados.Controls.Add(Me.Label4)
        Me.GroupBoxResultados.Controls.Add(Me.Label3)
        Me.GroupBoxResultados.Controls.Add(Me.Label2)
        Me.GroupBoxResultados.Controls.Add(Me.Label1)
        Me.GroupBoxResultados.Controls.Add(Me.ListBox9)
        Me.GroupBoxResultados.Controls.Add(Me.ListBox8)
        Me.GroupBoxResultados.Controls.Add(Me.ListBox7)
        Me.GroupBoxResultados.Controls.Add(Me.ListBox6)
        Me.GroupBoxResultados.Controls.Add(Me.ListBox5)
        Me.GroupBoxResultados.Controls.Add(Me.ListBox4)
        Me.GroupBoxResultados.Controls.Add(Me.ListBox3)
        Me.GroupBoxResultados.Controls.Add(Me.ListBox2)
        Me.GroupBoxResultados.Controls.Add(Me.ListBox1)
        Me.GroupBoxResultados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxResultados.Location = New System.Drawing.Point(14, 213)
        Me.GroupBoxResultados.Name = "GroupBoxResultados"
        Me.GroupBoxResultados.Size = New System.Drawing.Size(878, 154)
        Me.GroupBoxResultados.TabIndex = 9
        Me.GroupBoxResultados.TabStop = False
        Me.GroupBoxResultados.Text = "RESULTADOS"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(789, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "TOTAL"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(704, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "RECARGO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(534, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "SUBTOTAL"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(619, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "DESCUENTO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(449, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "PAGO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(364, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "SERVICIO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(279, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "HABITACIÓN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(192, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "DÍAS "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(107, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "NIT"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "PACIENTE"
        '
        'ListBox9
        '
        Me.ListBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox9.FormattingEnabled = True
        Me.ListBox9.Location = New System.Drawing.Point(707, 46)
        Me.ListBox9.Name = "ListBox9"
        Me.ListBox9.Size = New System.Drawing.Size(79, 95)
        Me.ListBox9.TabIndex = 8
        '
        'ListBox8
        '
        Me.ListBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox8.FormattingEnabled = True
        Me.ListBox8.Location = New System.Drawing.Point(622, 46)
        Me.ListBox8.Name = "ListBox8"
        Me.ListBox8.Size = New System.Drawing.Size(79, 95)
        Me.ListBox8.TabIndex = 7
        '
        'ListBox7
        '
        Me.ListBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox7.FormattingEnabled = True
        Me.ListBox7.Location = New System.Drawing.Point(537, 46)
        Me.ListBox7.Name = "ListBox7"
        Me.ListBox7.Size = New System.Drawing.Size(79, 95)
        Me.ListBox7.TabIndex = 6
        '
        'ListBox6
        '
        Me.ListBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox6.FormattingEnabled = True
        Me.ListBox6.Location = New System.Drawing.Point(452, 46)
        Me.ListBox6.Name = "ListBox6"
        Me.ListBox6.Size = New System.Drawing.Size(79, 95)
        Me.ListBox6.TabIndex = 5
        '
        'ListBox5
        '
        Me.ListBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox5.FormattingEnabled = True
        Me.ListBox5.Location = New System.Drawing.Point(367, 46)
        Me.ListBox5.Name = "ListBox5"
        Me.ListBox5.Size = New System.Drawing.Size(79, 95)
        Me.ListBox5.TabIndex = 4
        '
        'ListBox4
        '
        Me.ListBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.Location = New System.Drawing.Point(282, 46)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(79, 95)
        Me.ListBox4.TabIndex = 3
        '
        'ListBox3
        '
        Me.ListBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(195, 46)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(79, 95)
        Me.ListBox3.TabIndex = 2
        '
        'ListBox2
        '
        Me.ListBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(110, 46)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(79, 95)
        Me.ListBox2.TabIndex = 1
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(25, 46)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(79, 95)
        Me.ListBox1.TabIndex = 0
        '
        'ListBox10
        '
        Me.ListBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox10.FormattingEnabled = True
        Me.ListBox10.Location = New System.Drawing.Point(806, 259)
        Me.ListBox10.Name = "ListBox10"
        Me.ListBox10.Size = New System.Drawing.Size(79, 95)
        Me.ListBox10.TabIndex = 17
        '
        'CALCULARToolStripMenuItem
        '
        Me.CALCULARToolStripMenuItem.Name = "CALCULARToolStripMenuItem"
        Me.CALCULARToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.CALCULARToolStripMenuItem.Text = "CALCULAR"
        '
        'LIMPIARENTRADASToolStripMenuItem
        '
        Me.LIMPIARENTRADASToolStripMenuItem.Name = "LIMPIARENTRADASToolStripMenuItem"
        Me.LIMPIARENTRADASToolStripMenuItem.Size = New System.Drawing.Size(125, 20)
        Me.LIMPIARENTRADASToolStripMenuItem.Text = "LIMPIAR ENTRADAS"
        '
        'LIMPIARVECTORESToolStripMenuItem
        '
        Me.LIMPIARVECTORESToolStripMenuItem.Name = "LIMPIARVECTORESToolStripMenuItem"
        Me.LIMPIARVECTORESToolStripMenuItem.Size = New System.Drawing.Size(121, 20)
        Me.LIMPIARVECTORESToolStripMenuItem.Text = "LIMPIAR VECTORES"
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.SALIRToolStripMenuItem.Text = "SALIR"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CALCULARToolStripMenuItem, Me.LIMPIARENTRADASToolStripMenuItem, Me.LIMPIARVECTORESToolStripMenuItem, Me.SALIRToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(919, 24)
        Me.MenuStrip1.TabIndex = 18
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._201602920_HOSPITAL.My.Resources.Resources.Fondo_Hospital
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(919, 389)
        Me.Controls.Add(Me.ListBox10)
        Me.Controls.Add(Me.GroupBoxResultados)
        Me.Controls.Add(Me.GroupBoxDatos)
        Me.Controls.Add(Me.GroupBoxPaciente)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBoxPaciente.ResumeLayout(False)
        Me.GroupBoxPaciente.PerformLayout()
        Me.GroupBoxDatos.ResumeLayout(False)
        Me.GroupBoxPago.ResumeLayout(False)
        Me.GroupBoxServicio.ResumeLayout(False)
        Me.GroupBoxServicio.PerformLayout()
        Me.GroupBoxHabitacion.ResumeLayout(False)
        Me.GroupBoxHabitacion.PerformLayout()
        Me.GroupBoxResultados.ResumeLayout(False)
        Me.GroupBoxResultados.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBoxPaciente As GroupBox
    Friend WithEvents LabelNIT As Label
    Friend WithEvents TextBoxPaciente As TextBox
    Friend WithEvents LabelPaciente As Label
    Friend WithEvents LabelHonorarios As Label
    Friend WithEvents TextBoxHonorarios As TextBox
    Friend WithEvents TextBoxDíasHospitalizado As TextBox
    Friend WithEvents LabelDiasHospitalizado As Label
    Friend WithEvents TextBoxNIT As TextBox
    Friend WithEvents GroupBoxDatos As GroupBox
    Friend WithEvents GroupBoxPago As GroupBox
    Friend WithEvents ComboBoxPago As ComboBox
    Friend WithEvents GroupBoxServicio As GroupBox
    Friend WithEvents CBMaternidad As CheckBox
    Friend WithEvents CBOperacion As CheckBox
    Friend WithEvents CBEncamamiento As CheckBox
    Friend WithEvents GroupBoxHabitacion As GroupBox
    Friend WithEvents RBNoPrivada As RadioButton
    Friend WithEvents RBSemiprivada As RadioButton
    Friend WithEvents RBPrivada As RadioButton
    Friend WithEvents GroupBoxResultados As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox9 As ListBox
    Friend WithEvents ListBox8 As ListBox
    Friend WithEvents ListBox7 As ListBox
    Friend WithEvents ListBox6 As ListBox
    Friend WithEvents ListBox5 As ListBox
    Friend WithEvents ListBox4 As ListBox
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ListBox10 As ListBox
    Friend WithEvents CALCULARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARENTRADASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARVECTORESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
End Class
