Public Class Form3

    Dim row As String()

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        row = New String() {txtNombre.Text, txtEdad.Text, txtTelefono.Text, IIf(cbEstado.Checked, "Casado", "Soltero")}
        DataGridView1.Rows.Add(row)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim selectedRow As Integer


        selectedRow = DataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected)

        If selectedRow > 0 Then
            DataGridView1.Rows.RemoveAt(selectedRow - 1)
        End If





    End Sub


    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Hide()
        FrmPrincipal.Show()
    End Sub
End Class