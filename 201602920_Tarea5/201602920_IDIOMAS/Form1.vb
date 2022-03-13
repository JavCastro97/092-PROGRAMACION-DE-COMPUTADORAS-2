Public Class Form1


    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click
        Call REGISTRAR()
    End Sub

    Private Sub LIMPIARENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARENTRADASToolStripMenuItem.Click
        Call Limpiar_Entradas()
    End Sub

    Private Sub LIMPIARVECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARVECTORESToolStripMenuItem.Click
        Call Limpiar_DataGridView()
        'Call Limpiar_Vectores()
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        Call SALIR()
    End Sub

    Private Sub ButtonREGISTRAR_Click(sender As Object, e As EventArgs) Handles ButtonREGISTRAR.Click
        Call REGISTRAR()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'SE AGREGAN LOS ELEMENTOS AL COMBOBOX1 EN EL MÉTODO DE CARGA (LOAD) DEL FORMULARIO 
        ComboBoxCurso.Items.Add("INGLES")
        ComboBoxCurso.Items.Add("PORTUGUES")
        ComboBoxCurso.Items.Add("FRANCES")
    End Sub

End Class
