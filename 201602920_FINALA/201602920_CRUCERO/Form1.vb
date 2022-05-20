Public Class Form1
    Private Sub CALCULAR_Click(sender As Object, e As EventArgs) Handles CALCULAR.Click
        If (FILA <= 5) Then

            NIT(FILA) = Val(TBNit.Text)
            NOMBRE(FILA) = TBNombre.Text
            PERSONAS(FILA) = Val(TBPersonas.Text)

            'Se utiliza Select Case para seleccionar el tipo de cabina 
            Select Case ComboBox1.Text
                Case "SENCILLA"
                    CABINA(FILA) = "SENCILLA"

                Case "DOBLE"
                    CABINA(I) = "DOBLE"

                Case "COMPARTIDA"
                    CABINA(I) = "COMPARTIDA"

                Case Else
                    MsgBox("NO SELECCIONÓ EL TIPO DE CABINA")
            End Select


            Select Case ComboBox2.Text
                Case "PRIMERA CLASE"
                    CLASE(FILA) = "PRIMERA CLASE"
                    Individual = PSencilla1C
                    Individual = PDoble1C
                    Individual = PCompartida1C

                Case "SEGUNDA CLASE"
                    CLASE(FILA) = "SEGUNDA CLASE"
                    Individual = PSencilla2C
                    Individual = PDoble2C
                    Individual = PCompartida2C

                Case Else
                    MsgBox("NO SELECCIONÓ EL TIPO DE CLASE")
            End Select


            Subtotal = Individual
            PERSONAS(FILA) = Val(TBPersonas.Text)
                PRECIO(FILA) = Subtotal
                TOTAL(FILA) = PERSONAS(FILA) * PRECIO(FILA)


                FILA = FILA + 1
                Limpiar_Entradas()
            End If

            If (FILA = 6) Then
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

    Private Sub LIMPIARENTRADAS_Click(sender As Object, e As EventArgs) Handles LIMPIARENTRADAS.Click
        Limpiar_Entradas()

    End Sub

    Private Sub LIMPIARVECTORES_Click(sender As Object, e As EventArgs) Handles LIMPIARVECTORES.Click
        Limpiar_Vectores()

    End Sub

    Private Sub SALIR_Click(sender As Object, e As EventArgs) Handles SALIR.Click
        If (MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            Close()
        Else
            Limpiar_Entradas()
            Limpiar_Vectores()

        End If
    End Sub

    Private Sub OrdenarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenarToolStripMenuItem.Click
        Dim x As Byte
        Dim y As Byte
        Dim Temp1 As Integer


        For x = 0 To 10
            For y = x + 1 To 5
                'este if es para saber si hay datos para comparar en la siguiente casilla, de lo contrario se sale del ciclo

                If (NIT(x) < NIT(y)) Then
                    Temp1 = NIT(x)
                    NIT(x) = NIT(y)
                    NIT(y) = Temp1
                End If

                Exit For
            Next y
        Next x
    End Sub
End Class
