Imports System.Math
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Sky")
        ComboBox1.Items.Add("Movistar")
        ComboBox1.Items.Add("Pro Cycling")
        ComboBox1.Items.Add("Pro Team")
    End Sub

    Private Sub GUARDARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GUARDARToolStripMenuItem.Click
        If (FILA <= 11) Then
            ETAPA(FILA) = Val(TextBox1.Text)
            EQUIPO(FILA) = ComboBox1.Text
            KILOMETROS(FILA) = NumericUpDown1.Value
            TIEMPO(FILA) = Val(TextBox3.Text)

            If RadioButton1.Checked Then
                NACIONALIDAD(FILA) = RadioButton1.Text
            End If

            If RadioButton2.Checked Then
                NACIONALIDAD(FILA) = RadioButton2.Text
            End If

            If TIEMPO(FILA) > 120 Then
                PENALIZACIÓN(FILA) = +30
            End If

            If TIEMPO(FILA) > 140 Then
                PENALIZACIÓN(FILA) = +40
            End If

            If TIEMPO(FILA) > 160 Then
                PENALIZACIÓN(FILA) = +50
            End If

            If TIEMPO(FILA) < 85 And ComboBox1.SelectedIndex = 1 Then
                reduccion(FILA) = 15
            End If

            If TIEMPO(FILA) < 85 And ComboBox1.SelectedIndex = 3 Then
                reduccion(FILA) = 10
            End If

            TIEMPOTOTAL(FILA) = TIEMPO(FILA) + PENALIZACIÓN(FILA) - reduccion(FILA)

            FILA = FILA + 1
            LIMPIAR_ENTRADAS()
        End If

        If (FILA = 12) Then
            MsgBox("vectores llenos")
        End If
    End Sub

    Private Sub MOSTRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MOSTRARToolStripMenuItem.Click
        DataGridView1.Rows.Clear()
        For I = 0 To 11

            If (ETAPA(I) <> Nothing) Then
                DataGridView1.Rows.Add((ETAPA(I)), EQUIPO(I), Str(KILOMETROS(I)), Str(TIEMPO(I)), (NACIONALIDAD(I)), Str(PENALIZACIÓN(I)), Str(reduccion(I)), Str(TIEMPOTOTAL(I)))
            Else

                Exit For
            End If
        Next I
    End Sub

    Private Sub CONSULTARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONSULTARToolStripMenuItem.Click
        Dim existe As Boolean = True
        I = 0

        While (I <= 11) And (existe)

            If (ETAPA(I) = (TextBox6.Text)) Then
                existe = False
            Else
                I = I + 1
            End If
        End While

        If (existe = False) Then
            MsgBox("Registro Encontrado exitosamente")

            TextBox1.Text = (ETAPA(I))
            ComboBox1.Text = EQUIPO(I)
            NumericUpDown1.Value = Str(KILOMETROS(I))
            TextBox3.Text = Str(TIEMPO(I))
            If NACIONALIDAD(I) = RadioButton1.Text Then
                RadioButton1.Checked = True
            ElseIf NACIONALIDAD(I) = RadioButton2.Text Then
                RadioButton2.Checked = True
            End If

            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add((ETAPA(I)), EQUIPO(I), Str(KILOMETROS(I)), Str(TIEMPO(I)), (NACIONALIDAD(I)), Str(PENALIZACIÓN(I)), Str(reduccion(I)), Str(TIEMPOTOTAL(I)))

            FILA = I
        Else
            MsgBox("Etapa no encontrada")
            TextBox6.Focus()
        End If
    End Sub

    Private Sub ACTUALIZARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACTUALIZARToolStripMenuItem.Click
        ETAPA(FILA) = Val(TextBox1.Text)
        EQUIPO(FILA) = ComboBox1.Text
        KILOMETROS(FILA) = Val(NumericUpDown1.Text)
        TIEMPO(FILA) = Val(TextBox3.Text)

        If RadioButton1.Checked Then
            NACIONALIDAD(FILA) = RadioButton1.Text
        End If

        If RadioButton2.Checked Then
            NACIONALIDAD(FILA) = RadioButton2.Text
        End If

        If TIEMPO(FILA) > 120 Then
            PENALIZACIÓN(FILA) = +30
        End If

        If TIEMPO(FILA) > 140 Then
            PENALIZACIÓN(FILA) = +40
        End If

        If TIEMPO(FILA) > 160 Then
            PENALIZACIÓN(FILA) = +50
        End If

        If TIEMPO(FILA) < 85 And ComboBox1.SelectedIndex = 1 Then
            reduccion(FILA) = 15
        End If

        If TIEMPO(FILA) < 85 And ComboBox1.SelectedIndex = 3 Then
            reduccion(FILA) = 10
        End If

        TIEMPOTOTAL(FILA) = TIEMPO(FILA) + PENALIZACIÓN(FILA) - reduccion(FILA)

        MsgBox("Registro actualizado correctamente en los vectores")
        FILA = 11
        LIMPIAR_ENTRADAS()
        LIMPIAR_ESTADISTICAS()
    End Sub

    Private Sub ORDENARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ORDENARToolStripMenuItem.Click
        Dim x As Byte
        Dim y As Byte
        Dim Temp1 As Integer


        For x = 0 To 10
            For y = x + 1 To 11
                'este if es para saber si hay datos para comparar en la siguiente casilla, de lo contrario se sale del ciclo

                If (ETAPA(x) > ETAPA(y)) Then
                    Temp1 = ETAPA(x)
                    ETAPA(x) = ETAPA(y)
                    ETAPA(y) = Temp1
                End If

                Exit For


            Next y
        Next x
    End Sub

    Private Sub ELIMINARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ELIMINARToolStripMenuItem.Click
        ETAPA(FILA) = Nothing
        EQUIPO(FILA) = Nothing
        KILOMETROS(FILA) = Nothing
        TIEMPO(FILA) = Nothing
        NACIONALIDAD(FILA) = Nothing
        PENALIZACIÓN(FILA) = Nothing
        reduccion(FILA) = Nothing
        TIEMPOTOTAL(FILA) = Nothing

        For I = FILA To 10
            'en el proceso siguiente se procede a trasladar la fila de abajo hacia la fila actual y
            'así sucesivamente hasta llegar a la última posición menos 1, porque sino se hace así
            'tratará de tomar un valor fuera del rango de los límites de los vectores que es 4 y tratará de accesar la
            'posición 5 que no existe.
            ETAPA(I) = ETAPA(I + 1)
            EQUIPO(I) = EQUIPO(I + 1)
            KILOMETROS(I) = KILOMETROS(I + 1)
            TIEMPO(I) = TIEMPO(I + 1)
            NACIONALIDAD(I) = NACIONALIDAD(I + 1)
            PENALIZACIÓN(I) = PENALIZACIÓN(I + 1)
            reduccion(I) = reduccion(I + 1)
            TIEMPOTOTAL(I) = TIEMPOTOTAL(I + 1)
        Next I
        MsgBox("Registro Eliminado exitosamente")

        ETAPA(FILA) = Nothing
        EQUIPO(FILA) = Nothing
        KILOMETROS(FILA) = Nothing
        TIEMPO(FILA) = Nothing
        NACIONALIDAD(FILA) = Nothing
        PENALIZACIÓN(FILA) = Nothing
        reduccion(FILA) = Nothing
        TIEMPOTOTAL(FILA) = Nothing

        FILA = 11
        LIMPIAR_ENTRADAS()
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub LIMPIARENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARENTRADASToolStripMenuItem.Click
        LIMPIAR_ENTRADAS()
    End Sub

    Private Sub LIMPIARVECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARVECTORESToolStripMenuItem.Click
        LIMPIAR_VECTORES()
    End Sub

    Private Sub ESTADÍSTICASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ESTADÍSTICASToolStripMenuItem.Click
        Dim N45KM As Integer = 0
        Dim kmsky As Double = 0
        Dim kmMOV As Double = 0
        Dim KMprocy As Double = 0
        Dim kmproteam As Double = 0
        Dim TIEMPOGUA As Double
        Dim TIEMPOEXTRA As Double

        Dim TIEMPOGUATE_HORA As Double
        Dim TIEMPOEXTRA_HORA As Double

        For I = 0 To 11
            If (ETAPA(I) <> Nothing) Then

                If NACIONALIDAD(I) = "Guatemalteco" And KILOMETROS(I) > 45 Then
                    N45KM = N45KM + 1
                End If

                Select Case EQUIPO(I)
                    Case "Sky"
                        kmsky = kmsky + Val(DataGridView1.Rows(I).Cells(2).Value)
                    Case "Movistar"
                        kmMOV = kmMOV + Val(DataGridView1.Rows(I).Cells(2).Value)
                    Case "Pro Cycling"
                        KMprocy = KMprocy + Val(DataGridView1.Rows(I).Cells(2).Value)
                    Case "Pro Team"
                        kmproteam = kmproteam + Val(DataGridView1.Rows(I).Cells(2).Value)
                End Select

                Select Case NACIONALIDAD(I)
                    Case "Guatemalteco"
                        TIEMPOGUA = TIEMPOGUA + Val(DataGridView1.Rows(I).Cells(7).Value)
                    Case "Extranjero"
                        TIEMPOEXTRA = TIEMPOEXTRA + Val(DataGridView1.Rows(I).Cells(7).Value)
                End Select
            Else
                Exit For
            End If
        Next I
        TIEMPOGUATE_HORA = Round(TIEMPOGUA / 60, 2)
        TIEMPOEXTRA_HORA = Round(TIEMPOEXTRA / 60, 2)


        TextBox7.Text = Str(N45KM)
        TextBox4.Text = Str(kmsky)
        TextBox5.Text = Str(kmMOV)
        TextBox9.Text = Str(KMprocy)
        TextBox8.Text = Str(kmproteam)
        TextBox11.Text = Str(TIEMPOGUATE_HORA)
        TextBox10.Text = Str(TIEMPOEXTRA_HORA)
    End Sub

    Private Sub LIMPIARESTADÍSTICASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARESTADÍSTICASToolStripMenuItem.Click
        LIMPIAR_ESTADISTICAS()
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        SALIR()
    End Sub

End Class
