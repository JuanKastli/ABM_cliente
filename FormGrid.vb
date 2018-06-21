Public Class FormGrid
    Private Sub Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DataGridView1.DataSource = lst

    End Sub

    Private Sub Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Agregar.Click
        Form.operacion = "Agregar"
        Form.Text = "Agrega"
        Form.ShowDialog()
    End Sub

    Private Sub Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modificar.Click
        Form.operacion = "Modificar"
        Form.Text = "Modificar"
        Form.ShowDialog()
    End Sub

    Private Sub Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar.Click
        Form.operacion = "Eliminar"
        Form.Text = "Eliminar"
        Form.Show()
        Form.indice = DataGridView1.CurrentRow.Index
        llenarform()
        Form.Show()
    End Sub
    Private Sub llenarform()
        Form.id.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        'Form.saldo.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click
        Me.Close()
    End Sub
End Class