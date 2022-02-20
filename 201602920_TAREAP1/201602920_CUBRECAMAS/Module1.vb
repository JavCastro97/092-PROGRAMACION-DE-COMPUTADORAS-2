Module Module1
    Public CantidadChumpas As Double
    Public CostoUnitario As Double
    Public CostoTotal As Double
    Public VentaUnitaria As Double
    Public VentaTotal As Double

    Public Const PrecioMOSmall = 65.5
    Public Const PrecioMOMedium = 85.99
    Public Const PrecioMOLarge = 99.99

    Public Const YardaSmall = 2
    Public Const YardaMedium = 2.5
    Public Const YardaLarge = 3
    Public Const PrecioAlgodon = 15.0
    Public Const PrecioSeda = 23.99
    Public Const PrecioLona = 30.99

    Public Const PrecioCostoUnitario = 0.00
    Public Const PrecioCostoTotal = 0.00
    Public Const PrecioVentaUnitaria = 0.00
    Public Const PrecioVentaTotal = 0.00

    Public Sub Calcular()

    End Sub
    Sub Limpiar()
        Form1.TBCantidadChumpas.Visible = False
        Form1.TBCantidadChumpas.Clear()

        Form1.RBSmall.Checked = False
        Form1.RBMedium.Checked = False
        Form1.RBLarge.Checked = False
        Form1.RBAlgodon.Checked = False
        Form1.RBSeda.Checked = False
        Form1.RBLona.Checked = False
    End Sub
    Sub Limpiar_Form2()
        Form2.Hide()
    End Sub
End Module
