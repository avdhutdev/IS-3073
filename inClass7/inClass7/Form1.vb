Public Class Form1

    Private Sub addButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addButton.Click
        ListBox1.Items.Add("Ice Cream")
        ComboBox2.Items.Add(ComboBox2.Text)
    End Sub

    Private Sub insertButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles insertButton.Click
        ListBox1.Items.Insert(Integer.Parse(positionBox.Text - 1), "Your mom's Sandwhiches")

    End Sub

    Private Sub countButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles countButton.Click
        MessageBox.Show(ListBox1.Items.Count(), "ListBox1 count", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

    End Sub

    Private Sub changeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles changeButton.Click
        'ListBox1.Items.IndexOf(Integer.Parse(changeTextBox.Text))
        'MessageBox.Show(ListBox1.Items.IndexOf(Integer.Parse(changeTextBox.Text)), "ListBox1 count", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)


    End Sub

    Private Sub removeAtbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles removeAtbutton.Click
        If ListBox1.Items.Count < (Integer.Parse(removeTextBox.Text - 1)) Then
            MessageBox.Show("Please select a valid item", "ListBox1 count", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            ListBox1.Items.RemoveAt(Integer.Parse(removeTextBox.Text - 1))
        End If
    End Sub

    Private Sub removePizza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles removePizza.Click
        ListBox1.Items.Remove(removeStringTextBox.Text)
    End Sub
End Class
