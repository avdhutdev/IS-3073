'Project: Homework 4
'Programmer: John-William Trenholm
'Date: 3-16-2012
'Description: Calculations, menus, functions oh my.
Public Class vbinfo
    Private Sub calcButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calcButton.Click
        'Figure out what to bill for.
        Dim steroPrice, leatherPrice, navigationPrice, finishCost, carsalesPrice, totalAmount, taxAmount, accessoriesPrice, salesPrice, tradeInPrice As Decimal

        If (stereoCheckbox.Checked) Then
            steroPrice = 425.76
        End If
        If (leatherCheckbox.Checked) Then
            leatherPrice = 987.41
        End If
        If (navigationCheckbox.Checked) Then
            navigationPrice = 1741.23
        End If
        'figure out what thing is checked to set the correct amount.
        If (standardRadio.Checked) Then
            finishCost = 0
        End If
        If (pearlRadio.Checked) Then
            finishCost = 345.72
        End If
        If (customizedRadio.Checked) Then
            finishCost = 599.99
        End If

        ' Calculate price and add to order total.
        Try
            carsalesPrice = Decimal.Parse(carSalesPriceTextBox.Text)
            'assignes the value ot tradein.
            Try
                tradeInPrice = Decimal.Parse(tradeInValueBox.Text)

                accessoriesPrice = steroPrice + leatherPrice + navigationPrice
                accessoriesFinishLabel.Text = accessoriesPrice

                salesPrice = accessoriesPrice + finishCost + carsalesPrice
                subTotalBox.Text = salesPrice

                taxAmount = calcTaxRax(salesPrice)
                salesTaxBox.Text = taxAmount

                totalAmount = taxAmount + salesPrice

                totalBox.Text = totalAmount

                salesPrice = totalAmount - tradeInPrice

                amountDueBox.Text = salesPrice

            Catch ex As Exception
                MessageBox.Show("Trade in value must be Numeric or Decial.", "Trade In Price Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try


        Catch QuantityException As FormatException
            MessageBox.Show("Price must be Numeric or Decial.", "Sales Price Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
End Class
