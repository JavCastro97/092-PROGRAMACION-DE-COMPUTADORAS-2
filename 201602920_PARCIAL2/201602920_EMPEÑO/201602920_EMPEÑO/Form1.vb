Imports System.Math
Public Class Form1

    Private Sub CALCULARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CALCULARToolStripMenuItem.Click
        If CLIENTE <= 6 Then
            CLIENTE = CLIENTE + 1
            'SE PROCEDE A VERIFICAR QUE SE HAYA INGRESADO UN NOMBRE 
            If (TextBoxNombre.Text <> "") Then
                NOMBRE(CLIENTE) = (TextBoxNombre.Text)
            Else
                MsgBox("Por favor, ingrese un nombre")
                TextBoxNombre.Focus()
                NOMBRE(CLIENTE) = "" : Exit Sub
            End If

            'SE PROCEDE A VERIFICAR QUE SE HAYA INGRESADO UN NOMBRE 
            If (IsNumeric(TextBoxCUI.Text <> "")) And (Val(TextBoxCUI.Text) > 0) Then
                CUI(CLIENTE) = Val(TextBoxCUI.Text)

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

            If RBCorto.Checked = False And RBLargo.Checked = False Then
                MsgBox("POR FAVOR, SELECCIONE EL TIPO DE PLAZO DE EMPEÑO DEL ARTÍCULO") : Exit Sub
            End If

            If CBTV.Checked = False And CBTelefono.Checked = False And CBLaptop.Checked = False And CBRefrigeradora.Checked Then
                MsgBox("POR FAVOR, SELECCIONE UN ARTÍCULO") : Exit Sub
            End If

            'CÁLCULOS
            If RBCorto.Checked Then
                If CBTV.Checked And CBTelefono.Checked And CBLaptop.Checked And CBRefrigeradora.Checked Then
                    PARCIAL(CLIENTE) = CortoTV + CortoTelefono + CortoLaptop + CortoRefrigeradora
                    DESCUENTO(CLIENTE) = PARCIAL(CLIENTE) - (descuentoCPTVR + descuentoCPTL)
                    TOTAL(CLIENTE) = PARCIAL(CLIENTE) - DESCUENTO(CLIENTE)

                ElseIf CBTV.Checked And CBRefrigeradora.Checked Then
                    PARCIAL(CLIENTE) = CortoTV + CortoRefrigeradora
                    DESCUENTO(CLIENTE) = PARCIAL(CLIENTE) - (descuentoCPTVR)
                    TOTAL(CLIENTE) = PARCIAL(CLIENTE) - DESCUENTO(CLIENTE)

                ElseIf CBTelefono.Checked And CBLaptop.Checked Then
                    PARCIAL(CLIENTE) = CortoTelefono + CortoLaptop
                    DESCUENTO(CLIENTE) = PARCIAL(CLIENTE) - (descuentoCPTL)
                    TOTAL(CLIENTE) = PARCIAL(CLIENTE) - DESCUENTO(CLIENTE)

                Else
                    MsgBox("SELECCIONE UN ARTÍCULO")
                End If
            End If

            If RBLargo.Checked Then
                If CBTV.Checked And CBTelefono.Checked And CBLaptop.Checked And CBRefrigeradora.Checked Then
                    PARCIAL(CLIENTE) = CortoTV + CortoTelefono + CortoLaptop + CortoRefrigeradora
                    DESCUENTO(CLIENTE) = PARCIAL(CLIENTE) - (descuentoCPTVR + descuentoCPTL)
                    TOTAL(CLIENTE) = PARCIAL(CLIENTE) - DESCUENTO(CLIENTE)

                ElseIf CBTV.Checked And CBRefrigeradora.Checked Then
                    PARCIAL(CLIENTE) = LargoTV + LargoRefrigeradora
                    DESCUENTO(CLIENTE) = PARCIAL(CLIENTE) - (descuentoLPTVR)
                    TOTAL(CLIENTE) = PARCIAL(CLIENTE) - DESCUENTO(CLIENTE)

                ElseIf CBTelefono.Checked And CBLaptop.Checked Then
                    PARCIAL(CLIENTE) = LargoTelefono + LargoLaptop
                    DESCUENTO(CLIENTE) = PARCIAL(CLIENTE) - (descuentoLPTL)
                    TOTAL(CLIENTE) = PARCIAL(CLIENTE) - DESCUENTO(CLIENTE)
                Else
                    MsgBox("SELECCIONE UN ARTÍCULO")
                End If
            End If


            ListBox1.Items.Add(NOMBRE(CLIENTE))
            ListBox2.Items.Add(CUI(CLIENTE))
            ListBox3.Items.Add(DIRECCION(CLIENTE))
            ListBox4.Items.Add(PLAZO(CLIENTE))
            ListBox5.Items.Add(ARTICULO(CLIENTE))
            ListBox6.Items.Add(COSTO(CLIENTE))
            ListBox7.Items.Add(Round(PARCIAL(CLIENTE), 2))
            ListBox8.Items.Add(Round(DESCUENTO(CLIENTE), 2))
            ListBox9.Items.Add(Round(TOTAL(CLIENTE), 2))



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
        'Call Limpiar_Matriz()
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SALIRToolStripMenuItem.Click
        Call Salir()
    End Sub

End Class
