'Project: Homework 7
'Programmer: John-William Trenholm
'Date: 4-7-2013
'Description: Calculations, menus, functions oh my.
Public Class vbinfo
    Private AutoPurchases As Purchases
    Private CarSalesPriceDeciaml, TradeInAmountDecimal As Decimal
    Private Sub calcButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calcButton.Click
        'Try catch to test for validations
        Try
            'Test to make sure decimal is entered in textbox
            CarSalesPriceDeciaml = Decimal.Parse(carSalesPriceTextBox.Text)
            Try
                'Test to make sure decimal is entered in textbox
                TradeInAmountDecimal = Decimal.Parse(tradeInValueBox.Text)

                If standardRadio.Checked() Or pearlRadio.Checked() Or customizedRadio.Checked() Then
                    AutoPurchases = New Purchases(stereoCheckbox.Checked, leatherCheckbox.Checked, navigationCheckbox.Checked, _
                                                  pearlRadio.Checked, customizedRadio.Checked, CarSalesPriceDeciaml, TradeInAmountDecimal)
                    AutoPurchases.Calc()

                    accessoriesFinishLabel.Text = AutoPurchases.AccessoriesAndFinish.ToString("n")
                    subTotalBox.Text = AutoPurchases.Subtotal.ToString("n")
                    salesTaxBox.Text = AutoPurchases.SalesTax.ToString("n")
                    totalBox.Text = AutoPurchases.Total.ToString("n")
                    tradeInValueBox.Text = AutoPurchases.TradeinAmount.ToString("n")
                    amountDueBox.Text = AutoPurchases.AmtDue.ToString("n")
                Else
                    MessageBox.Show("Please Select an exterior finish.", "Selection Error", _
                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show("Please Enter and Numeric Trade-In.", "Data Entry Error", _
                    MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        Catch ex As Exception
            MessageBox.Show("Please Enter Numeric Data.", "Data Entry Error", _
            MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Try

    End Sub
    'function to calc tax rate
    Private Function calcTaxRax(ByVal salesPrice As Decimal)
        Const TAX_RATE_Decimal As Decimal = 0.08D

        Return salesPrice * TAX_RATE_Decimal
    End Function
    'clears the values.
    Private Sub clearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearButton.Click
        stereoCheckbox.Checked = False
        leatherCheckbox.Checked = False
        navigationCheckbox.Checked = False
        carSalesPriceTextBox.Clear()
        accessoriesFinishLabel.Clear()
        subTotalBox.Clear()
        salesTaxBox.Clear()
        totalBox.Clear()
        tradeInValueBox.Clear()
        amountDueBox.Clear()
        standardRadio.Checked = False
        pearlRadio.Checked = False
        customizedRadio.Checked = False
    End Sub
    'closes the window
    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
    'closes teh window from the menu
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
    'clears the stuff.
    Private Sub CLearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLearToolStripMenuItem.Click
        Call clearButton_Click(sender, e)
    End Sub
    'calcs the stuff from the menu window
    Private Sub CalculateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateToolStripMenuItem.Click
        Call calcButton_Click(sender, e)
    End Sub
    'set the color
    Private Sub ColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        amountDueBox.ForeColor = ColorDialog1.Color
    End Sub
    'sets teh font
    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click
        FontDialog1.ShowDialog()
        amountDueBox.Font = FontDialog1.Font
    End Sub
    'brings up the about window.
    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub summary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles summary.Click
        summaryForm.ShowDialog()
    End Sub

    Private Sub amountDueBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles amountDueBox.TextChanged

    End Sub
End Class
