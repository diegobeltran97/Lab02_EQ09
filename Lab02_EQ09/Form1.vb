Public Class FrmPrincipal
    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles Rtb_presentacion.TextChanged

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnApp_Click(sender As Object, e As EventArgs) Handles btnApp.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
        Me.Hide()
    End Sub
End Class
