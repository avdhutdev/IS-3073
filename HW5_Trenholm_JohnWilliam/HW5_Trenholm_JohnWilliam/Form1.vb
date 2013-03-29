Public Class Form1

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub clearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearButton.Click
        responsiblePartyBox.Clear()
        hoursCharteredBox.Clear()
        totalChargesBox.Clear()

    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        AboutBox1.Show()

    End Sub

    Private Sub AddYachtTypeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddYachtTypeToolStripMenuItem.Click
        Dim foundItem As Boolean = True
        Dim indexInt As Integer = 0
        If yachtAddBox.Text <> "" Then

            Do While foundItem And indexInt < yachtAddBox.Items.Count()
                If yachtAddBox.Text = yachtAddBox.Items(indexInt).ToString() Then
                    indexInt = indexInt + 1
                    MessageBox.Show("This entry already exists.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    foundItem = False
                Else
                    yachtAddBox.Items.Add(yachtAddBox.Text)
                    yachtAddBox.Text = ""
                    foundItem = False
                End If
            Loop
        Else
            MessageBox.Show("Please enter a Yacht type to add.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub okButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles okButton.Click
        Dim yachtCostPerHour, totalHours, yachtLength, subTotalCost As Decimal
        Try

            yachtLength = Decimal.Parse(hoursCharteredBox.Text)
            If yachtLength = 22 Then
                yachtCostPerHour = 95
            ElseIf yachtLength = 24 Then
                yachtCostPerHour = 137.0
            ElseIf yachtLength = 30 Then
                yachtCostPerHour = 160.0
            ElseIf yachtLength = 32 Then
                yachtCostPerHour = 192.0
            ElseIf yachtLength = 36 Then
                yachtCostPerHour = 250.0
            ElseIf yachtLength = 38 Then
                yachtCostPerHour = 400.0
            ElseIf yachtLength = 45 Then
                yachtCostPerHour = 550.0
            End If

            Try
                totalHours = Decimal.Parse(hoursCharteredBox.Text)
                subTotalCost = hoursCharteredBox.Text * yachtCostPerHour
                totalChargesBox.Text = subTotalCost.ToString("c")

            Catch ex As Exception
                MessageBox.Show("Please enter the number of hours.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        Catch ex As Exception
            MessageBox.Show("Please select the length of the yacht.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub DisplayYachtTypeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayYachtTypeToolStripMenuItem.Click
        MessageBox.Show("The number of yacht types is: " & yachtAddBox.Items.Count(), "Yacht Count Type", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub

    Private Sub RemoveYachtTypeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveYachtTypeToolStripMenuItem.Click
        If yachtAddBox.Text <> "" Then
            yachtAddBox.Items.Remove(yachtAddBox.Text)
        Else
            MessageBox.Show("Please enter something to remove ", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class
