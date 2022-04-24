Public Class Form1
    Private Sub ACEPTAR_Click(sender As Object, e As EventArgs) Handles ACEPTAR.Click
        If (FILA <= 6) Then

            NoCLIENTE(FILA) = TBIdentificacion.Text
            VIAJE(FILA) = ComboBox1.Text

            Select Case ComboBox1.Text
                Case "Laguna Brava (Huehuetenango)"

                    VIAJE(FILA) = "Laguna Brava (Huehuetenango)"
                    Precio_Viaje = PLagunaBrava

                Case "Mirador (Petén)"
                    VIAJE(FILA) = "Mirador (Petén)"
                    Precio_Viaje = PMirador

                Case "Biotopo del Quetzal (Baja Verapaz)"
                    VIAJE(FILA) = "Biotopo del Quetzal (Baja Verapaz)"
                    Precio_Viaje = PBiotopoDelQuetzal

                Case Else
                    MsgBox("NO SELECCIONÓ EL DESTINO DE VIAJE")
            End Select

            'Precio_Viaje = TBPrecioViaje.Text
            PRECIO(FILA) = Precio_Viaje
            DIAS(FILA) = Val(TBDías.Text)
            CANTPERSONAS(FILA) = Val(TBCantPersonas.Text)
            TOTAL(FILA) = PRECIO(FILA) * DIAS(FILA) * CANTPERSONAS(FILA)

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

    Private Sub BUSCAR_Click(sender As Object, e As EventArgs) Handles BUSCAR.Click
        BUSCAR_NoCLIENTE
    End Sub

    Private Sub ELIMINAR_Click(sender As Object, e As EventArgs) Handles ELIMINAR.Click
        ELIMINAR_DATOS()

    End Sub

    Private Sub LIMPIAR_Click(sender As Object, e As EventArgs) Handles LIMPIAR.Click
        LIMPIAR_VECTORES()

    End Sub

    Private Sub LimpiarEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click
        LIMPIAR_ENTRADAS()
    End Sub
End Class
