Public Class Form1

    Private Sub ButtonCalcular_Click(sender As Object, e As EventArgs) Handles ButtonCalcular.Click
        Form2.Show()
        Me.Hide()

        If UCase(TBCantidadChumpas.Text = "") Then
            MsgBox("ERROR, USTED NO HA INGRESADO UN CANTIDAD VÁLIDA")
            TBCantidadChumpas.Focus()
        Else
            CantidadChumpas = Val(TBCantidadChumpas.Text)
        End If

        If RBSmall.Checked = False And RBMedium.Checked = False And RBLarge.Checked = False Then
            MsgBox("NO HA SELECCIONADO EL TAMAÑO DE LA CHUMPA")
        End If
        If RBAlgodon.Checked = False And RBSeda.Checked = False And RBLona.Checked = False Then
            MsgBox("NO HA SELECCIONADO EL TIPO DE MATERIAL DE LA CHUMPA")
        End If

        'Datos para Tipo de tamaño Small
        If (RBSmall.Checked) Then
            If (RBSmall.Checked) And (RBAlgodon.Checked) Then
                CostoUnitario = (1 * PrecioMOSmall) + (YardaSmall * PrecioAlgodon)
                CostoTotal = CantidadChumpas * CostoUnitario
                VentaUnitaria = CostoUnitario + (CostoUnitario * 0.65)
                VentaTotal = CantidadChumpas * VentaUnitaria
                Form2.TextBoxCostoUnitario.Text = Str(Math.Round(CostoUnitario, 2))
                Form2.TextBoxPrecioCosto.Text = Str(Math.Round(CostoTotal, 2))
                Form2.TextBoxVentaUnitaria.Text = Str(Math.Round(VentaUnitaria, 2))
                Form2.TextBoxPrecioVenta.Text = Str(Math.Round(VentaTotal, 2))

            ElseIf RBSeda.Checked Then
                CostoUnitario = (1 * PrecioMOSmall) + (YardaSmall * PrecioSeda)
                CostoTotal = CantidadChumpas * CostoUnitario
                VentaUnitaria = CostoUnitario + (CostoUnitario * 0.65)
                VentaTotal = CantidadChumpas * VentaUnitaria
                Form2.TextBoxCostoUnitario.Text = Str(Math.Round(CostoUnitario, 2))
                Form2.TextBoxPrecioCosto.Text = Str(Math.Round(CostoTotal, 2))
                Form2.TextBoxVentaUnitaria.Text = Str(Math.Round(VentaUnitaria, 2))
                Form2.TextBoxPrecioVenta.Text = Str(Math.Round(VentaTotal, 2))

            ElseIf RBLona.Checked Then
                CostoUnitario = (1 * PrecioMOSmall) + (YardaSmall * PrecioLona)
                CostoTotal = CantidadChumpas * CostoUnitario
                VentaUnitaria = CostoUnitario + (CostoUnitario * 0.65)
                VentaTotal = CantidadChumpas * VentaUnitaria
                Form2.TextBoxCostoUnitario.Text = Str(Math.Round(CostoUnitario, 2))
                Form2.TextBoxPrecioCosto.Text = Str(Math.Round(CostoTotal, 2))
                Form2.TextBoxVentaUnitaria.Text = Str(Math.Round(VentaUnitaria, 2))
                Form2.TextBoxPrecioVenta.Text = Str(Math.Round(VentaTotal, 2))
            End If
        End If

        'Datos para Tipo de tamaño Medium
        If RBMedium.Checked Then
            If RBMedium.Checked And RBAlgodon.Checked Then
                CostoUnitario = (1 * PrecioMOMedium) + (YardaMedium * PrecioAlgodon)
                CostoTotal = CantidadChumpas * CostoUnitario
                VentaUnitaria = CostoUnitario + (CostoUnitario * 0.65)
                VentaTotal = CantidadChumpas * VentaUnitaria
                Form2.TextBoxCostoUnitario.Text = Str(Math.Round(CostoUnitario, 2))
                Form2.TextBoxPrecioCosto.Text = Str(Math.Round(CostoTotal, 2))
                Form2.TextBoxVentaUnitaria.Text = Str(Math.Round(VentaUnitaria, 2))
                Form2.TextBoxPrecioVenta.Text = Str(Math.Round(VentaTotal, 2))

            ElseIf RBSeda.Checked Then
                CostoUnitario = (1 * PrecioMOMedium) + (YardaMedium * PrecioSeda)
                CostoTotal = CantidadChumpas * CostoUnitario
                VentaUnitaria = CostoUnitario + (CostoUnitario * 0.65)
                VentaTotal = CantidadChumpas * VentaUnitaria
                Form2.TextBoxCostoUnitario.Text = Str(Math.Round(CostoUnitario, 2))
                Form2.TextBoxPrecioCosto.Text = Str(Math.Round(CostoTotal, 2))
                Form2.TextBoxVentaUnitaria.Text = Str(Math.Round(VentaUnitaria, 2))
                Form2.TextBoxPrecioVenta.Text = Str(Math.Round(VentaTotal, 2))

            ElseIf RBLona.Checked Then
                CostoUnitario = (1 * PrecioMOMedium) + (YardaMedium * PrecioLona)
                CostoTotal = CantidadChumpas * CostoUnitario
                VentaUnitaria = CostoUnitario + (CostoUnitario * 0.65)
                VentaTotal = CantidadChumpas * VentaUnitaria
                Form2.TextBoxCostoUnitario.Text = Str(Math.Round(CostoUnitario, 2))
                Form2.TextBoxPrecioCosto.Text = Str(Math.Round(CostoTotal, 2))
                Form2.TextBoxVentaUnitaria.Text = Str(Math.Round(VentaUnitaria, 2))
                Form2.TextBoxPrecioVenta.Text = Str(Math.Round(VentaTotal, 2))
            End If
        End If

        'Datos para Tipo de tamaño Large
        If RBLarge.Checked Then
            If RBLarge.Checked And RBAlgodon.Checked Then
                CostoUnitario = (1 * PrecioMOLarge) + (YardaLarge * PrecioAlgodon)
                CostoTotal = CantidadChumpas * CostoUnitario
                VentaUnitaria = CostoUnitario + (CostoUnitario * 0.65)
                VentaTotal = CantidadChumpas * VentaUnitaria
                Form2.TextBoxCostoUnitario.Text = Str(Math.Round(CostoUnitario, 2))
                Form2.TextBoxPrecioCosto.Text = Str(Math.Round(CostoTotal, 2))
                Form2.TextBoxVentaUnitaria.Text = Str(Math.Round(VentaUnitaria, 2))
                Form2.TextBoxPrecioVenta.Text = Str(Math.Round(VentaTotal, 2))

            ElseIf RBSeda.Checked Then
                CostoUnitario = (1 * PrecioMOLarge) + (YardaLarge * PrecioSeda)
                CostoTotal = CantidadChumpas * CostoUnitario
                VentaUnitaria = CostoUnitario + (CostoUnitario * 0.65)
                VentaTotal = CantidadChumpas * VentaUnitaria
                Form2.TextBoxCostoUnitario.Text = Str(Math.Round(CostoUnitario, 2))
                Form2.TextBoxPrecioCosto.Text = Str(Math.Round(CostoTotal, 2))
                Form2.TextBoxVentaUnitaria.Text = Str(Math.Round(VentaUnitaria, 2))
                Form2.TextBoxPrecioVenta.Text = Str(Math.Round(VentaTotal, 2))

            ElseIf RBLona.Checked Then
                CostoUnitario = (1 * PrecioMOLarge) + (YardaLarge * PrecioLona)
                CostoTotal = CantidadChumpas * CostoUnitario
                VentaUnitaria = CostoUnitario + (CostoUnitario * 0.65)
                VentaTotal = CantidadChumpas * VentaUnitaria
                Form2.TextBoxCostoUnitario.Text = Str(Math.Round(CostoUnitario, 2))
                Form2.TextBoxPrecioCosto.Text = Str(Math.Round(CostoTotal, 2))
                Form2.TextBoxVentaUnitaria.Text = Str(Math.Round(VentaUnitaria, 2))
                Form2.TextBoxPrecioVenta.Text = Str(Math.Round(VentaTotal, 2))
            End If
        End If
    End Sub

    Private Sub ButtonLimpiar_Click(sender As Object, e As EventArgs) Handles ButtonLimpiar.Click
        Limpiar()
    End Sub

    Private Sub BSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        If MsgBox("¿Está seguro que desea salir?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End
        End If
        Close()
    End Sub

    Private Sub TBCantidadChumpas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBCantidadChumpas.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

End Class
