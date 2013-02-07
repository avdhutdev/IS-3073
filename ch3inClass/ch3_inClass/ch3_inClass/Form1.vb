Public Class Form1
    Private orderTotalDecimal As Decimal

    Private Sub calculateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculateButton.Click
        'following statements declare variables for calculation
        Dim priceDecimal, totalDecimal As Decimal
        Dim quantityInteger As Integer
        'parse text from text boxes into variables
        priceDecimal = Decimal.Parse(priceTextBox.Text)
        quantityInteger = Integer.Parse(quantityTextBox.Text)
        'calulate total
        totalDecimal = priceDecimal * quantityInteger
        totalTextBox.Text = totalDecimal.ToString()
        orderTotalDecimal += totalDecimal
        orderTotalTextBox.Text = orderTotalDecimal.ToString("c")
    End Sub

    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        'closes the form
        Me.Close()
    End Sub

    Private Sub clearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearButton.Click
        priceTextBox.Text = ""
        quantityTextBox.Text = ""
        totalTextBox.Text = ""
        priceTextBox.Focus()
    End Sub
End Class
