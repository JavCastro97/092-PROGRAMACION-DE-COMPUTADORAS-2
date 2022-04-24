Imports System.Math
Public Class Form1
    Private Sub CALCULAR_Click(sender As Object, e As EventArgs) Handles CALCULAR.Click
        If (FILA <= 6) Then

            TIPO(FILA) = ComboBox1.Text
            Placa(FILA) = TBPlaca.Text
            CobroBase(FILA) = COBRO

            Select Case ComboBox1.Text
                Case "Tipo 1"
                    TIPO(FILA) = "Tipo 1"
                    CobroBase(FILA) = 500

                Case "Tipo 2"
                    TIPO(FILA) = "Tipo 2"
                    CobroBase(FILA) = 400

                Case "Tipo 3"
                    TIPO(FILA) = "Tipo 3"
                    CobroBase(FILA) = 300

                Case "Tipo 4"
                    TIPO(FILA) = "Tipo 4"
                    CobroBase(FILA) = 200
                Case Else
                    MsgBox("NO SELECCIONÓ EL TIPO DE CARRO A RENTAR")
            End Select

            KmInicial(FILA) = Val(TBKmI.Text)
            KmFinal(FILA) = Val(TBKmF.Text)

            If KmInicial(FILA) > KmFinal(FILA) Then
                MsgBox("DEBE INGRESAR VALORES CORRECTOS")
                TBKmI.Focus()
            End If

            KILOMETRAJE = KmFinal(FILA) - KmInicial(FILA)

            If KILOMETRAJE > 0 And KILOMETRAJE <= 50 Then
                Valor = 3 * KILOMETRAJE
            ElseIf KILOMETRAJE >= 51 And KILOMETRAJE <= 70 Then
                Valor = 4 * KILOMETRAJE
            ElseIf KILOMETRAJE > 70 Then
                Valor = 5 * KILOMETRAJE
            End If

            CobroRecorrido(FILA) = Valor
            PAGOFINAL(FILA) = CobroBase(FILA) + CobroRecorrido(FILA)
            FILA = FILA + 1
            Limpiar_entradas()

        End If

        If (FILA = 7) Then
            MsgBox("Vectores llenos")
        End If

    End Sub

    Private Sub MOSTRAR_Click(sender As Object, e As EventArgs) Handles MOSTRAR.Click
        'Se hace la llamada al procedimiento que muestra el contenido de los vectores
        Mostrar_vectores()
    End Sub

    Private Sub CONSULTAR_Click(sender As Object, e As EventArgs) Handles CONSULTAR.Click
        'Para el proceso de consultar o buscar, se deben utilizar un ciclo WHILE con dos condiciones 
        'una condición para controlar las 7 posiciones del vector donde se hará la consulta
        'la otra condición para indicar que si se encontró el dato buscado
        'para la primera condición se usará la varible I para controlar las posiciones
        'para la segunda condición se usará una varible Boolean(FALSE/TRUE) para indicar si se encontró o no
        'El dato a buscar será el No. de placa del tipo de carro
        'Si el No. de placa es encontrado se recueperarán los datos relacionados a dicho carnet
        'y se mostrarán en los controles de ingreso y en el Datagridview1, si no está se indica un mensaje que no se encontró
        'La variable siguiente se utilizará para la segunda condición se inicializa como FALSA
        'y cuando el dato buscado es encontrado se le cambia el estado a VERDADERO
        'una variable Boolean se puede inicializar como se muestra a continuación
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
            If (Placa(I) = Val(TBConsultaPlaca.Text)) Then
                Existe = True 'Instrucción que controla la segunda condición del while, cuando encuentra el dato
            Else
                I = I + 1  'Instrucción que controla la primera condición del while, cuando recorre todo el vector
            End If
        End While

        'Al salir del ciclo while, si la variable existe sigue con valor False, es que no encontró el carnet, esto se
        'notará en la cláusula del THEN del IF siguiente
        'Si la variable EXISTE sale del ciclo while con valor False, quiere decir que no encontró el carnet, esto se 
        'notará en la cláusula del ELSE del IF siguiente
        'Para controlar las dos indicaciones anteriores se hace el siguiente if
        If (existe) Then
            MsgBox("Registro Encontrado exitosamente")
            'acá es donde la variable existe es VERDADER entonces si lo encontró 
            'se procede a extraer los datos de los vectores y colocarlos en los controles de ingreso a excepción del promedio
            'Se utiliza la variable I que es la posición donde encontró el dato buscado
            ComboBox1.Text = TIPO(I)
            TBPlaca.Text = Str(Placa(I))
            TBCobroBase.Text = Str(CobroBase(I))
            TBKmI.Text = Str(KmInicial(I))
            TBKmF.Text = Str(KmFinal(I))
            TBKmRecorridos.Text = Str(CobroRecorrido(I))
            PAGO = Str(PAGOFINAL(I))

            'Ahora se procede a mostrar los mismos datos encontrados en el datagridview
            'para ello se debe limpiar el datagridview
            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add((TIPO(I)), Placa(I), Str(CobroBase(I)), Str(KmInicial(I)), Str(KmFinal(I)), Str(CobroRecorrido(I)), Str(PAGOFINAL(I)))
            'en la siguiente instrucción asignamos el valor de la variable I a la variable Fila para indicar
            'en que fila se encontró el dato buscado, esta instrucción se realiza porque puede servir para 
            'el proceso de Actualizar o Eliminar
            FILA = I
        Else
            MsgBox("Número de placa no encontrado")
            TBConsultaPlaca.Focus()
        End If
    End Sub

    Private Sub ACTUALIZAR_Click(sender As Object, e As EventArgs) Handles ACTUALIZAR.Click

        TIPO(FILA) = ComboBox1.Text
        Placa(FILA) = TBPlaca.Text
        CobroBase(FILA) = COBRO

        Select Case ComboBox1.Text
            Case "Tipo 1"
                TIPO(FILA) = "Tipo 1"
                CobroBase(FILA) = 500

            Case "Tipo 2"
                TIPO(FILA) = "Tipo 2"
                CobroBase(FILA) = 400

            Case "Tipo 3"
                TIPO(FILA) = "Tipo 3"
                CobroBase(FILA) = 300

            Case "Tipo 4"
                TIPO(FILA) = "Tipo 4"
                CobroBase(FILA) = 200
            Case Else
                MsgBox("NO SELECCIONÓ EL TIPO DE CARRO A RENTAR")
        End Select

        KmInicial(FILA) = Val(TBKmI.Text)
        KmFinal(FILA) = Val(TBKmF.Text)

        If KmInicial(FILA) > KmFinal(FILA) Then
            MsgBox("DEBE INGRESAR VALORES CORRECTOS")
            TBKmI.Focus()
        End If

        KILOMETRAJE = KmFinal(FILA) - KmInicial(FILA)

        If KILOMETRAJE > 0 And KILOMETRAJE <= 50 Then
            Valor = 3 * KILOMETRAJE
        ElseIf KILOMETRAJE >= 51 And KILOMETRAJE <= 70 Then
            Valor = 4 * KILOMETRAJE
        ElseIf KILOMETRAJE > 70 Then
            Valor = 5 * KILOMETRAJE
        End If

        CobroRecorrido(FILA) = Valor
        PAGOFINAL(FILA) = CobroBase(FILA) + CobroRecorrido(FILA)


        'se indica con un mensaje que el registro fue actualizado correctamente
        MsgBox("Registro actualizado correctamente en los vectores")
        ' luego de hacer los cambios respectivos en la fila indicada en cada vector
        ' se procede a asignarle a la variable Fila el valor de 7, esto para que ya no se permita más ingresos
        FILA = 7
    End Sub

    Private Sub ELIMINAR_Click(sender As Object, e As EventArgs) Handles ELIMINAR.Click
        'Para el proceso de ELIMINAR, primero se debe hacer el proceso de búsqueda o consulta para
        'saber cual es el registro que se va a eliminar, para eso en el proceso de búsqueda, ya la variable FILA
        'se queda con el valor de la posición del dato buscado
        'primero se procede a limpiar la fila que se desea eliminar, de la siguiente forma
        TIPO(FILA) = Nothing
        Placa(FILA) = Nothing
        CobroBase(FILA) = Nothing
        KmInicial(FILA) = Nothing
        KmFinal(FILA) = Nothing
        CobroRecorrido(FILA) = Nothing
        PAGOFINAL(FILA) = Nothing

        'Ahora se procede a hacer los corrimientos, esto se refiere a que los registros que se encuentran abajo del
        'registro eliminado se corren hacia arriba, para ello se usa un ciclo de la siguiente forma
        'nótese que el inicio del ciclo es en la fila del dato encontrado y termina en la última posición menos 1 de los vectores
        'se utiliza la misma variable I para control del ciclo
        For I = FILA To 6
            'en el proceso siguiente se procede a trasladar la fila de abajo hacia la fila actual y
            'así sucesivamente hasta llegar a la última posición menos 1, porque sino se hace así
            'tratará de tomar un valor fuera del rango de los límites de los vectores que es 7 y tratará de accesar la
            'posición 8 que no existe.
            TIPO(I) = TIPO(I + 1)
            Placa(I) = Placa(I + 1)
            CobroBase(I) = CobroBase(I + 1)
            KmInicial(I) = KmInicial(I + 1)
            KmFinal(I) = KmFinal(I + 1)
            CobroRecorrido(I) = CobroRecorrido(I + 1)
            PAGOFINAL(I) = PAGOFINAL(I + 1)
        Next I
        MsgBox("Registro Eliminado exitosamente")
        'al salir de este ciclo for la variable I se queda con valor 4 y la última fila quedará igual que la penúltima fila,
        'para evitar eso se procede a eliminar la última fila de la siguiente forma
        TIPO(FILA) = Nothing
        Placa(FILA) = Nothing
        CobroBase(FILA) = Nothing
        KmInicial(FILA) = Nothing
        KmFinal(FILA) = Nothing
        CobroRecorrido(FILA) = Nothing
        PAGOFINAL(FILA) = Nothing
        'después de lo anterior la última fila quedará vacía y está lista para un nuevo ingreso, para poder realizar
        'un nuevo ingreso, se utiliza la variable fila asignándole el valor 4 que es último índice de los vectores
        'aunque sea la última fila que se deseó eliminar
        FILA = I
        Limpiar_entradas()
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub LIMPIAR_Click(sender As Object, e As EventArgs) Handles LIMPIAR.Click
        Limpiar_Vectores()

    End Sub

    Private Sub SALIR_Click(sender As Object, e As EventArgs) Handles SALIR.Click
        If (MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            Close()
        Else
            Limpiar_entradas()
            Limpiar_Vectores()

        End If
    End Sub
End Class
