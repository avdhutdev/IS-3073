Public Class TransactionForm
    Public moneyTransaction As Transaction

    Private Sub okButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles okButton.Click
        Dim transactionAmount As Decimal
        Dim transType As Boolean
        Try
            'Test to make sure decimal is entered in textbox
            transactionAmount = Decimal.Parse(amountTextBox.Text)
            If CustomerComboBox.SelectedItem = "" Then
                MessageBox.Show("Please select a person.", "Selection Error", _
                    MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim accountBalance As Decimal
                accountBalance = chkBalTextBox.Text
                If withdrawRadioButton.Checked() Or depositRadioButton.Checked() Then

                    If withdrawRadioButton.Checked() Then
                        'withdrawl
                        transType = True
                    Else
                        'deposit
                        transType = False

                    End If
                    If accountListBox.SelectedItem = "Checking Account" Then
                        moneyTransaction = New Transaction(transactionAmount, chkBalTextBox.Text, transType)
                        chkBalTextBox.Text = moneyTransaction.setaccountBalance.ToString("c")

                    Else
                        moneyTransaction = New Transaction(transactionAmount, savBalTextBox.Text, transType)
                        savBalTextBox.Text = moneyTransaction.setaccountBalance.ToString("c")

                    End If





                Else
                    MessageBox.Show("Please select a location to withdrawl the money from.", "Selection Error", _
                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                End If

        Catch ex As Exception
            MessageBox.Show("Please Enter Decimal Data.", "Data Entry Error", _
            MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Try
    End Sub

    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub addButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addButton.Click
        Dim foundItem As Boolean = True
        Dim indexInt As Integer = 0
        If CustomerComboBox.Text <> "" Then

            Do While foundItem And indexInt < CustomerComboBox.Items.Count()
                If CustomerComboBox.Text = CustomerComboBox.Items(indexInt).ToString() Then
                    indexInt = indexInt + 1
                    MessageBox.Show("This entry already exists.", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    foundItem = False
                Else
                    CustomerComboBox.Items.Add(CustomerComboBox.Text)
                    CustomerComboBox.Text = ""
                    foundItem = False
                End If
            Loop
        Else
            MessageBox.Show("Please enter a person to add.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub removeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles removeButton.Click
        Dim foundItem As Boolean = True
        Dim indexInt As Integer = 0
        If CustomerComboBox.Text <> "" Then

            Do While foundItem And indexInt < CustomerComboBox.Items.Count()
                If CustomerComboBox.Text = CustomerComboBox.Items(indexInt).ToString() Then
                    indexInt = indexInt + 1
                    MessageBox.Show("This entry does not exists.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    foundItem = False
                Else
                    CustomerComboBox.Items.Remove(CustomerComboBox.Text)
                    CustomerComboBox.Text = ""
                    foundItem = False
                End If
            Loop
        Else
            MessageBox.Show("Please enter a Person to remove.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub CustomerComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerComboBox.SelectedIndexChanged
        chkBalTextBox.Text = 500.ToString("c")
        savBalTextBox.Text = 1000.ToString("c")
    End Sub

    Private Sub summaryButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles summaryButton.Click
        summaryForm.Show()
    End Sub

    Private Sub clearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearButton.Click
        chkBalTextBox.Text = ""
        savBalTextBox.Text = ""
        amountTextBox.Text = ""
        accountListBox.Text = ""
        withdrawRadioButton.Checked = False
        depositRadioButton.Checked = False
        'This doesnt' work right :(
        CustomerComboBox.SelectedItem = False
        CustomerComboBox.Text = ""
        accountListBox.SelectedItem = False
    End Sub

    Private Sub depositRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles depositRadioButton.CheckedChanged
        accountListBox.Enabled = True
    End Sub

    Private Sub TransactionForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        accountListBox.Enabled = False
    End Sub

    Private Sub withdrawRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles withdrawRadioButton.CheckedChanged
        accountListBox.Enabled = False
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        chkBalTextBox.Text = ""
        savBalTextBox.Text = ""
        amountTextBox.Text = ""
        accountListBox.Text = ""
        withdrawRadioButton.Checked = False
        depositRadioButton.Checked = False
        'This doesnt' work right :(
        CustomerComboBox.SelectedItem = False
        CustomerComboBox.Text = ""
        accountListBox.SelectedItem = False
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
