
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

    Private Sub TtlSalesLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TtlSalesLabel.Click

    End Sub

    Private Sub NumSalesLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumSalesLabel.Click

    End Sub

    Private Sub TtlTradeLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TtlTradeLabel.Click

    End Sub

    Private Sub SumNumOfSalesTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SumNumOfSalesTextBox.TextChanged

    End Sub

    Private Sub SumTotalSalesTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SumTotalSalesTextBox.TextChanged

    End Sub

    Private Sub SumTotalTradeInsTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SumTotalTradeInsTextBox.TextChanged

    End Sub
End Class