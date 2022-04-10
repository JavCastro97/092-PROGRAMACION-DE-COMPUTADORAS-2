Imports System.Math
Public Class Form1
    Private Sub ButtonAgregarDatos_Click(sender As Object, e As EventArgs) Handles ButtonAgregarDatos.Click
        TextBox1.Text = InputBox("Ingrese nombre del cliente")
        Nombre(FILA) = TextBox1.Text
        MATRIZ(FILA, 0) = Nombre(FILA)
        TextBox2.Text = Val(InputBox("Ingrese el costo del paquete"))
        Valor_Paquete(FILA) = TextBox2.Text
        MATRIZ(FILA, 2) = Valor_Paquete(FILA)
    End Sub

    Private Sub ButtonDatosEnvio_Click(sender As Object, e As EventArgs) Handles ButtonDatosEnvio.Click
        NoTARJETA(FILA) = InputBox("Ingrese el No.de Tarjeta")
        TextBox3.Text = NoTARJETA(FILA)
    End Sub

    Private Sub ACEPTARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACEPTARToolStripMenuItem.Click
        If FILA <= 9 Then

            Nombre(FILA) = TextBox1.Text
            Valor_Paquete(FILA) = Val(TextBox2.Text)

            Select Case ComboBox1.SelectedIndex
                Case 0
                    Peso(FILA) = Round((1.5 / 100 * Valor_Paquete(FILA)), 2)
                    Paquete(FILA) = "Documentos"
                Case 1
                    Peso(FILA) = Round((6 / 100 * Valor_Paquete(FILA)), 2)
                    Paquete(FILA) = "Ropa"
                Case 2
                    Peso(FILA) = Round((5.5 / 100 * Valor_Paquete(FILA)), 2)
                    Paquete(FILA) = "Articulos pedecederos"
                Case 3
                    Peso(FILA) = Round((4.5 / 100 * Valor_Paquete(FILA)), 2)
                    Paquete(FILA) = "Articulos de plastico"
                Case 4
                    Peso(FILA) = Round((2 / 100 * Valor_Paquete(FILA)), 2)
                    Paquete(FILA) = "Lociones"
                Case Else
                    MsgBox("NO SELECCIONÓ NINGÚN PAQUETE")
                    ComboBox1.Focus()
                    Exit Sub

            End Select

            pago_parcial(FILA) = Round((Valor_Paquete(FILA) + Peso(FILA)), 2)

            Select Case ComboBox2.SelectedIndex
                Case 0
                    costo_envio(FILA) = 50.0
                    Envio(FILA) = "En camión"
                Case 1
                    costo_envio(FILA) = 15.0
                    Envio(FILA) = "En motocicleta"

                Case Else
                    MsgBox("NO SELECCIONÓ EL TIPO DE ENVIO")
                    ComboBox2.Focus()
                    Exit Sub
            End Select

            pagoTOTALQ(FILA) = Round((pago_parcial(FILA) + costo_envio(FILA)), 2)


            MATRIZ(FILA, 0) = Nombre(FILA)
            MATRIZ(FILA, 1) = Paquete(FILA)
            MATRIZ(FILA, 2) = Valor_Paquete(FILA)
            MATRIZ(FILA, 3) = (Peso(FILA))
            MATRIZ(FILA, 4) = (pago_parcial(FILA))
            MATRIZ(FILA, 5) = Envio(FILA)
            MATRIZ(FILA, 6) = (costo_envio(FILA))
            MATRIZ(FILA, 7) = NoTARJETA(FILA)
            MATRIZ(FILA, 8) = (pagoTOTALQ(FILA))

            FILA = FILA + 1

            LIMPIAR_ENTRADAS()

            If FILA = 10 Then
                MsgBox("MATRIZ LLENA")
            End If

        End If
    End Sub
    Private Sub LIMPIARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARToolStripMenuItem.Click
        LIMPIAR_ENTRADAS()

    End Sub

    Private Sub LIMPIARMATRIZToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARMATRIZToolStripMenuItem.Click
        LIMPIAR_MATRIZ()

    End Sub

    Private Sub MOSTRARMATRIZToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MOSTRARMATRIZToolStripMenuItem.Click
        LIMPIAR_LISTBOX()
        MOSTRAR()

    End Sub

    Private Sub ESTADISTICAS_Click(sender As Object, e As EventArgs) Handles ESTADISTICAS.Click
        Resultados_Adicionales.Show()
        'Me.Hide()

    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        SALIR()

    End Sub

End Class

