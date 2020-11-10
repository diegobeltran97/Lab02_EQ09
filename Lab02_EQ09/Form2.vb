Public Class Form2
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lbNombre.Click

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ltbEdad.SelectedIndexChanged

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        ltbNombre.Items.Add(txtNombre.Text)
        ltbEdad.Items.Add(txtEdad.Text)
        ltbTelefono.Items.Add(txtTelefono.Text)
        ltbEstado.Items.Add(IIf(cbEstado.Checked, "Casado", "Soltero"))
        txtCantidad.Text = ltbNombre.Items.Count
        txtTelefono.Text = ""
        txtEdad.Text = ""
        txtNombre.Text = ""
        txtNombre.Focus()
    End Sub



    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim I As Integer = ltbNombre.SelectedIndex
        ltbNombre.Items.RemoveAt(I)
        ltbTelefono.Items.RemoveAt(I)
        ltbEstado.Items.RemoveAt(I)
        ltbEdad.Items.RemoveAt(I)
        txtCantidad.Text = ltbNombre.Items.Count
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        ltbNombre.Items.Clear()
        ltbTelefono.Items.Clear()
        ltbEstado.Items.Clear()
        ltbEdad.Items.Clear()
        txtCantidad.Text = ltbNombre.Items.Count
        txtNombre.Focus()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Hide()
        FrmPrincipal.Show()
    End Sub
End Class