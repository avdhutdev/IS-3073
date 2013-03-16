Public Class Form1

    Private Sub calcButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calcButton.Click
        Dim steroPrice, leatherPrice, navigationPrice, finishCost, carsalesPrice, totalAmount, taxAmount, accessoriesPrice, salesPrice, tradeInPrice As Decimal
        Const TAX_RATE_Decimal As Decimal = 0.08D
        If (stereoCheckbox.Checked) Then
            steroPrice = 425.76
        End If
        If (leatherCheckbox.Checked) Then
            leatherPrice = 987.41
        End If
        If (navigationCheckbox.Checked) Then
            navigationPrice = 1741.23
        End If

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
            Try
                tradeInPrice = Decimal.Parse(tradeInValueBox.Text)

                accessoriesPrice = steroPrice + leatherPrice + navigationPrice
                accessoriesFinishLabel.Text = accessoriesPrice

                salesPrice = accessoriesPrice + finishCost + carsalesPrice
                subTotalBox.Text = salesPrice

                taxAmount = salesPrice * TAX_RATE_Decimal
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

    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
