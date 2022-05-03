Module Module1
    Public ETAPA(12) As String
    Public EQUIPO(12) As String
    Public KILOMETROS(12) As Double
    Public TIEMPO(12) As Double
    Public NACIONALIDAD(12) As String
    Public PENALIZACIÓN(12) As Double
    Public reduccion(12) As Double
    Public TIEMPOTOTAL(12) As Double
    Public FILA As Byte = 0
    Public I As Byte

    Sub LIMPIAR_ENTRADAS()
        Form1.TextBox1.Clear()
        Form1.ComboBox1.SelectedIndex = -1
        Form1.NumericUpDown1.Value = ""
        Form1.TextBox3.Clear()
        Form1.RadioButton1.Checked = 0
        Form1.RadioButton2.Checked = 0

    End Sub

    Sub LIMPIAR_ESTADISTICAS()
        Form1.TextBox4.Clear()
        Form1.TextBox5.Clear()
        Form1.TextBox7.Clear()
        Form1.TextBox8.Clear()
        Form1.TextBox9.Clear()
        Form1.TextBox10.Clear()
        Form1.TextBox11.Clear()

    End Sub

    Sub LIMPIAR_VECTORES()
        Form1.DataGridView1.Rows.Clear()

        FILA = 0

        For I = 0 To 11
            ETAPA(I) = Nothing
            EQUIPO(I) = Nothing
            KILOMETROS(I) = Nothing
            TIEMPO(I) = Nothing
            NACIONALIDAD(I) = Nothing
            PENALIZACIÓN(I) = Nothing
            reduccion(I) = Nothing
            TIEMPOTOTAL(I) = Nothing
        Next I

    End Sub

    Sub SALIR()
        If MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Mensaje Salida") = vbYes Then
            Form1.Close()
        Else
            LIMPIAR_ENTRADAS()
            LIMPIAR_ESTADISTICAS()
        End If
    End Sub
End Module
