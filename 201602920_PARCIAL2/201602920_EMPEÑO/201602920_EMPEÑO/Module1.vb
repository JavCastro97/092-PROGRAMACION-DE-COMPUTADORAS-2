Module Module1
    'CONSTANTES PARA CORTO PLAZO DEPENDIENDO EL ARTÍCULO
    Public Const CortoTV = 250.0
    Public Const CortoTelefono = 550.0
    Public Const CortoLaptop = 770.0
    Public Const CortoRefrigeradora = 1000.0

    'CONSTANTES PARA LARGO PLAZO DEPENDIENDO EL ARTÍCULO
    Public Const LargoTV = 300.0
    Public Const LargoTelefono = 600.0
    Public Const LargoLaptop = 800.0
    Public Const LargoRefrigeradora = 1200
    Public Const descuentoCPTVR = 0.15
    Public Const descuentoLPTVR = 0.05
    Public Const descuentoCPTL = 0.05
    Public Const descuentoLPTL = 0.1

    Public CLIENTE As Byte = 0
    'Public MATRIZ(6, 8)

    Public NOMBRE(6) As String
    Public CUI(6) As Double
    Public DIRECCION(6) As String
    Public PLAZO(6) As Double
    Public ARTICULO(6) As String
    Public COSTO(6) As Double
    Public PARCIAL(6) As Double
    Public DESCUENTO(6) As Double
    Public TOTAL(6) As Double


    Sub Limpiar_Vectores()
        Form1.RBCorto.Checked = False
        Form1.RBLargo.Checked = False
        Form1.CBTV.Checked = False
        Form1.CBTelefono.Checked = False
        Form1.CBLaptop.Checked = False
        Form1.CBRefrigeradora.Checked = False
        Form1.TextBoxNombre.Text = ""
        Form1.TextBoxCUI.Text = ""
        Form1.TextBoxDireccion.Text = ""
        Form1.TextBoxCosto.Text = 0.0
    End Sub

    'Sub Limpiar_Matriz()
    '    ReDim MATRIZ(6, 8)
    'End Sub


    Sub Salir()
        If MsgBox("¿DESEA REALIZAR ALGÚN OTRO EMPEÑO?", vbQuestion + vbYesNo, "salir") = vbYes Then
            Form1.Close()
        End If
    End Sub

End Module
