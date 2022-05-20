Module Module1

    'Variable que se utilizará para controlar los ingresos en cada fila de los vectores
    Public FILA As Byte = 0
    'Variable que se utilizará para algunos de los ciclos For de ciertos procesos
    Public I As Byte

    'Declaración de los vectores donde se almacenarán cada uno de los datos de ingreso, y el resultado
    'El proceso será para 6 clientes

    Public NIT(6) As Integer
    Public NOMBRE(6) As String
    Public CABINA(6) As String
    Public CLASE(6) As String
    Public PERSONAS(6) As Byte
    Public PRECIO(6) As Double
    Public TOTAL(6) As Double

    Public Subtotal As Double
    Public Individual As Double


    'Precios p/persona de las cabinas por día hospedado en el crucero. (PRIMERA CLASE)
    Public Const PSencilla1C = 400
    Public Const PDoble1C = 700
    Public Const PCompartida1C = 350

    'Precios p/persona de las cabinas por día hospedado en el crucero. (SEGUNDA CLASE)
    Public Const PSencilla2C = 375
    Public Const PDoble2C = 600
    Public Const PCompartida2C = 300


    Sub MOSTRAR_DATOS()
        'Se limpia primero el datagrid por si hubieran datos, así no se duplican los mismos
        Form1.DataGridView1.Rows.Clear()
        For I = 0 To 5
            'Con el siguiente IF se verifica que los vectores no estén vacíos, porque si están vacíos
            'y se trata de accesar a dicha posición, indicará un error de que se está tratando de 
            'mostrar algo que es Nulo o No existe
            'Se toma el primer vector para hacer la verificación, porque los demás estarán igual de llenos o vacíos
            If (NIT(I) <> Nothing) Then
                Form1.DataGridView1.Rows.Add((NIT(I)), NOMBRE(I), CABINA(I), CLASE(I), PERSONAS(I), PRECIO(I), TOTAL(I))
            Else
                Exit For   'Si están vacíos, se realiza una salida forzada del ciclo For con la siguiente instrucción
            End If
        Next I
    End Sub

    Sub CONSULTAR_DATOS()
        Dim Existe As Boolean = True

        'se inicializa la variable I en cero para empezar desde la primera posición del vector del carnet
        I = 0

        'A continuación se define el encabezado del ciclo While
        'Se emplean 2 condiciones: la primera pregunta si es menor o igual a 6 que es la última posición del vector
        'la segunda condición está preguntando si la variable booleana es verdadera, es la misma lógica que los 
        'radiobutton y checkbox
        'Como hay 2 condiciones en el ciclo while, entonces deben haber dos instrucciones, cada una 
        'controlará cada condición
        While (I <= 5) And (Existe)
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
        If (Existe = False) Then
            MsgBox("Registro de NIT encontrado exitosamente")
            'acá es donde la variable existe es VERDADER entonces si lo encontró 
            'se procede a extraer los datos de los vectores y colocarlos en los controles de ingreso a excepción del promedio
            'Se utiliza la variable I que es la posición donde encontró el dato buscado

            Form1.TBNit.Text = Str(NIT(I))
            Form1.TBNombre.Text = NOMBRE(I)

            Form1.ComboBox1.Text = CABINA(I)
            Form1.ComboBox2.Text = CLASE(I)
            Form1.TBPersonas.Text = Str(PERSONAS(I))
            TOTAL(I) = Val(PRECIO(I))

            'Ahora se procede a mostrar los mismos datos encontrados en el datagridview
            'para ello se debe limpiar el datagridview
            Form1.DataGridView1.Rows.Clear()
            Form1.DataGridView1.Rows.Add((NIT(I)), NOMBRE(I), CABINA(I), CLASE(I), Str(PERSONAS(I)), PRECIO(I), Str(TOTAL(I)))
            'en la siguiente instrucción asignamos el valor de la variable I a la variable Fila para indicar
            'en que fila se encontró el dato buscado, esta instrucción se realiza porque puede servir para 
            'el proceso de Actualizar o Eliminar
            FILA = I
        Else
            MsgBox("Número de NIT no encontrado")
            Form1.TBNit.Focus()
        End If

    End Sub

    Sub ELIMINAR_DATOS()
        If MsgBox("¿DESEA ELIMINAR EL REGISTRO ENCONTRADO", vbQuestion + vbYesNo, "MENSAJE DE VERIFICACIÓN DE ELIMINACIÓN DE DATOS") = vbYes Then
            NIT(I) = Nothing
            NOMBRE(I) = Nothing
            CABINA(I) = Nothing
            CLASE(I) = Nothing
            PERSONAS(I) = Nothing
            PRECIO(I) = Nothing
            TOTAL(I) = Nothing

            For I = FILA To 5

                NIT(I) = NIT(I + 1)
                NOMBRE(I) = NOMBRE(I + 1)
                CABINA(I) = CABINA(I + 1)
                CLASE(I) = CLASE(I + 1)
                PERSONAS(I) = PERSONAS(I + 1)
                PRECIO(I) = PRECIO(I + 1)
                TOTAL(I) = TOTAL(I + 1)
            Next
            I = 0
            While NIT(FILA) <> Nothing
                I = I + 1
            End While

            NIT(I) = Nothing
            NOMBRE(I) = Nothing
            CABINA(I) = Nothing
            CLASE(I) = Nothing
            PERSONAS(I) = Nothing
            PRECIO(I) = Nothing
            TOTAL(I) = Nothing

            FILA = 6
            Limpiar_Entradas()
            Form1.DataGridView1.Rows.Clear()
        End If


    End Sub
    Sub Limpiar_Entradas()
        Form1.TBNombre.Clear()
        Form1.TBNit.Clear()
        Form1.TBPersonas.Clear()
        Form1.ComboBox1.Text = ""
        Form1.ComboBox2.Text = ""
    End Sub

    Sub Limpiar_Vectores()
        Form1.DataGridView1.Rows.Clear()

        FILA = 0

        For I = 0 To 5
            NIT(I) = Nothing
            NOMBRE(I) = Nothing
            CABINA(I) = Nothing
            CLASE(I) = Nothing
            PERSONAS(I) = Nothing
            PRECIO(I) = Nothing
            TOTAL(I) = Nothing
        Next I
    End Sub
End Module
