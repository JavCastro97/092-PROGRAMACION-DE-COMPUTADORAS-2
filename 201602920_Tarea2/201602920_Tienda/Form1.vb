Imports System.Math
Public Class Form1
    Const precioArroz As Double = 2.0
    Const precioFrijol As Double = 1.75
    Const precioAzucar As Double = 2.5
    Const IVA As Double = 0.12

    Dim PagoSinIVA As Double = 0.0
    Dim ValorIVA As Double = 0.0
    Dim PagoConIVA As Double = 0.0
    Dim Descuento As Double = 0.0
    Dim PagoFinal As Double = 0.0

    Private Sub BotonAceptar_Click(sender As Object, e As EventArgs) Handles BotonAceptar.Click
        PagoSinIVA = (Val(TextBoxArroz.Text) * precioArroz) + (Val(TextBoxFrijol.Text) * precioFrijol) + (Val(TextBoxAzucar.Text) * precioAzucar)
        ValorIVA = PagoSinIVA * IVA
        PagoConIVA = PagoSinIVA + ValorIVA
        Descuento = PagoConIVA * 0.025
        PagoFinal = PagoConIVA - Descuento

        LabelR1.Text = PagoSinIVA
        LabelR2.Text = ValorIVA
        LabelR3.Text = PagoConIVA
        LabelR4.Text = Descuento
        LabelR5.Text = PagoFinal
    End Sub

    Private Sub BotonLimpiar_Click(sender As Object, e As EventArgs) Handles BotonLimpiar.Click
        TextBoxArroz.Clear()
        TextBoxFrijol.Clear()
        TextBoxAzucar.Clear()
        LabelR1.Text = 0.0
        LabelR2.Text = 0.0
        LabelR3.Text = 0.0
        LabelR4.Text = 0.0
        LabelR5.Text = 0.0

    End Sub

    Private Sub BotonSalir_Click(sender As Object, e As EventArgs) Handles BotonSalir.Click
        If MsgBox("¿Desea salir de la aplicación?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End
        End If
        Close()
    End Sub

    Private Sub TextBoxArroz_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxArroz.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBoxFrijol_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxFrijol.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBoxAzucar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxAzucar.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class