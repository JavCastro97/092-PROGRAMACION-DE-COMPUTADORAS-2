Module Module1
    'SE DEFINEN LAS CONSTANTES DE LOS PRECIOS DE LA MANO DE OBRA DE LOS SILLONES Y EL MATERIAL
    Public Const PrecioSofa = 250.99
    Public Const PrecioIndividual = 150.99
    Public Const PrecioDoble = 200.99
    Public Const PrecioCuero = 75.0
    Public Const PrecioCuerina = 45.99

    Public REGISTROVENTA(8)
    Public TAMAÑO(8)
    Public MATERIAL(8)
    Public PRECIOMANODEOBRA(8)
    Public PRECIOCOSTO(8)
    Public PRECIOVENTA(8)

    Public Contador As Byte = 0

    Sub Limpiar_Vectores()
        Form1.ComboBox1.SelectedIndex = -1
        Form1.ComboBox2.SelectedIndex = -1
    End Sub

    Sub Limpiar_DataGridView1()
        Contador = 0
        'SE PROCEDE A LIMPIAR EL DATAGRIDVIEW HACIENDO USO DE LA PROPIEDAD "CLEAR" DEL MÉTODO "ROWS", QUE PERTENECE AL OBJETO "DATAGRIDVIEW1"
        Form1.DataGridView1.Rows.Clear()

        'SI SE HUBIERA UTILIZADO LISTBOX, SE HUBIERAN LIMPIADO DE LA SIGUIENTE MANERA.
        'ListBox1.Items.Clear()
        'ListBox2.Items.Clear()
        'ListBox3.Items.Clear()
        'ListBox4.Items.Clear()
        'ListBox5.Items.Clear()
        'ListBox6.Items.Clear()
    End Sub

    Sub Salir()
        If MsgBox("¿DESEA SALIR DEL PROCESO DE REGISTRO DE VENTA?", vbQuestion + vbYesNo, "salir") = vbYes Then
            Form1.Close()
        End If
    End Sub

End Module
