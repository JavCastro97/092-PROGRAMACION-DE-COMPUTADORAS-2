Module Module1
    Public TipoAvioneta As Double
    Public TipoJet As Double
    Public TipoHelicoptero As Double
    Public DestinoCostaSur As Double
    Public DestinoIzabal As Double
    Public DestinoPeten As Double
    Public CantidadPasajeros As Double
    Public SubtotalVuelo As Double
    Public DescuentoVuelo As Double
    Public TotalVuelo As Double

    Public Const PrecioAvionetaCostaSur = 150.0
    Public Const PrecioAvionetaIzabal = 175.99
    Public Const PrecioAvionetaPeten = 250.99

    Public Const PrecioJetCostaSur = 250.99
    Public Const PrecioJetIzabal = 325.99
    Public Const PrecioJetPeten = 450.99

    Public Const PrecioHelicopteroCostaSur = 125.99
    Public Const PrecioHelicopteroIzabal = 175.99
    Public Const PrecioHelicopteroPeten = 275.99

    Public Const Subtotal = 0.00
    Public Const Descuento = 0.00
    Public Const Total = 0.00

    Sub Limpiar()
        Form1.TBCantidadPasajeros.Clear()
        Form1.RBAvioneta.Checked = False
        Form1.RBJet.Checked = False
        Form1.RBHelicoptero.Checked = False
        Form1.CheckBoxCostaSur.Checked = False
        Form1.CheckBoxIzabal.Checked = False
        Form1.CheckBoxPeten.Checked = False
        Form2.TBSubtotal.Clear()
        Form2.TBDescuento.Clear()
        Form2.TBTotal.Clear()
    End Sub
    Sub Limpiar_Form2()
        Form2.Hide()
    End Sub
End Module
