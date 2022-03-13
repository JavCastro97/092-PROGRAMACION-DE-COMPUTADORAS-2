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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CALCULARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARENTRADASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARVECTORESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxInscripcion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBoxCurso = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxCarnet = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ButtonREGISTRAR = New System.Windows.Forms.Button()
        Me.ComboBoxPago = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxHorasSabado = New System.Windows.Forms.TextBox()
        Me.TextBoxHorasViernes = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CheckBoxSabado = New System.Windows.Forms.CheckBox()
        Me.CheckBoxViernes = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CALCULARToolStripMenuItem, Me.LIMPIARENTRADASToolStripMenuItem, Me.LIMPIARVECTORESToolStripMenuItem, Me.SALIRToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1128, 28)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CALCULARToolStripMenuItem
        '
        Me.CALCULARToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CALCULARToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CALCULARToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.CALCULARToolStripMenuItem.Name = "CALCULARToolStripMenuItem"
        Me.CALCULARToolStripMenuItem.Size = New System.Drawing.Size(98, 24)
        Me.CALCULARToolStripMenuItem.Text = "CALCULAR"
        '
        'LIMPIARENTRADASToolStripMenuItem
        '
        Me.LIMPIARENTRADASToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LIMPIARENTRADASToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.LIMPIARENTRADASToolStripMenuItem.Name = "LIMPIARENTRADASToolStripMenuItem"
        Me.LIMPIARENTRADASToolStripMenuItem.Size = New System.Drawing.Size(167, 24)
        Me.LIMPIARENTRADASToolStripMenuItem.Text = "LIMPIAR ENTRADAS"
        '
        'LIMPIARVECTORESToolStripMenuItem
        '
        Me.LIMPIARVECTORESToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LIMPIARVECTORESToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.LIMPIARVECTORESToolStripMenuItem.Name = "LIMPIARVECTORESToolStripMenuItem"
        Me.LIMPIARVECTORESToolStripMenuItem.Size = New System.Drawing.Size(159, 24)
        Me.LIMPIARVECTORESToolStripMenuItem.Text = "LIMPIAR VECTORES"
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SALIRToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(63, 24)
        Me.SALIRToolStripMenuItem.Text = "SALIR"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBoxNombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBoxInscripcion)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ComboBoxCurso)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBoxCarnet)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 106)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(359, 226)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS DE INSCRIPCIÓN"
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(196, 60)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(157, 20)
        Me.TextBoxNombre.TabIndex = 8
        Me.TextBoxNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nombre del estudiante"
        '
        'TextBoxInscripcion
        '
        Me.TextBoxInscripcion.Location = New System.Drawing.Point(196, 135)
        Me.TextBoxInscripcion.Name = "TextBoxInscripcion"
        Me.TextBoxInscripcion.Size = New System.Drawing.Size(157, 20)
        Me.TextBoxInscripcion.TabIndex = 6
        Me.TextBoxInscripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Fecha de Inscripción"
        '
        'ComboBoxCurso
        '
        Me.ComboBoxCurso.FormattingEnabled = True
        Me.ComboBoxCurso.Location = New System.Drawing.Point(196, 96)
        Me.ComboBoxCurso.Name = "ComboBoxCurso"
        Me.ComboBoxCurso.Size = New System.Drawing.Size(157, 21)
        Me.ComboBoxCurso.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nombre del Curso"
        '
        'TextBoxCarnet
        '
        Me.TextBoxCarnet.Location = New System.Drawing.Point(196, 25)
        Me.TextBoxCarnet.Name = "TextBoxCarnet"
        Me.TextBoxCarnet.Size = New System.Drawing.Size(157, 20)
        Me.TextBoxCarnet.TabIndex = 2
        Me.TextBoxCarnet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Carnet"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ButtonREGISTRAR)
        Me.GroupBox2.Controls.Add(Me.ComboBoxPago)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TextBoxHorasSabado)
        Me.GroupBox2.Controls.Add(Me.TextBoxHorasViernes)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.CheckBoxSabado)
        Me.GroupBox2.Controls.Add(Me.CheckBoxViernes)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(406, 106)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(207, 226)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "FECHA Y PAGO"
        '
        'ButtonREGISTRAR
        '
        Me.ButtonREGISTRAR.Location = New System.Drawing.Point(52, 197)
        Me.ButtonREGISTRAR.Name = "ButtonREGISTRAR"
        Me.ButtonREGISTRAR.Size = New System.Drawing.Size(98, 23)
        Me.ButtonREGISTRAR.TabIndex = 8
        Me.ButtonREGISTRAR.Text = "REGISTRAR"
        Me.ButtonREGISTRAR.UseVisualStyleBackColor = True
        '
        'ComboBoxPago
        '
        Me.ComboBoxPago.FormattingEnabled = True
        Me.ComboBoxPago.Items.AddRange(New Object() {"EFECTIVO", "CHEQUE"})
        Me.ComboBoxPago.Location = New System.Drawing.Point(20, 155)
        Me.ComboBoxPago.Name = "ComboBoxPago"
        Me.ComboBoxPago.Size = New System.Drawing.Size(170, 21)
        Me.ComboBoxPago.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 131)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(146, 21)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "FORMA DE PAGO"
        '
        'TextBoxHorasSabado
        '
        Me.TextBoxHorasSabado.Location = New System.Drawing.Point(120, 92)
        Me.TextBoxHorasSabado.Name = "TextBoxHorasSabado"
        Me.TextBoxHorasSabado.Size = New System.Drawing.Size(70, 20)
        Me.TextBoxHorasSabado.TabIndex = 5
        Me.TextBoxHorasSabado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxHorasViernes
        '
        Me.TextBoxHorasViernes.Location = New System.Drawing.Point(120, 56)
        Me.TextBoxHorasViernes.Name = "TextBoxHorasViernes"
        Me.TextBoxHorasViernes.Size = New System.Drawing.Size(70, 20)
        Me.TextBoxHorasViernes.TabIndex = 4
        Me.TextBoxHorasViernes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(125, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 21)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Horas"
        '
        'CheckBoxSabado
        '
        Me.CheckBoxSabado.AutoSize = True
        Me.CheckBoxSabado.Location = New System.Drawing.Point(20, 98)
        Me.CheckBoxSabado.Name = "CheckBoxSabado"
        Me.CheckBoxSabado.Size = New System.Drawing.Size(70, 17)
        Me.CheckBoxSabado.TabIndex = 2
        Me.CheckBoxSabado.Text = "SÁBADO"
        Me.CheckBoxSabado.UseVisualStyleBackColor = True
        '
        'CheckBoxViernes
        '
        Me.CheckBoxViernes.AutoSize = True
        Me.CheckBoxViernes.Location = New System.Drawing.Point(20, 60)
        Me.CheckBoxViernes.Name = "CheckBoxViernes"
        Me.CheckBoxViernes.Size = New System.Drawing.Size(73, 17)
        Me.CheckBoxViernes.TabIndex = 1
        Me.CheckBoxViernes.Text = "VIERNES"
        Me.CheckBoxViernes.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 21)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Días"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10})
        Me.DataGridView1.Location = New System.Drawing.Point(30, 361)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1086, 248)
        Me.DataGridView1.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Impact", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(22, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(642, 45)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "PRIMER SEMESTRE IDIOMAS CALUSAC 2022"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Carnet"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nombre"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 200
        '
        'Column3
        '
        Me.Column3.HeaderText = "Curso"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Fecha"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Precio"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Días"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Horas"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 50
        '
        'Column8
        '
        Me.Column8.HeaderText = "PagoParcial"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.HeaderText = "Descuento"
        Me.Column9.Name = "Column9"
        '
        'Column10
        '
        Me.Column10.HeaderText = "PagoTotal"
        Me.Column10.Name = "Column10"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1128, 621)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CALCULARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARENTRADASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARVECTORESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBoxInscripcion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBoxCurso As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxCarnet As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComboBoxPago As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxHorasSabado As TextBox
    Friend WithEvents TextBoxHorasViernes As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CheckBoxSabado As CheckBox
    Friend WithEvents CheckBoxViernes As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents ButtonREGISTRAR As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
End Class
