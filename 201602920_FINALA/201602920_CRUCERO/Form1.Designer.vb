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
        Me.LIMPIARENTRADAS = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARVECTORES = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIR = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TBPersonas = New System.Windows.Forms.TextBox()
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
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TBConsultaNIT = New System.Windows.Forms.TextBox()
        Me.OrdenarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CALCULAR, Me.MOSTRAR, Me.OrdenarToolStripMenuItem, Me.CONSULTAR, Me.ELIMINAR, Me.LIMPIARENTRADAS, Me.LIMPIARVECTORES, Me.SALIR})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
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
        'LIMPIARENTRADAS
        '
        Me.LIMPIARENTRADAS.ForeColor = System.Drawing.SystemColors.Control
        Me.LIMPIARENTRADAS.Name = "LIMPIARENTRADAS"
        Me.LIMPIARENTRADAS.Size = New System.Drawing.Size(107, 20)
        Me.LIMPIARENTRADAS.Text = "Limpiar Entradas"
        '
        'LIMPIARVECTORES
        '
        Me.LIMPIARVECTORES.ForeColor = System.Drawing.SystemColors.Control
        Me.LIMPIARVECTORES.Name = "LIMPIARVECTORES"
        Me.LIMPIARVECTORES.Size = New System.Drawing.Size(106, 20)
        Me.LIMPIARVECTORES.Text = "Limpiar Vectores"
        '
        'SALIR
        '
        Me.SALIR.ForeColor = System.Drawing.SystemColors.Control
        Me.SALIR.Name = "SALIR"
        Me.SALIR.Size = New System.Drawing.Size(41, 20)
        Me.SALIR.Text = "Salir"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TBPersonas)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TBNit)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TBNombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Location = New System.Drawing.Point(278, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(233, 185)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS DEL HUÉSPED"
        '
        'TBPersonas
        '
        Me.TBPersonas.Location = New System.Drawing.Point(96, 100)
        Me.TBPersonas.Name = "TBPersonas"
        Me.TBPersonas.Size = New System.Drawing.Size(100, 23)
        Me.TBPersonas.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "PERSONAS"
        '
        'TBNit
        '
        Me.TBNit.Location = New System.Drawing.Point(96, 30)
        Me.TBNit.Name = "TBNit"
        Me.TBNit.Size = New System.Drawing.Size(100, 23)
        Me.TBNit.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NIT"
        '
        'TBNombre
        '
        Me.TBNombre.Location = New System.Drawing.Point(96, 64)
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Size = New System.Drawing.Size(100, 23)
        Me.TBNombre.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NOMBRE"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.ComboBox2)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Location = New System.Drawing.Point(517, 42)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(233, 181)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DATOS DE HOSPEDAJE"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"PRIMERA CLASE", "SEGUNDA CLASE"})
        Me.ComboBox2.Location = New System.Drawing.Point(23, 128)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 25)
        Me.ComboBox2.TabIndex = 6
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"SENCILLA", "DOBLE", "COMPARTIDA"})
        Me.ComboBox1.Location = New System.Drawing.Point(23, 59)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 25)
        Me.ComboBox1.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "TIPO DE CLASE"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 17)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "TIPO DE CABINA"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column5, Me.Column6, Me.Column7, Me.Column4})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 248)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(760, 175)
        Me.DataGridView1.TabIndex = 14
        '
        'Column1
        '
        Me.Column1.FillWeight = 150.0!
        Me.Column1.HeaderText = "NIT"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "NOMBRE"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "CABINA"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 75
        '
        'Column5
        '
        Me.Column5.HeaderText = "CLASE"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 150
        '
        'Column6
        '
        Me.Column6.HeaderText = "PERSONAS"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "PRECIO INDIVIDUAL"
        Me.Column7.Name = "Column7"
        '
        'Column4
        '
        Me.Column4.HeaderText = "TOTAL"
        Me.Column4.Name = "Column4"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.TBConsultaNIT)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Location = New System.Drawing.Point(12, 43)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(260, 92)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "CONSULTAR"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(16, 27)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 17)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Ingrese NIT:"
        '
        'TBConsultaNIT
        '
        Me.TBConsultaNIT.Location = New System.Drawing.Point(114, 29)
        Me.TBConsultaNIT.Name = "TBConsultaNIT"
        Me.TBConsultaNIT.Size = New System.Drawing.Size(100, 23)
        Me.TBConsultaNIT.TabIndex = 6
        '
        'OrdenarToolStripMenuItem
        '
        Me.OrdenarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.OrdenarToolStripMenuItem.Name = "OrdenarToolStripMenuItem"
        Me.OrdenarToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.OrdenarToolStripMenuItem.Text = "Ordenar"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox3)
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
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CALCULAR As ToolStripMenuItem
    Friend WithEvents MOSTRAR As ToolStripMenuItem
    Friend WithEvents CONSULTAR As ToolStripMenuItem
    Friend WithEvents ELIMINAR As ToolStripMenuItem
    Friend WithEvents LIMPIARENTRADAS As ToolStripMenuItem
    Friend WithEvents SALIR As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TBPersonas As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TBNit As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TBNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LIMPIARVECTORES As ToolStripMenuItem
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TBConsultaNIT As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents OrdenarToolStripMenuItem As ToolStripMenuItem
End Class
