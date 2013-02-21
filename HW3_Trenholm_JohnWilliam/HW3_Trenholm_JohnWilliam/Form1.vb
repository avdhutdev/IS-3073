' Project: HomeWork3
' Programmer: John-William Trenholm
' Date: 2-20-2013
' Description: VB Mail Order.

'I thought this assingment was rather challenging. It made me feel dumb.

Public Class vbMailOrder
    'Global variables because I didn't want to recreate the try/catch block in both the add buttton & summary button.
    Dim item1Qauntity, item2Qauntity, item3Qauntity, item4Qauntity As Integer
    Dim item1Desc, item2Desc, item3Desc, item4Desc As String
    Dim item1Weight, item2Weight, item3Weight, item4Weight, item1Price, item2Price, item3Price, item4Price As Decimal

    Private Sub printPreviewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles printPreviewButton.Click
        'Print preview Dialog.
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        'Close the Program
        Me.Close()
    End Sub
    Private Sub summaryButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles summaryButton.Click
        'Setup local variables to do calculations. 
        Dim totalPrice, totalShipping, totalTax, finaltotalPrice, taxRate, tax, shippingHandling, shippingWeight, intermediatePrice As Decimal
        Dim price1, price1Weight, price1Tax, price1Total As Decimal
        Dim price2, price2Weight, price2Tax, price2Total As Decimal
        Dim price3, price3Weight, price3Tax, price3Total As Decimal
        Dim price4, price4Weight, price4Tax, price4Total As Decimal

        'When the summary button is ran, make some boxes read-only so that they can not be tampered with.
        stateTextBox.ReadOnly = True
        addItem1Button.Enabled = False
        removeItem1Button.Enabled = False
        removeItem2Button.Enabled = False
        removeItem3Button.Enabled = False
        removeItem4Button.Enabled = False

        'Do calcs
        price1 = item1Price * item1Qauntity
        price1Weight = item1Weight * item1Qauntity

        price2 = item2Price * item2Qauntity
        price2Weight = item2Weight * item2Qauntity

        price3 = item3Price * item3Qauntity
        price3Weight = item3Weight * item3Qauntity

        price4 = item4Price * item4Qauntity
        price4Weight = item4Weight * item4Qauntity



        totalPrice = price1Total + price2Total + price3Total + price4Total
        totalShipping = (price1Weight + price2Weight + price3Weight + price4Weight) * 0.25
        totalTax = price1Tax + price2Tax + price3Tax + price4Tax

        'Figure out state to do tax & stuff.
        If stateTextBox.Text.ToUpper = "CA" Then
            totalTax = (price1 + price2 + price3 + price4) * 0.08
        Else
            totalTax = 0
        End If

        'Add Everything up
        finaltotalPrice = (totalPrice * totalTax) + totalShipping

        'Up date the fields with the total amounts.
        amountBox.Text = totalPrice.ToString("c")
        shippingBox.Text = totalShipping.ToString("c")
        taxBox.Text = totalTax.ToString("c")
        totalAmountBox.Text = finaltotalPrice.ToString("c")
    End Sub

    Private Sub addItem1Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addItem1Button.Click

        Try
            item1Qauntity = Integer.Parse(itemquantBox.Text)
            Try
                If itemTextBox.Text = "" Then
                    MessageBox.Show("Error in Item Description Box", "input error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    item1Desc = itemTextBox.Text
                End If
                Try
                    item1Price = Decimal.Parse(itemPriceBox.Text)
                    Try
                        item1Weight = Decimal.Parse(itemWeightBox.Text)
                    Catch ex As Exception
                        MessageBox.Show("Error in Item Weight Box", "input error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End Try
                Catch ex As Exception
                    MessageBox.Show("Error in Item Price Box", "input error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try
            Catch ex As Exception
                MessageBox.Show("Error in Item Desc Box", "input error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try

            item1quantBox.Text = itemquantBox.Text
            item1TextBox.Text = itemTextBox.Text
            item1WeightBox.Text = itemWeightBox.Text
            item1PriceBox.Text = itemPriceBox.Text

            item2quantBox.Text = item1quantBox.Text
            item2TextBox.Text = item1TextBox.Text
            item2WeightBox.Text = item1WeightBox.Text
            item2PriceBox.Text = item1PriceBox.Text

            item3quantBox.Text = item2quantBox.Text
            item3TextBox.Text = item2TextBox.Text
            item3WeightBox.Text = item2WeightBox.Text
            item3PriceBox.Text = item2PriceBox.Text

            item4quantBox.Text = item3quantBox.Text
            item4TextBox.Text = item3TextBox.Text
            item4WeightBox.Text = item3WeightBox.Text
            item4PriceBox.Text = item3PriceBox.Text

        Catch ex As Exception
            MessageBox.Show("Error in Item Quantity Box", "input error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try



    End Sub

    Private Sub clearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearButton.Click
        nameBox.Clear()
        addressBox.Clear()
        cityBox.Clear()
        stateTextBox.Clear()
        zipBox.Clear()
        itemquantBox.Clear()
        item1quantBox.Clear()
        item2quantBox.Clear()
        item3quantBox.Clear()
        item4quantBox.Clear()
        itemTextBox.Clear()
        item1TextBox.Clear()
        item2TextBox.Clear()
        item3TextBox.Clear()
        item4TextBox.Clear()
        itemWeightBox.Clear()
        item1WeightBox.Clear()
        item2WeightBox.Clear()
        item3WeightBox.Clear()
        item4WeightBox.Clear()
        itemPriceBox.Clear()
        item1PriceBox.Clear()
        item2PriceBox.Clear()
        item3PriceBox.Clear()
        item4PriceBox.Clear()
        totalAmountBox.Clear()
        shippingBox.Clear()
        taxBox.Clear()
        amountBox.Clear()
        stateTextBox.ReadOnly = False
        addItem1Button.Enabled = True
        removeItem1Button.Enabled = True
        removeItem2Button.Enabled = True
        removeItem3Button.Enabled = True
        removeItem4Button.Enabled = True
    End Sub

    Private Sub removeItem1Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles removeItem1Button.Click
        item1quantBox.Clear()
        item1TextBox.Clear()
        item1PriceBox.Clear()
        item1WeightBox.Clear()
    End Sub

    Private Sub removeItem2Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles removeItem2Button.Click
        item2quantBox.Clear()
        item2TextBox.Clear()
        item2PriceBox.Clear()
        item2WeightBox.Clear()
    End Sub

    Private Sub removeItem3Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles removeItem3Button.Click
        item3quantBox.Clear()
        item3TextBox.Clear()
        item3PriceBox.Clear()
        item3WeightBox.Clear()
    End Sub

    Private Sub removeItem4Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles removeItem4Button.Click
        item4quantBox.Clear()
        item4TextBox.Clear()
        item4PriceBox.Clear()
        item4WeightBox.Clear()
    End Sub
End Class
