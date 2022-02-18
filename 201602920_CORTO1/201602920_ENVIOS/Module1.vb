Module Module1
    Public Const ViaticosRegNorte = 150
    Public Const ViaticosRegSur = 200
    Public Const ViaticosRegOriente = 175
    Public Const ViaticosRegOccidente = 225

    Public Const SegVehículo = 0.03
    Public Const SegAccidente = 0.05

    Public Const SueldoMensajero = 3800
    Public MontoSeguro = 0.00
    Public MontoTotal = 0.00

    Sub Limpiar()
        Form1.TextBoxMensajero.Text = ""
        Form1.TextBoxMontoEnvio = ""
        Form1.RB1RegNorte.Checked = False
        Form1.RB2RegSur.Checked = False
        Form1.RB3RegOriente.Checked = False
        Form1.RB4RegOccidente.Checked = False

        Form1.RB5SegVehículo.Checked = False
        Form1.RB6SegAccidente.Checked = False

        Form1.TextBoxMontoSeguro.Text = ""
        Form1.TextBoxSueldoFinal.Text = ""
    End Sub

End Module
