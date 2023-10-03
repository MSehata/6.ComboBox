Public Class Form1
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim newItem
        newItem = InputBox("Item Name ")
        ComboBox1.Items.Add(newItem)

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim oldItem
        oldItem = InputBox("Item Name ")
        ComboBox1.Items.Remove(oldItem)
    End Sub

    Private Sub btnRemoveSelected_Click(sender As Object, e As EventArgs) Handles btnRemoveSelected.Click
        ComboBox1.Items.Remove(ComboBox1.SelectedItem)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ComboBox1.Items.Clear()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class
