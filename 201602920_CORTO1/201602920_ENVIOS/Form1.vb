Public Class Form1
    Public MontoSeguro As Double, SueldoFinal As Double

    Public Sub B1Calcular_Click(sender As Object, e As EventArgs) Handles B1Calcular.Click
        If UCase(TextBoxMensajero.Text = "") Then
            MsgBox("ERROR, NO INGRESÓ NOMBRE DE CLIENTE VÁLIDO")
            TextBoxMensajero.Focus()
            Exit Sub
        End If


        If RB1RegNorte.Checked Or RB2RegSur.Checked Or RB3RegOriente.Checked Or RB4RegOccidente.Checked Then
            'Datos para Región Norte
            If (RB1RegNorte.Checked) Then
                If RB5SegVehículo.Checked Then
                    MontoSeguro = SueldoMensajero * SegVehículo
                    SueldoFinal = ViaticosRegNorte + SueldoMensajero
                    TextBoxMontoSeguro.Text = Str(Math.Round(MontoSeguro, 2))
                    TextBoxSueldoFinal.Text = Str(Math.Round(SueldoFinal, 2))
                ElseIf RB1RegNorte.Checked Then
                    MontoSeguro = SueldoMensajero * SegAccidente
                    SueldoFinal = ViaticosRegNorte + SueldoMensajero
                    TextBoxMontoSeguro.Text = Str(Math.Round(MontoSeguro, 2))
                    TextBoxSueldoFinal.Text = Str(Math.Round(SueldoFinal, 2))
                End If
            End If


            'Datos para Región Sur
            If (RB2RegSur.Checked) Then
                If RB5SegVehículo.Checked Then
                    MontoSeguro = SueldoMensajero * SegVehículo
                    SueldoFinal = ViaticosRegSur + SueldoMensajero
                    TextBoxMontoSeguro.Text = Str(Math.Round(MontoSeguro, 2))
                    TextBoxSueldoFinal.Text = Str(Math.Round(SueldoFinal, 2))
                ElseIf RB6SegAccidente.Checked Then
                    MontoSeguro = SueldoMensajero * SegAccidente
                    MontoTotal = ViaticosRegSur + SueldoMensajero
                    TextBoxMontoSeguro.Text = Str(Math.Round(MontoSeguro, 2))
                    TextBoxSueldoFinal.Text = Str(Math.Round(SueldoFinal, 2))
                End If
            End If


            'Datos para Región Oriente
            If (RB3RegOriente.Checked) Then
                If RB5SegVehículo.Checked Then
                    MontoSeguro = SueldoMensajero * SegVehículo
                    SueldoFinal = ViaticosRegOriente + SueldoMensajero
                    TextBoxMontoSeguro.Text = Str(Math.Round(MontoSeguro, 2))
                    TextBoxSueldoFinal.Text = Str(Math.Round(SueldoFinal, 2))
                ElseIf RB6SegAccidente.Checked Then
                    MontoSeguro = SueldoMensajero * SegAccidente
                    SueldoFinal = ViaticosRegOriente + SueldoMensajero
                    TextBoxMontoSeguro.Text = Str(Math.Round(MontoSeguro, 2))
                    TextBoxSueldoFinal.Text = Str(Math.Round(SueldoFinal, 2))
                End If
            End If


            'Datos para Región Occidente
            If (RB4RegOccidente.Checked) Then
                If RB5SegVehículo.Checked Then
                    MontoSeguro = SueldoMensajero * SegVehículo
                    SueldoFinal = ViaticosRegOccidente + SueldoMensajero
                    TextBoxMontoSeguro.Text = Str(Math.Round(MontoSeguro, 2))
                    TextBoxSueldoFinal.Text = Str(Math.Round(SueldoFinal, 2))
                ElseIf RB6SegAccidente.Checked Then
                    MontoSeguro = SueldoMensajero * SegAccidente
                    SueldoFinal = ViaticosRegOccidente + SueldoMensajero
                    TextBoxMontoSeguro.Text = Str(Math.Round(MontoSeguro, 2))
                    TextBoxSueldoFinal.Text = Str(Math.Round(SueldoMensajero, 2))
                End If
            End If
        End If
    End Sub
    Private Sub TextBoxMontoSeguro_EnabledChanged(sender As Object, e As EventArgs) Handles TextBoxMontoSeguro.EnabledChanged
        MontoSeguro = 0.00
    End Sub

    Private Sub TextBoxSueldoFinal_EnabledChanged(sender As Object, e As EventArgs) Handles TextBoxSueldoFinal.EnabledChanged
        SueldoFinal = 0.00
    End Sub
    Private Sub B2Limpiar_Click(sender As Object, e As EventArgs) Handles B2Limpiar.Click
        Limpiar()
    End Sub

    Private Sub TextBoxMensajero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxMensajero.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxMontoEnvio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxMontoEnvio.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub B3Salir_Click(sender As Object, e As EventArgs) Handles B3Salir.Click
        If MsgBox("¿Desea salir de la aplicación?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End
        End If
        Close()
    End Sub
End Class
