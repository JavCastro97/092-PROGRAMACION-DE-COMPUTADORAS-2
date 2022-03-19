Imports System.Math
Public Class Form1

    Private Sub CALCULARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CALCULARToolStripMenuItem.Click
        'SE VERIFICAN DATOS DE ENTRADAS
        If ComboBox1.SelectedIndex = -1 Or ComboBox2.SelectedIndex = -1 Then
            MsgBox("Por favor, seleccione las especificaciones del tamaño del sillón y su material")
            Exit Sub
        End If

        If Contador < 8 Then
            REGISTROVENTA(Contador) = Contador + 1
            TAMAÑO(Contador) = ComboBox1.SelectedItem
            MATERIAL(Contador) = ComboBox2.SelectedItem

            Select Case TAMAÑO(Contador)
                'SI SE SELECCIONA EL TAMAÑO "SOFÁ" Y MATERIAL (CUERO Y CUERINA)
                Case "SOFA"
                    Select Case MATERIAL(Contador)
                        Case "CUERO"
                            'Cantidad de yardas para el sofá = 8 yardas
                            PRECIOMANODEOBRA(Contador) = PrecioSofa
                            PRECIOCOSTO(Contador) = Round(8 * PrecioCuero + PRECIOMANODEOBRA(Contador), 2)
                            PRECIOVENTA(Contador) = Round(PRECIOCOSTO(Contador) * 1.65, 2)

                        Case "CUERINA"
                            PRECIOMANODEOBRA(Contador) = PrecioSofa
                            PRECIOCOSTO(Contador) = Round(8 * PrecioCuerina + PRECIOMANODEOBRA(Contador), 2)
                            PRECIOVENTA(Contador) = Round(PRECIOCOSTO(Contador) * 1.65, 2)
                    End Select

                    'SI SE SELECCIONA EL TAMAÑO "INDIVIDUAL" Y MATERIAL (CUERO Y CUERINA)
                Case "INDIVIDUAL"
                    Select Case MATERIAL(Contador)
                        Case "CUERO"
                            'Cantidad de yardas para el individual = 3.5 yardas
                            PRECIOMANODEOBRA(Contador) = PrecioIndividual
                            PRECIOCOSTO(Contador) = Round(3.5 * PrecioCuero + PRECIOMANODEOBRA(Contador), 2)
                            PRECIOVENTA(Contador) = Round(PRECIOCOSTO(Contador) * 1.65, 2)

                        Case "CUERINA"
                            PRECIOMANODEOBRA(Contador) = PrecioIndividual
                            PRECIOCOSTO(Contador) = Round(3.5 * PrecioCuerina + PRECIOMANODEOBRA(Contador), 2)
                            PRECIOVENTA(Contador) = Round(PRECIOCOSTO(Contador) * 1.65, 2)
                    End Select

                    'SI SE SELECCIONA EL TAMAÑO "DOBLE" Y MATERIAL (CUERO Y CUERINA)
                Case "DOBLE"
                    Select Case MATERIAL(Contador)
                        Case "CUERO"
                            'Cantidad de yardas para el doble = 6 yardas
                            PRECIOMANODEOBRA(Contador) = PrecioDoble
                            PRECIOCOSTO(Contador) = Round(6 * PrecioCuero + PRECIOMANODEOBRA(Contador), 2)
                            PRECIOVENTA(Contador) = Round(PRECIOCOSTO(Contador) * 1.65, 2)

                        Case "CUERINA"
                            PRECIOMANODEOBRA(Contador) = PrecioDoble
                            PRECIOCOSTO(Contador) = Round(6 * PrecioCuerina + PRECIOMANODEOBRA(Contador), 2)
                            PRECIOVENTA(Contador) = Round(PRECIOCOSTO(Contador) * 1.65, 2)
                    End Select
            End Select
            PRECIOVENTA(Contador) = Round(PRECIOCOSTO(Contador) * 1.65, 2)
            DataGridView1.Rows.Add(REGISTROVENTA(Contador), TAMAÑO(Contador), MATERIAL(Contador), Val(PRECIOMANODEOBRA(Contador)), Val(PRECIOCOSTO(Contador)), Val(PRECIOVENTA(Contador)))
            Contador = Contador + 1
        Else
            MsgBox("Se ha llegado al límite de los registros de venta de muebles")
        End If
    End Sub


    Private Sub LIMPIARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LIMPIARToolStripMenuItem.Click
        Call Limpiar_Vectores()
    End Sub


    Private Sub LIMPIARGRIDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LIMPIARGRIDToolStripMenuItem.Click
        Call Limpiar_DataGridView1()
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SALIRToolStripMenuItem.Click
        Call Salir()
    End Sub

End Class
