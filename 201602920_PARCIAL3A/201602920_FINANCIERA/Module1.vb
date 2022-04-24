Imports System.Math
Module Module1
    'Variable que se utilizará para controlar los ingresos en cada fila de los vectores
    Public FILA As Byte = 0
    'Variable que se utilizará para algunos de los ciclos For de ciertos procesos
    Public I As Byte

    'Declaración de los vectores donde se almacenarán cada uno de los datos de ingreso, y el resultado
    'El proceso será para 5 estudiantes
    Public NoCLIENTE(7) As String
    Public VIAJE(7) As String
    Public PRECIO(7) As Double
    Public DIAS(7) As Byte
    Public CANTPERSONAS(7) As Integer
    Public TOTAL(7) As Double

    Public Precio_Viaje As Double


    'Precio por persona por cada día reservado
    Public Const PBiotopoDelQuetzal = 255
    Public Const PLagunaBrava = 440
    Public Const PMirador = 1190



    Sub MOSTRAR_DATOS()
        'Se limpia primero el datagrid por si hubieran datos, así no se duplican los mismos
        Form1.DataGridView1.Rows.Clear()
        For I = 0 To 6
            'Con el siguiente IF se verifica que los vectores no estén vacíos, porque si están vacíos
            'y se trata de accesar a dicha posición, indicará un error de que se está tratando de 
            'mostrar algo que es Nulo o No existe
            'Se toma el primer vector para hacer la verificación, porque los demás estarán igual de llenos o vacíos
            If (NoCLIENTE(I) <> Nothing) Then
                Form1.DataGridView1.Rows.Add((NoCLIENTE(I)), VIAJE(I), Round(PRECIO(I), 2), Str(DIAS(I)), Str(CANTPERSONAS(I)), Str(TOTAL(I)))
            Else
                Exit For   'Si están vacíos, se realiza una salida forzada del ciclo For con la siguiente instrucción
            End If
        Next I
    End Sub
    Sub BUSCAR_NoCLIENTE()
        Dim EXISTE As Boolean = False

        'se inicializa la variable I en cero para empezar desde la primera posición del vector del carnet
        I = 0

        'A continuación se define el encabezado del ciclo while
        'observe como están las 2 condiciones, la primera pregunta si es menor o igual a 6 que es la última posición del vector
        'la segunda condición está preguntando si la variable booleana es verdadera, es la misma lógica que los 
        'radiobutton y checkbox
        'Como hay 2 condiciones en el ciclo while, entonces deben haber dos instrucciones, cada una 
        'controlará cada condición
        While (I <= 6) And Not (EXISTE)
            'en el siguiente If se hace la pregunta que si el dato a buscar está en el vector de búsqueda (No. Identificación)
            'observe que en la Textbox "TBIdentificacion" es donde está el registro a buscar
            If (NoCLIENTE(I) = Val(Form1.TBIdentificacion.Text)) Then
                EXISTE = True 'Instrucción que controla la segunda condición del while, cuando encuentra el dato
            Else
                I = I + 1  'Instrucción que controla la primera condición del while, cuando recorre todo el vector
            End If
        End While

        'Al salir del ciclo while, si la variable EXISTE sigue con valor False, es que no encontró el No. De Identificación del Cliente, 
        'esto se notará en la cláusula del THEN del IF siguiente
        'Si la variable EXISTE sale del ciclo while con valor False, quiere decir que no encontró el No. Identificación, esto se 
        'notará en la cláusula del ELSE del IF siguiente
        'Para controlar las dos indicaciones anteriores se hace el siguiente if
        If (EXISTE) Then
            MsgBox("Registro Encontrado exitosamente")
            'acá es donde la variable EXISTE es VERDADERO entonces si encontró el dato en el registro
            'se procede a extraer los datos de los vectores y colocarlos en los controles de ingreso a excepción del Total
            'Se utiliza la variable I que es la posición donde encontró el dato buscado
            Form1.TBConsulta.Text = NoCLIENTE(I)
            Form1.ComboBox1.Text = VIAJE(I)
            Form1.TBPrecioViaje.Text = Str(PRECIO(I))
            Form1.TBDías.Text = Str(DIAS(I))
            Form1.TBCantPersonas.Text = Str(CANTPERSONAS(I))

            'Ahora se procede a mostrar los mismos datos encontrados en el datagridview
            'para ello se debe limpiar el datagridview
            Form1.DataGridView1.Rows.Clear()
            Form1.DataGridView1.Rows.Add((NoCLIENTE(I)), VIAJE(I), PRECIO(I), Str(DIAS(I)), Str(CANTPERSONAS(I)), Str(Round(TOTAL(I), 2)))
            'en la siguiente instrucción asignamos el valor de la variable I a la variable Fila para indicar
            'en que fila se encontró el dato buscado, esta instrucción se realiza porque puede servir para 
            'el proceso de Actualizar o Eliminar
            FILA = I
            Form1.TBConsulta.Clear()
        Else
            MsgBox("No. De identificación del cliente no encontrado")
            Form1.TBIdentificacion.Focus()
        End If
    End Sub
    Sub ELIMINAR_DATOS()
        If (MsgBox("DESEA ELIMINAR EL REGISTRO SELECCIONADO", vbQuestion + vbYesNo, "MENSAJE DE VERIFICACIÓN DE ELIMINACIÓN") = vbYes) Then
            NoCLIENTE(I) = Nothing
            VIAJE(I) = Nothing
            PRECIO(I) = Nothing
            DIAS(I) = Nothing
            CANTPERSONAS(I) = Nothing
            TOTAL(I) = Nothing

            For I = FILA To 6
                NoCLIENTE(I) = NoCLIENTE(I + 1)
                VIAJE(I) = VIAJE(I + 1)
                PRECIO(I) = PRECIO(I + 1)
                DIAS(I) = DIAS(I + 1)
                CANTPERSONAS(I) = CANTPERSONAS(I + 1)
                TOTAL(I) = TOTAL(I + 1)
            Next
            I = 0
            While (NoCLIENTE(FILA) <> Nothing)
                FILA = FILA + 1
            End While

            NoCLIENTE(I) = Nothing
            VIAJE(I) = Nothing
            PRECIO(I) = Nothing
            DIAS(I) = Nothing
            CANTPERSONAS(I) = Nothing
            TOTAL(I) = Nothing
        End If

        LIMPIAR_ENTRADAS()
        Form1.DataGridView1.Rows.Clear()
    End Sub
    Sub LIMPIAR_ENTRADAS()
        Form1.TBIdentificacion.Clear()
        Form1.TBDías.Clear()
        Form1.TBCantPersonas.Clear()
        Form1.ComboBox1.Text = ""
    End Sub
    Sub LIMPIAR_VECTORES()
        'Se limpia primero el datagrid donde se encuentran los datos
        Form1.DataGridView1.Rows.Clear()
        'Se inicializa a cero la variable que controla las filas de ingreso de datos a los vectores
        'para dejarla lista para  7 nuevos ingresos de clientes a reservar su viaje
        FILA = 0
        'Se utilizar ciclo for para recorrer cada celda de los vectores y limpiarlos
        For I = 0 To 6
            'se le asigna Nothing a cada posición del vector
            NoCLIENTE(I) = Nothing
            VIAJE(I) = Nothing
            PRECIO(I) = Nothing
            DIAS(I) = Nothing
            CANTPERSONAS(I) = Nothing
            TOTAL(I) = Nothing
        Next I
    End Sub
End Module
