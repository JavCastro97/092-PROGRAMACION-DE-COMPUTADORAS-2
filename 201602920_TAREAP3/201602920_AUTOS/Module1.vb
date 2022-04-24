Module Module1
    'Declaración de los vectores donde se almacenarán cada uno de los datos de ingreso, y el resultado
    'El proceso será para 7 ingresos
    Public COBRO As Double
    Public KILOMETRAJE As Double
    Public PAGO As Double
    Public Valor As Double

    Public TIPO(7) As String
    Public Placa(7) As Integer
    Public CobroBase(7) As Double
    Public KmInicial(7) As Double
    Public KmFinal(7) As Double
    Public CobroRecorrido(7) As Double
    Public PAGOFINAL(7) As Double


    'Variable que se utilizará para controlar los ingresos en cada fila de los vectores
    Public FILA As Byte = 0
    'Variable que se utilizará para algunos de los ciclos For de ciertos procesos
    Public I As Byte

    'Se determinan las Constantes del cobro base según el Tipo de carro y el cobro por km recorridos.
    Public Const CBTipo1 = 500
    Public Const CBTipo2 = 400
    Public Const CBTipo3 = 300
    Public Const CBTipo4 = 200
    Public Const Recorrido1 = 3
    Public Const Recorrido2 = 4
    Public Const Recorrido3 = 5

    Sub Mostrar_Vectores()
        'Se limpia primero el datagrid por si hubieran datos, así no se duplican los mismos
        Form1.DataGridView1.Rows.Clear()
        For I = 0 To 6
            'Con el siguiente IF se verifica que los vectores no estén vacíos, porque si están vacíos
            'y se trata de accesar a dicha posición, indicará un error de que se está tratando de 
            'mostrar algo que es Nulo o No existe
            'Se toma el primer vector para hacer la verificación, porque los demás estarán igual de llenos o vacíos
            If (Placa(I) <> Nothing) Then
                Form1.DataGridView1.Rows.Add((TIPO(I)), Placa(I), Str(CobroBase(I)), Str(KmInicial(I)), Str(KmFinal(I)), Str(CobroRecorrido(I)), Str(PAGOFINAL(I)))
            Else
                'Si están vacíos, se realiza una salida forzada del ciclo For con la siguiente instrucción
                Exit For
            End If
        Next I
    End Sub
    Sub Limpiar_entradas()
        'procedimiento que limpia los objetos de entrada
        Form1.TBKmI.Clear()
        Form1.TBKmF.Clear()
        Form1.TBPlaca.Clear()
        Form1.ComboBox1.Text = ""
        Form1.TBPlaca.Focus()
    End Sub

    Sub Limpiar_Vectores()
        'Se limpia primero el datagrid donde se encuentran los datos
        Form1.DataGridView1.Rows.Clear()
        'Se inicializa a cero la variable que controla las filas de ingreso de datos a los vectores
        'para dejarla lista para  7 nuevos ingresos
        FILA = 0
        'Se utilizar ciclo for para recorrer cada celda de los vectores y limpiarlos
        For I = 0 To 6
            'se le asigna Nothing a cada posición del vector
            TIPO(I) = Nothing
            Placa(I) = Nothing
            CobroBase(I) = Nothing
            KmInicial(I) = Nothing
            KmFinal(I) = Nothing
            CobroRecorrido(I) = Nothing
            PAGOFINAL(I) = Nothing
        Next I
    End Sub

End Module
