
Public Class summaryForm
    'Form on Load adds values to form
    Private Sub Summary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        SumNumOfSalesTextBox.Text = Purchases.NumberOfSales.ToString("N")
        SumTotalSalesTextBox.Text = Purchases.TotalSales.ToString("C")
        SumTotalTradeInsTextBox.Text = Purchases.TotalTradeIns.ToString("C")

    End Sub
    'Exits form
    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class