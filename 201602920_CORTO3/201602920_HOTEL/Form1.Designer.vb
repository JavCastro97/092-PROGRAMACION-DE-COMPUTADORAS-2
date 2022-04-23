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
        Me.CALCULAR = New System.Windows.Forms.ToolStripMenuItem()
        Me.MOSTRAR = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONSULTAR = New System.Windows.Forms.ToolStripMenuItem()
        Me.ELIMINAR = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIAR = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TBValImpuesto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBDías = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBNit = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CALCULAR, Me.MOSTRAR, Me.CONSULTAR, Me.ELIMINAR, Me.LIMPIAR})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(886, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CALCULAR
        '
        Me.CALCULAR.ForeColor = System.Drawing.SystemColors.Control
        Me.CALCULAR.Name = "CALCULAR"
        Me.CALCULAR.Size = New System.Drawing.Size(62, 20)
        Me.CALCULAR.Text = "Calcular"
        '
        'MOSTRAR
        '
        Me.MOSTRAR.ForeColor = System.Drawing.SystemColors.Control
        Me.MOSTRAR.Name = "MOSTRAR"
        Me.MOSTRAR.Size = New System.Drawing.Size(60, 20)
        Me.MOSTRAR.Text = "Mostrar"
        '
        'CONSULTAR
        '
        Me.CONSULTAR.ForeColor = System.Drawing.SystemColors.Control
        Me.CONSULTAR.Name = "CONSULTAR"
        Me.CONSULTAR.Size = New System.Drawing.Size(70, 20)
        Me.CONSULTAR.Text = "Consultar"
        '
        'ELIMINAR
        '
        Me.ELIMINAR.ForeColor = System.Drawing.SystemColors.Control
        Me.ELIMINAR.Name = "ELIMINAR"
        Me.ELIMINAR.Size = New System.Drawing.Size(62, 20)
        Me.ELIMINAR.Text = "Eliminar"
        '
        'LIMPIAR
        '
        Me.LIMPIAR.ForeColor = System.Drawing.SystemColors.Control
        Me.LIMPIAR.Name = "LIMPIAR"
        Me.LIMPIAR.Size = New System.Drawing.Size(59, 20)
        Me.LIMPIAR.Text = "Limpiar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TBValImpuesto)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TBDías)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TBNit)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TBNombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(233, 185)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS DEL HUÉSPED"
        '
        'TBValImpuesto
        '
        Me.TBValImpuesto.Location = New System.Drawing.Point(96, 139)
        Me.TBValImpuesto.Name = "TBValImpuesto"
        Me.TBValImpuesto.Size = New System.Drawing.Size(100, 20)
        Me.TBValImpuesto.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "IMPUESTO"
        '
        'TBDías
        '
        Me.TBDías.Location = New System.Drawing.Point(96, 100)
        Me.TBDías.Name = "TBDías"
        Me.TBDías.Size = New System.Drawing.Size(100, 20)
        Me.TBDías.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "DÍAS"
        '
        'TBNit
        '
        Me.TBNit.Location = New System.Drawing.Point(96, 67)
        Me.TBNit.Name = "TBNit"
        Me.TBNit.Size = New System.Drawing.Size(100, 20)
        Me.TBNit.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NIT"
        '
        'TBNombre
        '
        Me.TBNombre.Location = New System.Drawing.Point(96, 27)
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Size = New System.Drawing.Size(100, 20)
        Me.TBNombre.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NOMBRE"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComboBox2)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(275, 33)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(309, 113)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DATOS DE HOSPEDAJE"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"EFECTIVO", "TARJETA DE CREDITO/DEBITO", "TRANSFERENCIA", "DEPOSITO"})
        Me.ComboBox2.Location = New System.Drawing.Point(170, 59)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 6
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"SENCILLA", "DOBLE", "CABAÑA"})
        Me.ComboBox1.Location = New System.Drawing.Point(23, 59)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(167, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "TIPO DE PAGO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "TIPO DE HABITACIÓN"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column5, Me.Column6, Me.Column7, Me.Column4, Me.Column8})
        Me.DataGridView1.Location = New System.Drawing.Point(36, 224)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(838, 175)
        Me.DataGridView1.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(635, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(239, 34)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "HOTEL PLAYA DORADA"
        '
        'Column1
        '
        Me.Column1.FillWeight = 150.0!
        Me.Column1.HeaderText = "NOMBRE"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "NIT"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 75
        '
        'Column3
        '
        Me.Column3.HeaderText = "DÍAS"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 75
        '
        'Column5
        '
        Me.Column5.HeaderText = "HABITACION"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "PAGO"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "SUBTOTAL"
        Me.Column7.Name = "Column7"
        '
        'Column4
        '
        Me.Column4.HeaderText = "DESCUENTO_RECARGO"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 150
        '
        'Column8
        '
        Me.Column8.HeaderText = "TOTAL"
        Me.Column8.Name = "Column8"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(886, 406)
        Me.Controls.Add(Me.Label6)
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
    Friend WithEvents CALCULAR As ToolStripMenuItem
    Friend WithEvents MOSTRAR As ToolStripMenuItem
    Friend WithEvents CONSULTAR As ToolStripMenuItem
    Friend WithEvents ELIMINAR As ToolStripMenuItem
    Friend WithEvents LIMPIAR As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TBValImpuesto As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TBDías As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TBNit As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TBNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
End Class
