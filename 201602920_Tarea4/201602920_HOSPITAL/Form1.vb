Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'SE AGREGAN LOS ELEMENTOS AL COMBOBOX1 EN EL MÉTODO DE CARGA (LOAD) DEL FORMULARIO 
        ComboBoxPago.Items.Add("EFECTIVO")
        ComboBoxPago.Items.Add("CHEQUE")
        ComboBoxPago.Items.Add("TARJETA DE CRÉDITO")
        ComboBoxPago.Items.Add("TARJETA DE DÉBITO")
    End Sub
    Private Sub CALCULARToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click
        If UCase(TextBoxPaciente.Text = "") Then
            MsgBox("ERROR, USTED NO HA INGRESADO EL NOMBRE DEL PACIENTE")
            TextBoxPaciente.Focus()
        End If

        'SE MUESTRA EL SIGUIENTE MENSAJE SI NO SE HA SELECCIONADO EL TIPO DE HABITACIÓN
        If RBPrivada.Checked = False And RBSemiprivada.Checked = False And RBNoPrivada.Checked = False Then
            MsgBox("NO HA SELECCIONADO EL TIPO DE HABITACIÓN")
        End If

        'SE MUESTRA EL SIGUIENTE MENSAJE SI NO SE HA SELECCIONADO EL TIPO DE SERVICIO MÉDICO A SOLICITAR
        If CBEncamamiento.Checked = False And CBOperacion.Checked = False And CBMaternidad.Checked = False Then
            MsgBox("NO HA SELECCIONADO EL TIPO DE SERVICIO")
        End If

        If INDICE <= 5 Then
            'SE PROCEDE A GUARDAR LOS DATOS RESPECTIVOS EN CADA VECTOR
            Paciente(INDICE) = Val(TextBoxPaciente.Text)
            NIT(INDICE) = Val(TextBoxNIT.Text)
            DIASHOSPITALIZADO(INDICE) = Val(TextBoxDíasHospitalizado.Text)
            HONORARIOS(INDICE) = Val(TextBoxHonorarios.Text)

            PAGOEFECTIVO(INDICE) = ComboBoxPago.Text
            PAGOCHEQUE(INDICE) = ComboBoxPago.Text
            PAGOTARJETADEBITO(INDICE) = ComboBoxPago.Text
            PAGOTARJETACREDITO(INDICE) = ComboBoxPago.Text

            SUBTOTAL(INDICE) = Math.Round((DIASHOSPITALIZADO(INDICE) * PRECIO(INDICE)), 2)
            DESCUENTO(INDICE) = Math.Round((Val(SUBTOTAL) * Val(DESCUENTO)), 2)
            RECARGO(INDICE) = Math.Round((Val(SUBTOTAL) * Val(RECARGO)), 2)
            TOTAL(INDICE) = Math.Round((Val(SUBTOTAL) - Val(DESCUENTO) + Val(RECARGO)), 2)

            'SE LLAMA AL PROCEDIMIENTO QUE MUESTRA LOS VECTORES EN EL LISTBOX/DATAGRIDVIEW
            Mostrar_Vectores()
            'SE PROCEDE A INCREMENTAR LA VARIABLE ÍNDICE PARA EL SIGUIENTE INGRESO PARA ALMACENAR EN LA SIGUIENTE POSICIÓN DE LOS VECTORES
            INDICE = INDICE + 1
        End If
        'SE PROCEDE A VERIFICAR QUE LA VARIABLE INDICE TENGA EL VALOR DEL ÚLTIMO ÍNDICE DE LOS VECTORES PARA INDICAR QUE ESTÁN LLENOS
        'NOTA: NO SE UTILIZA ELSE EN EL IF ANTERIOR PORQUE SINO SE PUEDE INTENTAR INGRESAR UNO MÁS Y EN ESE CASO, YA INDICA EL MENSAJE DE LLENOS
        If (INDICE = 6) Then
            MsgBox("VECTORES LLENOS")
            Limpiar_Entradas()
        End If

        If RBPrivada.Checked Or RBSemiprivada.Checked Or RBNoPrivada.Checked Then
            If RBPrivada.Checked Then
                SUBTOTAL(INDICE) = DIASHOSPITALIZADO(INDICE) * PrecioPrivada_Encamamiento
                SUBTOTAL(INDICE) = DIASHOSPITALIZADO(INDICE) * PrecioPrivada_Operacion
                SUBTOTAL(INDICE) = DIASHOSPITALIZADO(INDICE) * PrecioPrivada_Maternidad

                DESCUENTO(INDICE) = SUBTOTAL(INDICE) * DescuentoEfectivo
                RECARGO(INDICE) = 0
                TOTAL(INDICE) = SUBTOTAL(INDICE) - DESCUENTO(INDICE) + RECARGO(INDICE)

            ElseIf RBSemiprivada.Checked Then
                SUBTOTAL(INDICE) = DIASHOSPITALIZADO(INDICE) * PrecioSemiPrivada_Encamamiento
                SUBTOTAL(INDICE) = DIASHOSPITALIZADO(INDICE) * PrecioSemiPrivada_Operacion
                SUBTOTAL(INDICE) = DIASHOSPITALIZADO(INDICE) * PrecioSemiPrivada_Maternidad

                DESCUENTO(INDICE) = SUBTOTAL(INDICE) * DescuentoEfectivo
                RECARGO(INDICE) = 0
                TOTAL(INDICE) = SUBTOTAL(INDICE) - DESCUENTO(INDICE) + RECARGO(INDICE)

            ElseIf RBNoPrivada.Checked Then
                SUBTOTAL(INDICE) = DIASHOSPITALIZADO(INDICE) * PrecioNoPrivada_Encamamiento
                SUBTOTAL(INDICE) = DIASHOSPITALIZADO(INDICE) * PrecioNoPrivada_Operacion
                SUBTOTAL(INDICE) = DIASHOSPITALIZADO(INDICE) * PrecioNoPrivada_Maternidad

                DESCUENTO(INDICE) = SUBTOTAL(INDICE) * DescuentoEfectivo
                RECARGO(INDICE) = 0
                TOTAL(INDICE) = SUBTOTAL(INDICE) - DESCUENTO(INDICE) + RECARGO(INDICE)

            End If
        End If

        Select Case ComboBoxPago.SelectedIndex
            Case 0  'EFECTIVO
                DESCUENTO(INDICE) = SUBTOTAL(INDICE) * DescuentoEfectivo
            Case 1  'CHEQUE
                DESCUENTO(INDICE) = SUBTOTAL(INDICE) * DescuentoCheque
            Case 2  'TARJETADEBITO
                DESCUENTO(INDICE) = SUBTOTAL(INDICE) * DescuentoTarjetaDebido
            Case 3  'TARJETACREDITO
                RECARGO(INDICE) = SUBTOTAL(INDICE) * RecargoTarjetaCredito
            Case Else
                MsgBox("ERROR, NO SELECCIONÓ FORMA DE PAGO")
        End Select

        ListBox1.Items.Add(Str(Paciente))
        ListBox2.Items.Add(Str(NIT))
        ListBox3.Items.Add(Str(DIASHOSPITALIZADO))
        ListBox4.Items.Add(Str(HABITACION))
        ListBox5.Items.Add(Str(SERVICIO))
        ListBox6.Items.Add(Str(PAGO))
        ListBox7.Items.Add(Str(SUBTOTAL))
        ListBox8.Items.Add(Str(DESCUENTO))
        ListBox9.Items.Add(Str(RECARGO))
        ListBox10.Items.Add(Str(TOTAL))

    End Sub

    Private Sub LIMPIARENTRADASToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles LIMPIARENTRADASToolStripMenuItem.Click
        Limpiar_Entradas()
    End Sub

    Private Sub LIMPIARVECTORESToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles LIMPIARVECTORESToolStripMenuItem.Click
        'LIMPIA LA VARIABLE QUE CONTROLA LOS INGRESOS DE LOS VECTORES
        INDICE = 0
        Limpiar_Vectores()
    End Sub

    Private Sub SALIRToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If (MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            Me.Close()
            End
        Else
            Limpiar_Entradas()
            Limpiar_Vectores()
        End If
    End Sub

End Class
