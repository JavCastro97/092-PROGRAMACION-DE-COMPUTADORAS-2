Public Class Form1
    Private Sub ButtonCalcular_Click(sender As Object, e As EventArgs) Handles ButtonCalcular.Click
        Form2.Show()
        Me.Hide()

        If UCase(TBCantidadPasajeros.Text = "") Then
            MsgBox("ERROR, USTED NO HA INGRESADO UN CANTIDAD DE PASAJEROS VÁLIDA")
            TBCantidadPasajeros.Focus()
        Else
            CantidadPasajeros = Val(TBCantidadPasajeros.Text)
        End If

        If RBAvioneta.Checked = False And RBJet.Checked = False And RBHelicoptero.Checked = False Then
            MsgBox("NO HA SELECCIONADO EL TIPO DE AERONAVE")
        End If
        If CheckBoxCostaSur.Checked = False And CheckBoxIzabal.Checked = False And CheckBoxPeten.Checked = False Then
            MsgBox("NO HA SELECCIONADO EL DESTINO DE VUELO")
        End If

        'Datos para Tipo de Aeronave AVIONETA
        If (RBAvioneta.Checked) Then
            If RBAvioneta.Checked And CheckBoxCostaSur.Checked And CheckBoxIzabal.Checked And CheckBoxPeten.Checked Then
                SubtotalVuelo = (CantidadPasajeros * PrecioAvionetaCostaSur) + (CantidadPasajeros * PrecioAvionetaIzabal) + (CantidadPasajeros * PrecioAvionetaPeten)
                DescuentoVuelo = SubtotalVuelo * 0.1
                TotalVuelo = SubtotalVuelo - DescuentoVuelo

                Form2.TBSubtotal.Text = Str(Math.Round(SubtotalVuelo, 2))
                Form2.TBDescuento.Text = Str(Math.Round(DescuentoVuelo, 2))
                Form2.TBTotal.Text = Str(Math.Round(TotalVuelo, 2))


            ElseIf (CheckBoxCostaSur.Checked) Then
                SubtotalVuelo = (CantidadPasajeros * PrecioAvionetaCostaSur)
                DescuentoVuelo = 0.00
                TotalVuelo = SubtotalVuelo
                Form2.TBSubtotal.Text = Str(Math.Round(SubtotalVuelo, 2))
                Form2.TBDescuento.Text = Str(Math.Round(DescuentoVuelo, 2))
                Form2.TBTotal.Text = Str(Math.Round(TotalVuelo, 2))


            ElseIf (CheckBoxIzabal.Checked) Then
                SubtotalVuelo = (CantidadPasajeros * PrecioAvionetaCostaSur)
                DescuentoVuelo = 0.00
                TotalVuelo = SubtotalVuelo

                Form2.TBSubtotal.Text = Str(Math.Round(SubtotalVuelo, 2))
                Form2.TBDescuento.Text = Str(Math.Round(DescuentoVuelo, 2))
                Form2.TBTotal.Text = Str(Math.Round(TotalVuelo, 2))


            ElseIf (RBAvioneta.Checked) And (CheckBoxPeten.Checked) Then
                SubtotalVuelo = (CantidadPasajeros * PrecioAvionetaPeten)
                DescuentoVuelo = 0.00
                TotalVuelo = SubtotalVuelo

                Form2.TBSubtotal.Text = Str(Math.Round(SubtotalVuelo, 2))
                Form2.TBDescuento.Text = Str(Math.Round(DescuentoVuelo, 2))
                Form2.TBTotal.Text = Str(Math.Round(TotalVuelo, 2))
            End If
        End If

        'Datos para Tipo de Aeronave JET
        If RBJet.Checked Then
            If (RBJet.Checked) And (CheckBoxIzabal.Checked) And (CheckBoxPeten.Checked) Then
                SubtotalVuelo = (CantidadPasajeros * PrecioJetIzabal) + (CantidadPasajeros * PrecioJetPeten)
                DescuentoVuelo = (SubtotalVuelo * 0.02)
                TotalVuelo = SubtotalVuelo - DescuentoVuelo

                Form2.TBSubtotal.Text = Str(Math.Round(SubtotalVuelo, 2))
                Form2.TBDescuento.Text = Str(Math.Round(DescuentoVuelo, 2))
                Form2.TBTotal.Text = Str(Math.Round(TotalVuelo, 2))

            ElseIf (CheckBoxCostaSur.Checked) Then
                SubtotalVuelo = (CantidadPasajeros * PrecioJetCostaSur)
                DescuentoVuelo = 0.00
                TotalVuelo = SubtotalVuelo

                Form2.TBSubtotal.Text = Str(Math.Round(SubtotalVuelo, 2))
                Form2.TBDescuento.Text = Str(Math.Round(DescuentoVuelo, 2))
                Form2.TBTotal.Text = Str(Math.Round(TotalVuelo, 2))

            ElseIf (CheckBoxIzabal.Checked) Then
                SubtotalVuelo = (CantidadPasajeros * PrecioJetCostaSur)
                DescuentoVuelo = 0.00
                TotalVuelo = SubtotalVuelo

                Form2.TBSubtotal.Text = Str(Math.Round(SubtotalVuelo, 2))
                Form2.TBDescuento.Text = Str(Math.Round(DescuentoVuelo, 2))
                Form2.TBTotal.Text = Str(Math.Round(TotalVuelo, 2))

            ElseIf (CheckBoxPeten.Checked) Then
                SubtotalVuelo = (CantidadPasajeros * PrecioJetPeten)
                DescuentoVuelo = 0.00
                TotalVuelo = SubtotalVuelo

                Form2.TBSubtotal.Text = Str(Math.Round(SubtotalVuelo, 2))
                Form2.TBDescuento.Text = Str(Math.Round(DescuentoVuelo, 2))
                Form2.TBTotal.Text = Str(Math.Round(TotalVuelo, 2))
            End If
        End If

        'Datos para Tipo de Aeronave HELICÓPTERO
        If (RBHelicoptero.Checked) Then
            If (RBHelicoptero.Checked) And (CheckBoxCostaSur.Checked) Then
                SubtotalVuelo = (CantidadPasajeros * PrecioHelicopteroCostaSur)
                DescuentoVuelo = 0.00
                TotalVuelo = SubtotalVuelo
                Form2.TBSubtotal.Text = Str(Math.Round(SubtotalVuelo, 2))
                Form2.TBDescuento.Text = Str(Math.Round(DescuentoVuelo, 2))
                Form2.TBTotal.Text = Str(Math.Round(TotalVuelo, 2))


            ElseIf (CheckBoxIzabal.Checked) Then
                SubtotalVuelo = (CantidadPasajeros * PrecioHelicopteroCostaSur)
                DescuentoVuelo = 0.00
                TotalVuelo = SubtotalVuelo

                Form2.TBSubtotal.Text = Str(Math.Round(SubtotalVuelo, 2))
                Form2.TBDescuento.Text = Str(Math.Round(DescuentoVuelo, 2))
                Form2.TBTotal.Text = Str(Math.Round(TotalVuelo, 2))


            ElseIf (CheckBoxPeten.Checked) Then
                SubtotalVuelo = (CantidadPasajeros * PrecioHelicopteroPeten)
                DescuentoVuelo = 0.00
                TotalVuelo = SubtotalVuelo

                Form2.TBSubtotal.Text = Str(Math.Round(SubtotalVuelo, 2))
                Form2.TBDescuento.Text = Str(Math.Round(DescuentoVuelo, 2))
                Form2.TBTotal.Text = Str(Math.Round(TotalVuelo, 2))
            End If
        End If
    End Sub

    Private Sub TBCantidadPasajeros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBCantidadPasajeros.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub ButtonLimpiar_Click(sender As Object, e As EventArgs) Handles ButtonLimpiar.Click
        Limpiar()
    End Sub

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        If MsgBox("¿Está seguro que desea salir?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End
        End If
        Close()
    End Sub
End Class
