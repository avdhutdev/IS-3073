'Program: Chapter 12 BookSale Step-by-Step
'Programmer: John-William Trenholm
'Date: 4-2-2013
'Description: Calculate sales price using the BookSale class.
' Instantiate TheBookSale as a new object of the BookSale class.
'Folder: Ch12SBS

Public Class SalesForm
    ' Declare the new object.
    Private TheBookSale As BookSale
    Private TheStudentBookSale As StudentBookSale

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub


    Private Sub CalculateSalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateSalesToolStripMenuItem.Click
        Try
            If studentCheckBox.Checked Then
                ' Instantiate the StudentBookSale object and set the properties.
                TheStudentBookSale = New StudentBookSale(titleBox.Text, _
                Integer.Parse(QuantityBox.Text), Decimal.Parse(priceBox.Text))
                ' Calculate and format the result.
                extendedPriceBox.Text = TheStudentBookSale.ExtendedPrice.ToString("N")
            Else
                TheBookSale = New BookSale(titleBox.Text, Integer.Parse(QuantityBox.Text), Decimal.Parse(priceBox.Text))
                extendedPriceBox.Text = TheBookSale.ExtendedPrice.ToString("N")
            End If
        Catch ex As Exception
            MessageBox.Show("Enter numeric data.", "R 'n R Book Sales", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        ' Clear the screen controls.
        QuantityBox.Clear()
        priceBox.Clear()
        extendedPriceBox.Clear()
        With titleBox
            .Clear()
            .Focus()
        End With
    End Sub

    Private Sub summaryMenuStrip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles summaryMenuStrip.Click
        Dim MessageString As String
        MessageString = "Sales Total: " & BookSale.salesTotal.ToString("C") & _
        Environment.NewLine & "Sales Count: " & BookSale.salesTotal.ToString("c")
        MessageString = "Sales Total: " & BookSale.salesTotal.ToString("C") & _
            Environment.NewLine & "Sales Count: " & BookSale.salesTotal.ToString() & _
            Environment.NewLine & "Total of Student Discounts: " & _
            StudentBookSale.DiscountTotal.ToString("C")
    End Sub
End Class
