Module Module1
    'VECTORES DE ENTRADA
    Public INDICE As Byte = 0
    Public Paciente(5) As String
    Public NIT(5) As Integer
    Public DIASHOSPITALIZADO(5) As Integer
    Public HABITACION(5) As Integer
    Public SERVICIO(5) As Integer
    Public HONORARIOS(5) As Integer
    Public PAGOEFECTIVO(5) As Integer
    Public PAGOCHEQUE(5) As Integer
    Public PAGOTARJETACREDITO(5) As Integer
    Public PAGOTARJETADEBITO(5) As Integer

    'VECTORES PARA EL CÁLCULO
    Public PAGO(5) As String
    Public SUBTOTAL(5) As Double
    Public DESCUENTO(5) As Double
    Public RECARGO(5) As Double
    Public TOTAL(5) As Double
    Public PRECIO(5) As Double
    Public ComboBoxPago(5) As Double

    Public Const PrecioPrivada_Encamamiento = 350
    Public Const PrecioPrivada_Operacion = 550
    Public Const PrecioPrivada_Maternidad = 450
    Public Const PrecioSemiPrivada_Encamamiento = 250
    Public Const PrecioSemiPrivada_Operacion = 400
    Public Const PrecioSemiPrivada_Maternidad = 350
    Public Const PrecioNoPrivada_Encamamiento = 150
    Public Const PrecioNoPrivada_Operacion = 300
    Public Const PrecioNoPrivada_Maternidad = 250
    Public Const DescuentoEfectivo = 0.15
    Public Const DescuentoCheque = 0.15
    Public Const DescuentoTarjetaDebido = 0.08
    Public Const RecargoTarjetaCredito = 0.05

    Sub Limpiar_Entradas()

        'LIMPIA LOS DATOS DE REGISTRO DEL PACIENTE
        Form1.TextBoxPaciente.Clear()
        Form1.TextBoxNIT.Clear()
        Form1.TextBoxDíasHospitalizado.Text = ""
        Form1.TextBoxHonorarios.Text = ""

        'LIMPIAR LOS INGRESOS DE DATOS
        Form1.RBPrivada.Checked = 0
        Form1.RBSemiprivada.Checked = 0
        Form1.RBNoPrivada.Checked = 0
        Form1.CBEncamamiento.Checked = 0
        Form1.CBOperacion.Checked = 0
        Form1.CBMaternidad.Checked = 0
        Form1.ComboBoxPago.Text = ""
        Form1.ComboBoxPago.Focus()
        'OTRA FORMA DE LIMPIAR EL COMBOBOX SERÍA LA SIGUIENTE
        'Form1.ComboBoxPago.SelectedIndex = -1


    End Sub
    Sub Limpiar_Vectores()
        'SE PROCESDE A LIMPIAR LAS LISTBOX UTILIZANDO LA PROPIEDAD Clear() DEL MÉTODO Items.
        Form1.ListBox1.Items.Clear()
        Form1.ListBox2.Items.Clear()
        Form1.ListBox3.Items.Clear()
        Form1.ListBox4.Items.Clear()
        Form1.ListBox5.Items.Clear()
        Form1.ListBox6.Items.Clear()
        Form1.ListBox7.Items.Clear()
        Form1.ListBox8.Items.Clear()
        Form1.ListBox9.Items.Clear()
    End Sub
    Sub Mostrar_Vectores()
        'SE MUESTRA EL CONTENIDO DEL VECTOR EN LA LISTBOX
        Form1.ListBox1.Items.Add(Paciente(INDICE))
        Form1.ListBox2.Items.Add(NIT(INDICE))
        Form1.ListBox3.Items.Add(DIASHOSPITALIZADO(INDICE))
        Form1.ListBox4.Items.Add(HABITACION(INDICE))
        Form1.ListBox5.Items.Add(SERVICIO(INDICE))
        Form1.ListBox6.Items.Add(PAGO(INDICE))
        Form1.ListBox7.Items.Add(SUBTOTAL(INDICE))
        Form1.ListBox8.Items.Add(DESCUENTO(INDICE))
        Form1.ListBox9.Items.Add(RECARGO(INDICE))
        Form1.ListBox10.Items.Add(TOTAL(INDICE))
    End Sub


End Module
