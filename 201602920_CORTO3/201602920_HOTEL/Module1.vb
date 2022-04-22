Module Module1

    'Variable que se utilizará para controlar los ingresos en cada fila de los vectores
    Public FILA As Byte = 0
    'Variable que se utilizará para algunos de los ciclos For de ciertos procesos
    Public I As Byte

    'Declaración de los vectores donde se almacenarán cada uno de los datos de ingreso, y el resultado
    'El proceso será para 5 estudiantes
    Public NOMBRE(7) As String
    Public NIT(7) As Integer
    Public DIAS(7) As Double
    Public HABITACION(7) As String
    Public PAGO(7) As String
    Public SUBTOTAL(7) As Double
    Public DESCUENTO(7) As Double
    Public RECARGO(7) As Double
    Public TOTAL(7) As Double

    'Precios de las habitaciones por día hospedado.
    Public Const PSencilla = 250
    Public Const PDoble = 400
    Public Const PCabaña = 650
    Public Const Descuento1 = 0.15 'Descuento por pago en efectivo
    Public Const Descuento2 = 0.03 'Recargo por pago con tarjeta de crédito/débito
    Public Const Descuento3 = 0 'No hay descuento ni recargo por Transferencia o Depósito


    Public Sub MOSTRAR()
        'Se limpia primero el datagrid por si hubieran datos, así no se duplican los mismos
        Form1.DataGridView1.Rows.Clear()
        For I = 0 To 6
            'Con el siguiente IF se verifica que los vectores no estén vacíos, porque si están vacíos
            'y se trata de accesar a dicha posición, indicará un error de que se está tratando de 
            'mostrar algo que es Nulo o No existe
            'Se toma el primer vector para hacer la verificación, porque los demás estarán igual de llenos o vacíos
            If (NIT(I) <> Nothing) Then
                Form1.DataGridView1.Rows.Add((NOMBRE(I)), NIT(I), Str(DIAS(I)), HABITACION(I), PAGO(I), Str(SUBTOTAL(I)), Str(DESCUENTO(I)), Str(RECARGO(I)), Str(TOTAL(I)))
            Else
                'Si están vacíos, se realiza una salida forzada del ciclo For con la siguiente instrucción
                Exit For
            End If
        Next I
    End Sub

    Sub CONSULTAR()
        Dim Existe As Boolean = False

        'se inicializa la variable I en cero para empezar desde la primera posición del vector del carnet
        I = 0

        'A continuación se define el encabezado del ciclo While
        'Se emplean 2 condiciones: la primera pregunta si es menor o igual a 6 que es la última posición del vector
        'la segunda condición está preguntando si la variable booleana es verdadera, es la misma lógica que los 
        'radiobutton y checkbox
        'Como hay 2 condiciones en el ciclo while, entonces deben haber dos instrucciones, cada una 
        'controlará cada condición
        While (I <= 6) And Not (Existe)
            'en el siguiente If se hace la pregunta que si el dato a buscar está en el vector de búsqueda (Placa)
            'Este dato se encuentra en el TBPlaca
            If (NIT(I) = Val(Form1.TBNit.Text)) Then
                Existe = True 'Instrucción que controla la segunda condición del while, cuando encuentra el dato
            Else
                I = I + 1  'Instrucción que controla la primera condición del while, cuando recorre todo el vector
            End If
        End While

        'Al salir del ciclo while, si la variable existe sigue con valor False, es que no encontró el NIT, esto se
        'notará en la cláusula del THEN del IF siguiente
        'Si la variable EXISTE sale del ciclo while con valor False, quiere decir que no encontró el NIT, esto se 
        'Para controlar las dos indicaciones anteriores se hace el siguiente if
        If (Existe) Then
            MsgBox("Registro de NIT encontrado exitosamente")
            'acá es donde la variable existe es VERDADER entonces si lo encontró 
            'se procede a extraer los datos de los vectores y colocarlos en los controles de ingreso a excepción del promedio
            'Se utiliza la variable I que es la posición donde encontró el dato buscado
            Form1.TBNombre.Text = NOMBRE(I)
            Form1.TBNit.Text = Str(NIT(I))
            Form1.TBDías.Text = Str(DIAS(I))
            Form1.TBValImpuesto.Text = Str(DESCUENTO(I))
            Form1.ComboBox1.Text = HABITACION(I)
            Form1.ComboBox2.Text = PAGO(I)
            TOTAL(I) = Val(PAGO(I))

            'Ahora se procede a mostrar los mismos datos encontrados en el datagridview
            'para ello se debe limpiar el datagridview
            Form1.DataGridView1.Rows.Clear()
            Form1.DataGridView1.Rows.Add((NOMBRE(I)), NIT(I), Str(DIAS(I)), HABITACION(I), PAGO(I), Str(SUBTOTAL(I)), Str(DESCUENTO(I)), Str(RECARGO(I)), Str(TOTAL(I)))
            'en la siguiente instrucción asignamos el valor de la variable I a la variable Fila para indicar
            'en que fila se encontró el dato buscado, esta instrucción se realiza porque puede servir para 
            'el proceso de Actualizar o Eliminar
            FILA = I
        Else
            MsgBox("Número de NIT no encontrado")
            Form1.TBNit.Focus()
        End If
    End Sub

    Sub LIMPIAR_VECTORES()

    End Sub
    Sub LIMPIAR_ENTRADAS()
        Form1.TBNombre.Clear()
        Form1.TBNit.Clear()
        Form1.TBDías.Clear()
        Form1.TBValImpuesto.Clear()
        Form1.ComboBox1.Text = ""
        Form1.ComboBox2.Text = ""
    End Sub


End Module
