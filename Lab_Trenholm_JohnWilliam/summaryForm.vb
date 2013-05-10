Public Class summaryForm

    Private Sub summaryForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Form on Load adds values to form
        totalDepositTextBox.Text = Transaction.numberOfDeposits.ToString("n")
        totalWithdrawalTextBox.Text = Transaction.numberOfWithdrawls.ToString("n")
        totalOverdraftsTextBox.Text = Transaction.numberOfOverdrafts.ToString("n")
    End Sub
    'Exits form
    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles okButton.Click
        Me.Close()
    End Sub

End Class