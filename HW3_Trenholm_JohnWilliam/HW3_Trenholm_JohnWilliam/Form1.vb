Public Class vbMailOrder


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

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
        Dim totalPrice, totalShipping, totalTax, taxRate, tax, shippingHandling, shippingWeight, intermediatePrice As Decimal
        Dim price1, price1Weight, price1Tax, prince1Total As Decimal
        Dim price2, price2Weight, price2Tax, prince2Total As Decimal
        Dim price3, price3Weight, price3Tax, prince3Total As Decimal
        Dim price4, price4Weight, price4Tax, prince4Total As Decimal
        ' Dim price1, price2, price3, price4 As Decimal
        stateTextBox.ReadOnly = True
        addItem1Button.Enabled = False

        price1 = Decimal.Parse(itemPriceBox.Text) * Decimal.Parse(itemquantBox.Text)
        price1Weight = Decimal.Parse(itemWeightBox.Text) * Decimal.Parse(itemquantBox.Text)
        price1Tax = (price1 * taxRate)
        If price1Weight < 10 Then
            price1Weight = 1
        ElseIf price1Weight > 10 & price1Weight < 100 Then
            price1Weight = 1
        ElseIf price1Weight < 100 Then
            price1Weight = 1
        End If


        prince1Total = (price1 * taxRate)

        If (item2PriceBox.Text <> "") Then
            price2 = Decimal.Parse(ite1PriceBox.Text) * Decimal.Parse(item1quantBox.Text)
            price2Weight = Decimal.Parse(item1WeightBox.Text) * Decimal.Parse(item1quantBox.Text)
            price2Tax = (price2 * taxRate)
            prince2Total = (price2 * taxRate)
        End If
        If (item3PriceBox.Text <> "") Then
            price3 = Decimal.Parse(item2PriceBox.Text) * Decimal.Parse(item2quantBox.Text)
            price3Weight = Decimal.Parse(item2WeightBox.Text) * Decimal.Parse(item2quantBox.Text)
            price3Tax = (price3 * taxRate)
            prince3Total = (price3 * taxRate)
        End If
        If (item4PriceBox.Text <> "") Then
            price4 = Decimal.Parse(item3PriceBox.Text) * Decimal.Parse(item3quantBox.Text)
            price4Weight = Decimal.Parse(item3WeightBox.Text) * Decimal.Parse(item3quantBox.Text)
            price4Tax = (price4 * taxRate)
            prince4Total = (price4 * taxRate)
        End If
        totalPrice = prince1Total + prince2Total + prince3Total + prince4Total
        totalShipping = price1Weight + price2Weight + price3Weight + price4Weight
        totalTax = price1Tax + price2Tax + price3Tax + price4Tax
        taxBox.Text = totalTax.ToString("c")
        shippingBox.Text = totalShipping.ToString("c")
        totalAmountBox.Text = totalPrice.ToString("c")
    End Sub

    Private Sub addItem1Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addItem1Button.Click
        Dim item1Qauntity, item2Qauntity, item3Qauntity, item4Qauntity As Integer
        Dim item1Desc, item2Desc, item3Desc, item4Desc As String
        Dim item1Weight, item2Weight, item3Weight, item4Weight, item1Price, item2Price, item3Price, item4Price As Decimal
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
            ite1PriceBox.Text = itemPriceBox.Text

            If item1quantBox.Text = "" Then

                item2quantBox.Text = item1quantBox.Text
                item2TextBox.Text = item1TextBox.Text
                item2WeightBox.Text = item1WeightBox.Text
                item2PriceBox.Text = ite1PriceBox.Text

                If item2quantBox.Text = "" Then
                    item3quantBox.Text = item2quantBox.Text
                    item3TextBox.Text = item2TextBox.Text
                    item3WeightBox.Text = item2WeightBox.Text
                    item3PriceBox.Text = item2PriceBox.Text

                    If item4quantBox.Text = "" Then
                        item4quantBox.Text = item3quantBox.Text
                        item4TextBox.Text = item3TextBox.Text
                        item4WeightBox.Text = item3WeightBox.Text
                        item4PriceBox.Text = item3PriceBox.Text
                    End If
                End If
            End If
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
        itemTextBox.Clear()
        item1TextBox.Clear()
        item2TextBox.Clear()
        item3TextBox.Clear()
        itemWeightBox.Clear()
        item1WeightBox.Clear()
        item2WeightBox.Clear()
        item3WeightBox.Clear()
        itemPriceBox.Clear()
        ite1PriceBox.Clear()
        item2PriceBox.Clear()
        item3PriceBox.Clear()
        totalAmountBox.Clear()
        shippingBox.Clear()
        taxBox.Clear()
        amountBox.Clear()
        stateTextBox.ReadOnly = False
        addItem1Button.Enabled = True
    End Sub

End Class
