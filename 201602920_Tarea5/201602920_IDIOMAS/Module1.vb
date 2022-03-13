Imports System.Math
Module Module1
    Public Carnet(7) As String
    Public Nombre(7) As String
    Public Curso(7) As String
    Public Fecha(7) As String
    Public Dias(7) As String
    Public Horas(7) As Double
    Public HorasV(7) As Byte
    Public HorasS(7) As Byte
    Public PRECIO(7) As Double
    Public PagoParcial(7) As Double
    Public PagoTotal(7) As Double
    Public DESCUENTO(7) As Double
    Public descuento1(7) As Double
    Public descuento2(7) As Double
    Public FILA As Byte = 0

    Public Const descEFECTIVO = 2 / 100
    Public Const descCHEQUE = 1.5 / 100
    Public Const descDIAS = 5 / 100
    Public Const PrecioIngles = 150
    Public Const PrecioPortugues = 80
    Public Const PrecioFrances = 125

    Sub REGISTRAR()

        If (FILA < 7) Then
            'SE PROCEDE A VERIFICAR QUE SE HAYA INGRESADO UN NÚMERO DE CARNET
            If (IsNumeric(Form1.TextBoxCarnet.Text <> "")) And (Val(Form1.TextBoxCarnet.Text) > 0) Then
                Carnet(FILA) = Val(Form1.TextBoxCarnet.Text)
            Else
                MsgBox("Por favor ingrese No. de Carnet")
                Form1.TextBoxCarnet.Focus() : Exit Sub
            End If

            'SE PROCEDE A VERIFICAR QUE SE HAYA INGRESADO UN NOMBRE DEL ESTUDIANTE
            If (Form1.TextBoxNombre.Text <> "") Then
                Nombre(FILA) = (Form1.TextBoxNombre.Text)
            Else
                MsgBox("Por favor ingrese Nombre del estudiante")
                Form1.TextBoxNombre.Focus()
                Nombre(FILA) = "" : Exit Sub
            End If

            'SE PROCEDE A VERIFICAR EL CHECKBOX DEL DÍA DEL CURSO SELECCIONADO, SEA VIERNES O SÁBADO
            If Form1.CheckBoxViernes.Checked And Form1.CheckBoxSabado.Checked Then
                Dias(FILA) = "VIERNES Y SABADO"
            ElseIf Form1.CheckBoxViernes.Checked Then
                Dias(FILA) = "VIERNES"
            ElseIf Form1.CheckBoxSabado.Checked Then
                Dias(FILA) = "SABADO"
            Else
                MsgBox("ERROR,no ha seleccionado el día del curso")
                Dias(FILA) = "" : Exit Sub
            End If

            'SE PROCEDE A INDICAR LOS CASOS PARA EL PRECIO DEL CURSO SELECCIONADO EN EL COMBOBOX
            'UTILIZANDO LA INSTRUCCIÓN "SELECT CASE" USANDO LA PROPIEDAD "SELECTEDINDEX"
            'POR LO QUE SE PUEDE UTILIZAR CASE 0; CASE 1; CASE 2; EN CASO CONTRARIO DE USAR "SELECTEDITEM O TEXT"
            'TENDRÍA QUE USAR EL NOMBRE DEL CURSO EN ESPECÍFICO
            Select Case (Form1.ComboBoxCurso.SelectedIndex)
                Case 0 : PRECIO(FILA) = PrecioIngles
                Case 1 : PRECIO(FILA) = PrecioPortugues
                Case 2 : PRECIO(FILA) = PrecioFrances
                Case Else : MsgBox("Por favor, seleccione un curso")
                    Form1.CheckBoxViernes.Focus()
            End Select

            'SE PROCEDE A SELECCIONAR LAS HORAS DEL CURSO
            If (IsNumeric(Form1.TextBoxHorasViernes.Text)) And Val(Form1.TextBoxHorasViernes.Text > 0) Then
                HorasV(FILA) = Val(Form1.TextBoxHorasViernes.Text)
                HorasS(FILA) = Val(Form1.TextBoxHorasSabado.Text)
                Horas(FILA) = HorasV(FILA) + HorasS(FILA)
                PagoParcial(FILA) = Round(PRECIO(FILA) * Horas(FILA), 2)
            Else
                MsgBox("Por favor, seleccione las horas del curso")
                Form1.TextBoxHorasViernes.Focus() : Exit Sub
            End If

            'SE PROCEDE A CALCULAR EL DESCUENTO SEGÚN LA FORMA DE PAGO (EFECTIVO O CHEQUE)
            Select Case (Form1.ComboBoxPago.SelectedIndex)
                Case 0 : descuento1(FILA) = Round(descEFECTIVO * PagoParcial(FILA), 2)
                Case 1 : descuento1(FILA) = Round(descCHEQUE * PagoParcial(FILA), 2)
            End Select
            If Form1.CheckBoxViernes.Checked And Form1.CheckBoxSabado.Checked Then
                descuento2(FILA) = descDIAS * PagoParcial(FILA)
            End If


            DESCUENTO(FILA) = Round(descuento1(FILA) + descuento2(FILA), 2)
            PagoTotal(FILA) = Round(PagoParcial(FILA) - DESCUENTO(FILA), 2)
            Curso(FILA) = (Form1.ComboBoxCurso.SelectedItem)
            Fecha(FILA) = Form1.TextBoxInscripcion.Text

            'SE PROCEDE A MOSTRAR LOS RESULTADO EN EL DATAGRIDVIEW CON LA SIGUIENTE INSTRUCCIÓN
            'PARA LOS VECTORES DE TIPO NUMÉRICO SE UTILIZA "STR" PARA CONVERTIR A STRING
            Form1.DataGridView1.Rows.Add(Str(Carnet(FILA)), Nombre(FILA), Curso(FILA), Fecha(FILA), Str(PRECIO(FILA)), Dias(FILA), Str(Horas(FILA)), Str(PagoParcial(FILA)), Str(DESCUENTO(FILA)), Str(PagoTotal(FILA)))
            FILA = FILA + 1

            'SI SE UTILIZARA LISTBOX, LOS VECTORES SE LLENARÍAN DE LA SIGUIENTE MANERA:
            'Form1.ListCARNET.Items.Add(Carnet(FILA))
            'Form1.ListNOMBRE.Items.Add(Nombre(FILA))
            'Form1.ListCURSO.Items.Add(Curso(FILA))
            'Form1.ListFECHA.Items.Add(Fecha(FILA))
            'Form1.ListPRECIO.Items.Add(PRECIOCURSO(FILA))
            'Form1.ListDIAS.Items.Add(Dias(FILA))
            'Form1.ListHORAS.Items.Add(Horas(FILA))
            'Form1.ListPARCIAL.Items.Add(Round(PAGOPARCIAL(FILA), 2))
            'Form1.ListDESC.Items.Add(Round(DESCUENTO(FILA), 2))
            'Form1.ListTOTAL.Items.Add(Round(PAGOTOTAL(FILA), 2))

            'FILA = FILA + 1

            Limpiar_Entradas()
        Else
            MsgBox("INSCRIPCIONES LLENAS")
        End If

        If (FILA = 7) Then
            MsgBox("Vectores llenos")
        End If

    End Sub
    Sub Limpiar_Entradas()
        Form1.TextBoxCarnet.Clear()
        Form1.TextBoxCarnet.Focus()
        Form1.TextBoxNombre.Clear()
        Form1.TextBoxInscripcion.Clear()
        Form1.TextBoxHorasViernes.Clear()
        Form1.TextBoxHorasSabado.Clear()
        Form1.CheckBoxViernes.Checked = False
        Form1.CheckBoxSabado.Checked = False
        Form1.ComboBoxCurso.SelectedIndex = -1
        Form1.ComboBoxPago.Text = ""
    End Sub
    Sub Limpiar_DataGridView()
        FILA = 0
        'SE PROCEDE A LIMPIAR EL DATAGRIDVIEW HACIENDO USO DE LA PROPIEDAD "CLEAR" DEL MÉTODO "ROWS", QUE PERTENECE AL OBJETO "DATAGRIDVIEW1"
        Form1.DataGridView1.Rows.Clear()

        'ListBox1.Items.Clear()
        'ListBox2.Items.Clear()
        'ListBox3.Items.Clear()
        'ListBox4.Items.Clear()
        'ListBox5.Items.Clear()
        'ListBox6.Items.Clear()
        'ListBox7.Items.Clear()
        'ListBox8.Items.Clear()
        'ListBox9.Items.Clear()


    End Sub

    'SE PODRÍA USAR LA SIGUIENTE FORMA SI SE UTILIZARAN LISTBOXS, MODIFICANDO EL NOMBRE DE LOS LISTBOXS CORRESPONDIENTES.
    'Sub limpiar_listboxYVectores()
    'Form1.ListCARNET.Items.Clear()
    'Form1.ListNOMBRE.Items.Clear()
    'Form1.ListFECHA.Items.Clear()
    'Form1.ListCURSO.Items.Clear()
    'Form1.ListPRECIO.Items.Clear()
    'Form1.ListDIAS.Items.Clear()
    'Form1.ListHORAS.Items.Clear()
    'Form1.ListPARCIAL.Items.Clear()
    'Form1.ListDESCUENTO.Items.Clear()
    'Form1.ListTOTAL.Items.Clear()
    'FILA = 0
    'Form1.TextBox1.Focus()
    'End Sub

    Sub SALIR()
        If MsgBox("¿DESEA SALIR DEL PROCESO DE INSCRIPCIÓN?", vbQuestion + vbYesNo, "salir") = vbYes Then
            Form1.Close()
        End If
    End Sub

End Module
