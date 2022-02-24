Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TBSubtotal.Text = SubtotalVuelo
        TBDescuento.Text = DescuentoVuelo
        TBTotal.Text = TotalVuelo
    End Sub

    Private Sub ButtonRegresar_Click_1(sender As Object, e As EventArgs) Handles ButtonRegresar.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        If MsgBox("¿Está seguro que desea salir?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End
        End If
        Close()
    End Sub

    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Show()
        Me.Hide()
    End Sub
End Class