Option Strict On

Public Class TransactionForm
    Dim shirtPurchase As Shirt
    Dim counter As Integer

    Private Sub AddtoOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddtoOrderToolStripMenuItem.Click
        Try
            'Test to make sure decimal is entered in textbox
            Dim quantityInt As Integer = Integer.Parse(QuantityTextBox.Text)
            'Test to make sure decimal is entered in textbox
            If sizeListBox.SelectedIndex >= 0 Then
                Dim tShirtSize As String = sizeListBox.Text
                shirtPurchase = New Shirt(MonogramCheckBox.Checked, PocketCheckBox.Checked, quantityInt, tShirtSize)
                transactionTotalTextBox.Text = shirtPurchase.Total.ToString("c")
                OrderTotalTextBox.Text = shirtPurchase.totalSales.ToString("c")
                OrderNumberTextBox.ReadOnly = True
                OrderCompleteToolStripMenuItem.Enabled = True


            Else
                MessageBox.Show("Please select a T-Shirt Size.", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Please Enter a Quantity.", "Data Entry Error", _
            MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub MonogramMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MonogramMenuItem.Click
        If MonogramMenuItem.Checked Then
            MonogramCheckBox.Checked = True
        Else
            MonogramCheckBox.Checked = False
        End If
    End Sub

    Private Sub pocketMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pocketMenuItem.Click
        If pocketMenuItem.Checked Then
            PocketCheckBox.Checked = True
        Else
            MonogramCheckBox.Checked = False
        End If
    End Sub

    Private Sub ClearThisItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearThisItemToolStripMenuItem.Click
        MonogramCheckBox.Checked = False
        MonogramCheckBox.Checked = False
        transactionTotalTextBox.Text = ""
        QuantityTextBox.Text = ""
        OrderNumberTextBox.Text = ""
        OrderNumberTextBox.ReadOnly = False
    End Sub

    Private Sub RemoveFromOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveFromOrderToolStripMenuItem.Click
        If shirtPurchase.totalSales > 0 Then
            transactionTotalTextBox.Text = "0"
            shirtPurchase.totalSales = shirtPurchase.totalSales - shirtPurchase.Total
            transactionTotalTextBox.Text = shirtPurchase.Total.ToString("c")
            OrderTotalTextBox.Text = shirtPurchase.totalSales.ToString("c")
        Else
            MessageBox.Show("Please Enter a Quantity.", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub OrderCompleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrderCompleteToolStripMenuItem.Click
        Dim customerInput As DialogResult
        customerInput = MessageBox.Show("Do you wish to complete the current Order", "Order confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If customerInput = Windows.Forms.DialogResult.Yes Then
            MessageBox.Show("I didn't know what the example did when I pushed Yes.", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class
