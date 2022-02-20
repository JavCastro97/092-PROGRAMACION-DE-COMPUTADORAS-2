Public Class Form2
    Private Sub ButtonRegresar_Click(sender As Object, e As EventArgs) Handles ButtonRegresar.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        If MsgBox("¿Está seguro que desea salir?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End
        End If
        Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxCostoUnitario.Text = CostoUnitario
        TextBoxPrecioCosto.Text = CostoTotal
        TextBoxVentaUnitaria.Text = VentaUnitaria
        TextBoxPrecioVenta.Text = VentaTotal

    End Sub
End Class