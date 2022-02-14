Module Module1
    Public CantidadCompra As Double
    Public CantidadVenta As Double
    Public CantidadDolar As Double
    Public CantidadPeso As Double
    Public CantidadEuro As Double
    Public CantidadColon As Double
    Public ComisionCompra As Double
    Public ComisionVenta As Double
    Public TotalCompra As Double
    Public TotalVenta As Double

    Public Const PrecioDolar = 7.69
    Public Const PrecioPesoMexicano = 0.38
    Public Const PrecioEuro = 8.79
    Public Const PrecioColon = 0.012

    Public Const PrecioComisionCompra = 0.025
    Public Const PrecioComisionVenta = 0.03

    Sub Limpiar()
        Form1.CheckBoxCompra.Checked = False
        Form1.CheckBoxVenta.Checked = False

        Form1.TextBoxCompra.Visible = False
        Form1.TextBoxCompra.Clear()
        Form1.TextBoxVenta.Visible = False
        Form1.TextBoxVenta.Clear()
        Form2.TextBoxComisionCompra.Clear()
        Form2.CantidadCompra.Clear()
        Form2.CantidadCompra.Clear()
        Form2.TextBoxComisionVenta.Clear()
        Form2.CantidadVenta.Clear()
        Form2.TextBoxTotalVenta.Clear()

        Form1.RBCDolar.Checked = False
        Form1.RBCPeso.Checked = False
        Form1.RBCEuro.Checked = False
        Form1.RBCColon.Checked = False

        Form1.RBVDolar.Checked = False
        Form1.RBVPeso.Checked = False
        Form1.RBVEuro.Checked = False
        Form1.RBVColon.Checked = False
    End Sub

    Sub Limpiar_Form2()
        Form2.Hide()

    End Sub
End Module
