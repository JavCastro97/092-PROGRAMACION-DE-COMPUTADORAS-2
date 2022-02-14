Public Class Form2
    Public TotalCompra As Double, TotalVenta As Double
    Public Sub CalculoTotal()
        If (Form1.CheckBoxCompra.Checked) Then
            If Form1.RBCDolar.Checked Then
                TotalCompra = CantidadDolar + ComisionCompra
            ElseIf Form1.RBCPeso.Checked Then
                TotalCompra = CantidadPeso + ComisionCompra
            ElseIf Form1.RBCEuro.Checked Then
                TotalCompra = CantidadEuro + ComisionCompra
            ElseIf Form1.RBCColon.Checked Then
                TotalCompra = CantidadColon + ComisionCompra
            Else
                TotalCompra = 0
            End If
        Else
            CantidadDolar = 0
            CantidadPeso = 0
            CantidadEuro = 0
            CantidadColon = 0
        End If

        If (Form1.CheckBoxVenta.Checked) Then
            If Form1.RBVDolar.Checked Then
                TotalVenta = CantidadDolar + ComisionVenta
            ElseIf Form1.RBVPeso.Checked Then
                TotalVenta = CantidadPeso + ComisionVenta
            ElseIf Form1.RBVEuro.Checked Then
                TotalVenta = CantidadEuro + ComisionVenta
            ElseIf Form1.RBVColon.Checked Then
                TotalVenta = CantidadColon + ComisionVenta
            Else
                TotalVenta = 0
            End If
        Else
            CantidadDolar = 0
            CantidadPeso = 0
            CantidadEuro = 0
            CantidadColon = 0
        End If
        CantidadCompra.Text = CantidadDolar

    End Sub
    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Show()
    End Sub

End Class