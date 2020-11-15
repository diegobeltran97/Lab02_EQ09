Public Class FrmPrincipal
    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles Rtb_presentacion.TextChanged

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub



    Private Sub ListBoxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListBoxToolStripMenuItem.Click
        Form2.Show()

    End Sub

    Private Sub FormGridViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormGridViewToolStripMenuItem.Click
        Form3.Show()

    End Sub
End Class
