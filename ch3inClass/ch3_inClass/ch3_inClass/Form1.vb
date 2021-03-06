﻿Public Class Form1
    Private orderTotalDecimal As Decimal

    Private Sub calculateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculateButton.Click
        'following statements declare variables for calculation
        Dim priceDecimal, totalDecimal As Decimal
        Dim quantityInteger As Integer
        Try
            'parse text from text boxes into variables
            priceDecimal = Decimal.Parse(priceTextBox.Text)
            Try
                quantityInteger = Integer.Parse(quantityTextBox.Text)
            Catch ex As Exception
                MessageBox.Show("Error in textboxes 2", "Parse error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
            'calulate total
            totalDecimal = priceDecimal * quantityInteger
            totalTextBox.Text = totalDecimal.ToString()
            orderTotalDecimal += totalDecimal
            Dim orderTotal As Decimal
            orderTotal = orderTotalDecimal.ToString("c")
            MessageBox.Show("Number of Orders" & "Total Order: " & orderTotal, "Totals", MessageBoxButtons.OK)
        Catch ex As Exception
            MessageBox.Show("Error in textboxes 1", "input error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        'closes the form
        Me.Close()
    End Sub

    Private Sub clearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearButton.Click
        Dim clearButonDialogResult As DialogResult
        clearButonDialogResult = MessageBox.Show("Clear the current order figures?", "clear Order", _
             MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign)

        If clearButonDialogResult = DialogResult.Yes 
            priceTextBox.Text = ""
            quantityTextBox.Text = ""
            totalTextBox.Text = ""
            priceTextBox.Focus()
        End If
    End Sub

    Private Sub quantityTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles quantityTextBox.TextChanged

    End Sub
End Class
