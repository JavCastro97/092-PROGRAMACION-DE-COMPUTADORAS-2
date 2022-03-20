Imports System.Math
Public Class Form1

    Private Sub CALCULARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CALCULARToolStripMenuItem.Click
        If RBCorto.Checked = False Or RBLargo.Checked = False Then
            MsgBox("POR FAVOR, SELECCIONE EL TIPO DE PLAZO DE EMPEÑO DEL ARTÍCULO")
            Exit Sub
        End If

        If CBTV.Checked = False And CBTelefono.Checked = False And CBLaptop.Checked = False And CBRefrigeradora.Checked Then
            MsgBox("POR FAVOR, SELECCIONE UN ARTÍCULO") : Exit Sub
        End If

        If CLIENTE < 6 Then
            MATRIZ(CLIENTE, 0) = CLIENTE + 1
            'SE PROCEDE A VERIFICAR QUE SE HAYA INGRESADO UN NOMBRE 
            If (TextBoxNombre.Text <> "") Then
                NOMBRE(CLIENTE) = (TextBoxNombre.Text)
                MATRIZ(CLIENTE, 0) = NOMBRE(CLIENTE)
            Else
                MsgBox("Por favor, ingrese un nombre")
                TextBoxNombre.Focus()
                NOMBRE(CLIENTE) = "" : Exit Sub
            End If

            'SE PROCEDE A VERIFICAR QUE SE HAYA INGRESADO UN NOMBRE 
            If (IsNumeric(TextBoxCUI.Text <> "")) And (Val(TextBoxCUI.Text) > 0) Then
                CUI(CLIENTE) = Val(TextBoxCUI.Text)
                MATRIZ(CLIENTE, 1) = CUI(CLIENTE)
            Else
                MsgBox("Por favor ingrese No. de CUI")
                TextBoxCUI.Focus() : Exit Sub
            End If

            'SE PROCEDE A VERIFICAR QUE SE HAYA INGRESADO UNA DIRECCIÓN
            If (TextBoxDireccion.Text <> "") Then
                DIRECCION(CLIENTE) = (TextBoxDireccion.Text)
            Else
                MsgBox("Por favor, ingrese una dirección")
                TextBoxDireccion.Focus()
                DIRECCION(CLIENTE) = "" : Exit Sub
            End If

            Select Case PLAZO(8)
                Case "TV"
                    If RBCorto.Checked Then
                        If CBTV.Checked Then
                            PARCIAL(CLIENTE) = CortoTV
                        ElseIf CBTelefono.Checked Then
                            PARCIAL(CLIENTE) = CortoTelefono
                        ElseIf CBLaptop.Checked Then
                            PARCIAL(CLIENTE) = CortoLaptop
                        ElseIf CBRefrigeradora.Checked Then
                            PARCIAL(CLIENTE) = CortoRefrigeradora
                        Else
                            MsgBox("SELECCIONE UN ARTÍCULO")

                        End If

                    End If
            End Select


            ListBox1.Items.Add(MATRIZ(CLIENTE, 0))
            ListBox2.Items.Add(MATRIZ(CLIENTE, 1))
            ListBox3.Items.Add(MATRIZ(CLIENTE, 2))
            ListBox4.Items.Add(MATRIZ(CLIENTE, 3))
            ListBox5.Items.Add(MATRIZ(CLIENTE, 4))
            ListBox6.Items.Add(MATRIZ(CLIENTE, 5))
            ListBox7.Items.Add(Round(MATRIZ(CLIENTE, 6), 2))
            ListBox8.Items.Add(Round(MATRIZ(CLIENTE, 7), 2))
            ListBox9.Items.Add(Round(MATRIZ(CLIENTE, 8), 2))



            CLIENTE = CLIENTE + 1

            Limpiar_Vectores()
        Else
            MsgBox("INSCRIPCIONES LLENAS")
        End If

        If (CLIENTE = 7) Then
            MsgBox("Vectores llenos")
        End If

    End Sub

    Private Sub LIMPIARLISTBOXToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LIMPIARLISTBOXToolStripMenuItem.Click
        Call Limpiar_Vectores()
    End Sub

    Private Sub LIMPIARMATRIZToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LIMPIARMATRIZToolStripMenuItem.Click
        Call Limpiar_Matriz()
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SALIRToolStripMenuItem.Click
        Call Salir()
    End Sub

End Class
