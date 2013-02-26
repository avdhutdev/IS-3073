'Project:       Exercise 4.9
'Programmer:    John-William Trenholm
'Date:          2-21-2012
'Description:   Catherine's Catering offers a variety of choices
'               for your dining experience.  This projects calculates
'               the amount due for a single event.  The summary displays
'               the total number of events and the total dollar amount for all events.
'Folder:        EX0409

Option Strict On

Public Class CateringForm
    Dim finalTotal, eventCount As Double


    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub


    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        AmountDueTextBox.Clear()
        GuestTextBox.Clear()
        eventCount = 0
        finalTotal = 0

    End Sub

    Private Sub CalculateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateButton.Click
        Dim dinnerChoice, alcohol, price, total As Double
        Dim guestNum As Integer

        If OpenBarCheckBox.Checked Then
            alcohol = 25.0
        ElseIf WineCheckBox.Checked Then
            alcohol = 8.0
        Else
            alcohol = 0
        End If

        Try
            guestNum = Integer.Parse(GuestTextBox.Text)
            If PrimeRibRadioButton.Checked Then
                dinnerChoice = 25.95
            ElseIf ChickenRadioButton.Checked Then
                dinnerChoice = 18.95
            ElseIf PastaRadioButton.Checked Then
                dinnerChoice = 12.95
            Else
                MessageBox.Show("Please Select a Course", "Course Selection", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error in Guest Number Box", "Guest number Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        total = (guestNum * dinnerChoice) + (guestNum * alcohol)
        AmountDueTextBox.Text = total.ToString("c")
        finalTotal = finalTotal + total
        eventCount = eventCount + 1

    End Sub


    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub SummaryButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SummaryButton.Click
        Dim WhichButtonDialogResult As DialogResult
        WhichButtonDialogResult = MessageBox.Show("Total Number of Events: " & eventCount & Environment.NewLine & Environment.NewLine & "Total Dollar Amount: " & finalTotal & Environment.NewLine & Environment.NewLine & Environment.NewLine & Environment.NewLine & " Would you like to clear the summary information?", "Clear Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If WhichButtonDialogResult = DialogResult.Yes Then
            Call ClearButton_Click(sender, e)
        End If
    End Sub
End Class
