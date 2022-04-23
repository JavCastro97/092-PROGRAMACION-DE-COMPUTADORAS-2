Public Class Form1
    Private Sub CALCULAR_Click(sender As Object, e As EventArgs) Handles CALCULAR.Click

        If (FILA <= 6) Then
            NOMBRE(FILA) = TBNombre.Text
            NIT(FILA) = Val(TBNit.Text)
            DIAS(FILA) = Val(TBDías.Text)

            Select Case ComboBox1.Text
                Case "SENCILLA"
                    HABITACION(FILA) = "SENCILLA"
                    SUBTOTAL(FILA) = DIAS(FILA) * PSencilla
                Case "DOBLE"
                    HABITACION(I) = "DOBLE"
                    SUBTOTAL(FILA) = DIAS(FILA) * PDoble
                Case "CABAÑA"
                    HABITACION(I) = "CABAÑA"
                    SUBTOTAL(FILA) = DIAS(FILA) * PCabaña
                Case Else
                    MsgBox("NO SELECCIONO HABITACIÓN")
            End Select

            Select Case ComboBox2.Text
                Case "EFECTIVO"
                    Desc = SUBTOTAL(FILA) * Descuento1
                    Rcg = 0

                Case "TARJETA DE CREDITO/DEBITO"
                    Desc = 0
                    Rcg = SUBTOTAL(FILA) * Recargo1

                Case "TRANSFERENCIA"
                    Desc = 0
                    Rcg = 0
                Case "DEPOSITO"
                    Desc = 0
                    Rcg = 0
                Case Else
                    MsgBox("NO SELECCIONO EL TIPO DE PAGO")
            End Select



            SUBTOTAL(FILA) = DIAS(FILA) * HABITACION(FILA)
            DESCUENTO(FILA) = Desc
            RECARGO(FILA) = Rcg
            TOTAL(FILA) = SUBTOTAL(FILA) - DESCUENTO(FILA) + RECARGO(FILA)


            FILA = FILA + 1
            LIMPIAR_ENTRADAS()
        End If

        If (FILA = 7) Then
            MsgBox("Vectores llenos")
        End If

    End Sub

    Private Sub MOSTRAR_Click(sender As Object, e As EventArgs) Handles MOSTRAR.Click
        MOSTRAR_DATOS()

    End Sub

    Private Sub CONSULTAR_Click(sender As Object, e As EventArgs) Handles CONSULTAR.Click
        CONSULTAR_DATOS()
    End Sub

    Private Sub ELIMINAR_Click(sender As Object, e As EventArgs) Handles ELIMINAR.Click
        ELIMINAR_DATOS()

    End Sub

    Private Sub LIMPIAR_Click(sender As Object, e As EventArgs) Handles LIMPIAR.Click
        LIMPIAR_VECTORES()
    End Sub
End Class
