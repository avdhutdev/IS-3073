'Project:     Quiz 3
'Programmer:  Please enter your name here.
'Date:        Nov 27 2012
'Description: This project maintains a list of bagel types. 
'             The user can add to the list, remove items from the list, display the
'             number of items in the list, and clear the list. 
'             The user can also print the list of bagel types.



Option Strict On

Public Class BagelsForm
    Private Sub orderButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles orderButton.Click
        If BagelTypesComboBox.Text <> "" Then
            OrderSummaryComboBox.Items.Add(BagelTypesComboBox.Text)
        Else
            MessageBox.Show("Please enter a Bagel to order.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub

    Private Sub removeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles removeButton.Click
        Dim ItemFoundBoolean As Boolean = False
        Dim ItemIndexInteger As Integer = 0
        Dim bagelCounter As Integer = 0

        If OrderSummaryComboBox.Text <> "" Then
            Do Until ItemIndexInteger = OrderSummaryComboBox.Items.Count()
                If OrderSummaryComboBox.Text = OrderSummaryComboBox.Items(ItemIndexInteger).ToString() Then
                    OrderSummaryComboBox.Items.RemoveAt(ItemIndexInteger)
                    bagelCounter = bagelCounter + 1
                Else
                    ItemIndexInteger += 1
                End If
            Loop
            If bagelCounter = 0 Then
                MessageBox.Show("Item is not in the list.", "No item match", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Please enter a Bagel to remove from the order.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        If bagelCounter > 0 Then
            MessageBox.Show("There is a total of " & bagelCounter & " items being removed.", "Results", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AddBagelTypeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddBagelTypeToolStripMenuItem.Click
        Dim foundItem As Boolean = True
        Dim indexInt As Integer = 0
        If BagelTypesComboBox.Text <> "" Then

            Do While foundItem And indexInt < BagelTypesComboBox.Items.Count()
                If BagelTypesComboBox.Text = BagelTypesComboBox.Items(indexInt).ToString() Then
                    indexInt = indexInt + 1
                    MessageBox.Show("This entry already exists.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    foundItem = False
                Else
                    BagelTypesComboBox.Items.Add(BagelTypesComboBox.Text)
                    BagelTypesComboBox.Text = ""
                    foundItem = False
                End If
            Loop
        Else
            MessageBox.Show("Please enter a Bagel type to add.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub RemoveBagelTypeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveBagelTypeToolStripMenuItem.Click
        Dim foundItem As Boolean = True
        Dim indexInt As Integer = 0
        If BagelTypesComboBox.Text <> "" Then

            Do While foundItem And indexInt < BagelTypesComboBox.Items.Count()
                If BagelTypesComboBox.Text = BagelTypesComboBox.Items(indexInt).ToString() Then
                    indexInt = indexInt + 1
                    MessageBox.Show("This entry does not exists.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    foundItem = False
                Else
                    BagelTypesComboBox.Items.Remove(BagelTypesComboBox.Text)
                    BagelTypesComboBox.Text = ""
                    foundItem = False
                End If
            Loop
        Else
            MessageBox.Show("Please enter a Bagel type to remove.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub ClearBagelListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearBagelListToolStripMenuItem.Click
        Dim output As DialogResult
        output = MessageBox.Show("Clear the begal list?.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If output = DialogResult.Yes Then
            BagelTypesComboBox.Items.Clear()
        End If

    End Sub

    Private Sub DisplayBagelTypeCountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayBagelTypeCountToolStripMenuItem.Click
        MessageBox.Show("There are " & OrderSummaryComboBox.Items.Count & " in the list", "Count List", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

    End Sub

    Private Sub PrintBagelsPrintDocument_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintBagelsPrintDocument.PrintPage
        e.Graphics.DrawString("Your Name", New Font("Arial", 36), Brushes.Black, 100, 100)
    End Sub

End Class

