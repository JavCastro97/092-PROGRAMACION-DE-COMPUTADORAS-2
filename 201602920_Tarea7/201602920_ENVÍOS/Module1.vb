Imports System.Math

Module Module1
    Public Nombre(10) As String
    Public Paquete(10) As String
    Public Valor_Paquete(10) As Double
    Public Envio(10) As String
    Public costo_envio(10) As Double
    Public NoTARJETA(10) As String
    Public Peso(10) As Double

    Public pago_parcial(10) As Double
    Public pagoTOTALQ(10) As Double

    Public MATRIZ(10, 9) As String

    Public FILA As Byte = 0

    Sub ESTADISTICAS()
        Resultados_Adicionales.Show()
        Form1.Hide()
    End Sub


    Sub SALIR()
        If (MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            Form1.Close()
        End If
    End Sub
    Sub LIMPIAR_ENTRADAS()
        Form1.ComboBox1.SelectedIndex = -1
        Form1.ComboBox2.SelectedIndex = -1
        Form1.TextBox1.Text = ""
        Form1.TextBox2.Text = ""
        Form1.TextBox3.Text = ""

    End Sub

    Sub MOSTRAR()
        Dim I, F As Double
        F = 9
        For I = 0 To F
            If (MATRIZ(I, 0) <> Nothing) Then
                Form1.ListBox10.Items.Add(I + 1)
                Form1.ListBox1.Items.Add(MATRIZ(I, 0))
                Form1.ListBox2.Items.Add(MATRIZ(I, 1))
                Form1.ListBox3.Items.Add(MATRIZ(I, 2))
                Form1.ListBox4.Items.Add(MATRIZ(I, 3))
                Form1.ListBox5.Items.Add(MATRIZ(I, 4))
                Form1.ListBox6.Items.Add(MATRIZ(I, 5))
                Form1.ListBox7.Items.Add(MATRIZ(I, 6))
                Form1.ListBox8.Items.Add(MATRIZ(I, 7))
                Form1.ListBox9.Items.Add(MATRIZ(I, 8))

            Else
                Exit For
            End If
        Next I
    End Sub

    Sub LIMPIAR_MATRIZ()
        Dim varifila, varffila As Double
        Dim varicol, varfcol As Double

        varffila = 9
        varfcol = 8

        For varifila = 0 To varffila

            For varicol = 0 To varfcol

                MATRIZ(varifila, varicol) = Nothing

            Next

        Next

        LIMPIAR_LISTBOX()

        FILA = 0

    End Sub

    Sub LIMPIAR_RESULTADOS()
        Resultados_Adicionales.TBTotalLociones.Clear()
        Resultados_Adicionales.TBPaqPlastico.Clear()
        Resultados_Adicionales.TBTotalDocs.Clear()
        Resultados_Adicionales.TBTotalRopa.Clear()

    End Sub

    Sub LIMPIAR_LISTBOX()
        Form1.ListBox10.Items.Clear()
        Form1.ListBox1.Items.Clear()
        Form1.ListBox2.Items.Clear()
        Form1.ListBox3.Items.Clear()
        Form1.ListBox4.Items.Clear()
        Form1.ListBox5.Items.Clear()
        Form1.ListBox6.Items.Clear()
        Form1.ListBox7.Items.Clear()
        Form1.ListBox8.Items.Clear()
        Form1.ListBox9.Items.Clear()
    End Sub
End Module
