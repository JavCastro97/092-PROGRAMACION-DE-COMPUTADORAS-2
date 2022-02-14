Imports System.Math
Public Class Form1
    Private Sub CheckBoxCompra_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxCompra.CheckedChanged
        If CheckBoxCompra.Checked = True Then
            TextBoxCompra.Visible = True
            TextBoxCompra.Enabled = True
            TextBoxCompra.Focus()
            GroupBoxCompra.Visible = True
        Else
            TextBoxCompra.Visible = False
            TextBoxCompra.Enabled = False
            GroupBoxCompra.Visible = False
        End If
    End Sub

    Private Sub CheckBoxVenta_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxVenta.CheckedChanged
        If CheckBoxVenta.Checked = True Then
            TextBoxVenta.Visible = True
            TextBoxVenta.Enabled = True
            TextBoxVenta.Focus()
            GroupBoxVenta.Visible = True
        Else
            TextBoxVenta.Visible = False
            TextBoxVenta.Enabled = False
            GroupBoxVenta.Visible = False
        End If
    End Sub

    Private Sub ButtonCalcular_Click(sender As Object, e As EventArgs) Handles ButtonCalcular.Click
        Form2.Show()
        Me.Hide()

        If (CheckBoxCompra.Checked) Or (CheckBoxVenta.Checked) Then
            If CheckBoxCompra.Checked Then
                If (IsNumeric(TextBoxCompra.Text) And Val(TextBoxCompra.Text) > 0) Then
                    CantidadCompra = Val(TextBoxCompra.Text)
                Else
                    MsgBox("ERROR, NO HA INGRESADO UN DATO DE COMPRA VÁLIDO")
                    TextBoxCompra.Focus()
                    Exit Sub
                End If
            Else
                CantidadCompra = 0
            End If
        End If

        If (CheckBoxCompra.Checked) Then
            If (CheckBoxCompra.Checked) And (RBCDolar.Checked) Then
                CantidadDolar = CantidadCompra / PrecioDolar
                ComisionCompra = CantidadDolar * PrecioComisionCompra
                TotalCompra = CantidadDolar + ComisionCompra
                Form2.CantidadCompra.Text = Str(Math.Round(CantidadDolar, 2))
                Form2.TextBoxComisionCompra.Text = Str(Math.Round(ComisionCompra, 2))
                Form2.TextBoxTotalCompra.Text = Str(Math.Round(TotalCompra, 2))

            ElseIf (CheckBoxCompra.Checked) And (RBCPeso.Checked) Then
                CantidadPeso = CantidadCompra / PrecioPesoMexicano
                ComisionCompra = CantidadPeso * PrecioComisionCompra
                TotalCompra = CantidadPeso + ComisionCompra
                Form2.CantidadCompra.Text = Str(Math.Round(CantidadPeso, 2))
                Form2.TextBoxComisionCompra.Text = Str(Math.Round(ComisionCompra, 2))
                Form2.TextBoxTotalCompra.Text = Str(Math.Round(TotalCompra, 2))

            ElseIf (CheckBoxCompra.Checked) And (RBCEuro.Checked) Then
                CantidadEuro = CantidadCompra / PrecioEuro
                ComisionCompra = CantidadEuro * PrecioComisionCompra
                TotalCompra = CantidadEuro + ComisionCompra
                Form2.CantidadCompra.Text = Str(Math.Round(CantidadEuro, 2))
                Form2.TextBoxComisionCompra.Text = Str(Math.Round(ComisionCompra, 2))
                Form2.TextBoxTotalCompra.Text = Str(Math.Round(TotalCompra, 2))

            ElseIf (CheckBoxCompra.Checked) And (RBCColon.Checked) Then
                CantidadColon = CantidadCompra / PrecioColon
                ComisionCompra = CantidadColon * PrecioComisionCompra
                TotalCompra = CantidadColon + ComisionCompra
                Form2.CantidadCompra.Text = Str(Math.Round(CantidadColon, 2))
                Form2.TextBoxComisionCompra.Text = Str(Math.Round(ComisionCompra, 2))
                Form2.TextBoxTotalCompra.Text = Str(Math.Round(TotalCompra, 2))
            End If
        End If

        If CheckBoxVenta.Checked Then
            If (IsNumeric(TextBoxVenta.Text) And Val(TextBoxVenta.Text) > 0) Then
                CantidadVenta = Val(TextBoxVenta.Text)
            Else
                MsgBox("ERROR, NO HA INGRESADO UN DATO DE VENTA VÁLIDO")
                TextBoxVenta.Focus()
                Exit Sub
            End If
        Else
            CantidadVenta = 0
        End If

        If (CheckBoxVenta.Checked) Then
            If (CheckBoxVenta.Checked) And (RBVDolar.Checked) Then
                CantidadDolar = CantidadVenta / PrecioDolar
                ComisionVenta = CantidadDolar * PrecioComisionVenta
                TotalVenta = CantidadDolar + ComisionVenta
                Form2.CantidadVenta.Text = Str(Math.Round(CantidadDolar, 2))
                Form2.TextBoxComisionVenta.Text = Str(Math.Round(ComisionVenta, 2))
                Form2.TextBoxTotalVenta.Text = Str(Math.Round(TotalVenta, 2))

            ElseIf (CheckBoxVenta.Checked) And (RBVPeso.Checked) Then
                CantidadPeso = CantidadVenta / PrecioPesoMexicano
                ComisionVenta = CantidadPeso * PrecioComisionVenta
                TotalVenta = CantidadPeso + ComisionVenta
                Form2.CantidadVenta.Text = Str(Math.Round(CantidadPeso, 2))
                Form2.TextBoxComisionVenta.Text = Str(Math.Round(ComisionVenta, 2))
                Form2.TextBoxTotalVenta.Text = Str(Math.Round(TotalVenta, 2))

            ElseIf (CheckBoxVenta.Checked) And (RBVEuro.Checked) Then
                CantidadEuro = CantidadVenta / PrecioEuro
                ComisionVenta = CantidadEuro * PrecioComisionVenta
                TotalVenta = CantidadEuro + ComisionVenta
                Form2.CantidadVenta.Text = Str(Math.Round(CantidadEuro, 2))
                Form2.TextBoxComisionVenta.Text = Str(Math.Round(ComisionVenta, 2))
                Form2.TextBoxTotalVenta.Text = Str(Math.Round(TotalVenta, 2))

            ElseIf (CheckBoxVenta.Checked) And (RBVColon.Checked) Then
                CantidadColon = CantidadVenta / PrecioColon
                ComisionVenta = CantidadColon * PrecioComisionVenta
                TotalVenta = CantidadColon + ComisionVenta
                Form2.CantidadVenta.Text = Str(Math.Round(CantidadColon, 2))
                Form2.TextBoxComisionVenta.Text = Str(Math.Round(ComisionVenta, 2))
                Form2.TextBoxTotalVenta.Text = Str(Math.Round(TotalVenta, 2))

            End If
        End If

        Form2.CalculoTotal()
        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub ButtonLimpiar_Click(sender As Object, e As EventArgs) Handles ButtonLimpiar.Click
        Limpiar()
    End Sub

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        If MsgBox("¿Desea realizar otra transacción?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End
        End If
        Close()
    End Sub

    Private Sub TextBoxCompra_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCompra.TextChanged
        CantidadCompra = 0.00
    End Sub

    Private Sub TextBoxVenta_TextChanged(sender As Object, e As EventArgs) Handles TextBoxVenta.TextChanged
        CantidadVenta = 0.00
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
