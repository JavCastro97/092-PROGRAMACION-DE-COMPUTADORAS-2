Public Class Form1
    Private Sub CALCULAR_Click(sender As Object, e As EventArgs) Handles CALCULAR.Click

        If (FILA <= 6) Then
            NOMBRE(FILA) = TBNombre.Text
            NIT(FILA) = TBNit.Text
            DIAS(FILA) = Val(TBDías.Text)

            Select Case ComboBox1.Text
                Case "SENCILLA"
                    HABITACION(I) = "SENCILLA"
                Case "SENCILLA"
                    HABITACION(I) = "DOBLE"
                Case "SENCILLA"
                    HABITACION(I) = "CABAÑA"
                Case Else
                    MsgBox("NO SELECCIONO HABITACIÓN")
            End Select

            Select Case ComboBox2.Text
                Case "EFECTIVO"
                    PAGO(I) = "EFECTIVO"
                Case "TARJETA"
                    PAGO(I) = "TARJETA"
                Case "TRANSFERENCIA"
                    PAGO(I) = "TRANSFERENCIA"
                Case "DEPOSITO"
                    PAGO(I) = "DEPOSITO"
                Case Else
                    MsgBox("NO SELECCIONO EL TIPO DE PAGO")
            End Select

            SUBTOTAL(I) = DIAS(I) * HABITACION(I)
            TOTAL(I) = DIAS(I) * HABITACION(I) - DESCUENTO(I) + RECARGO(I)


            FILA = FILA + 1
            LIMPIAR_ENTRADAS()
        End If


        If (FILA = 7) Then
            MsgBox("Vectores llenos")
        End If

    End Sub

    Private Sub MOSTRAR_Click(sender As Object, e As EventArgs) Handles MOSTRAR.Click
        MOSTRAR()

    End Sub

    Private Sub ELIMINAR_Click(sender As Object, e As EventArgs) Handles ELIMINAR.Click
        CONSULTAR()

    End Sub

    Private Sub LIMPIAR_Click(sender As Object, e As EventArgs) Handles LIMPIAR.Click
        LIMPIAR(I)
    End Sub

End Class
