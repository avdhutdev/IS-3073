'Project:       Exercise 6.4
'Programmer:    John-William Trenholm
'Date:          August 2008
'Description:   This program will determine the winner in a taste
'               test challenge between Apple Ade and Prune Punch.
'Folder:        EX0604
'Form:		    SummaryForm

Option Strict On

Public Class SummaryForm

    Dim appleAvg As Double
    Dim pruneAvg As Double

    Private Sub OkButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OkButton.Click
        Me.Close()
    End Sub

    Private Sub SummaryForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        appleAvg = NewTesterForm.appleInt / NewTesterForm.numberOfVotes
        pruneAvg = NewTesterForm.pruneInt / NewTesterForm.numberOfVotes
        AppleAvgTextBox.Text = appleAvg.ToString
        PruneAvgTextBox.Text = pruneAvg.ToString

        If NewTesterForm.appleInt = NewTesterForm.pruneInt Then
            WinnerTextBox.Text = "It's a tie!"
        ElseIf NewTesterForm.appleInt > NewTesterForm.pruneInt Then
            WinnerTextBox.Text = "The Winner is APPLE ADE PUNCH!"
        Else
            WinnerTextBox.Text = "The Winner is PRUNE PUNCH!"
        End If
        TotalTestersTextBox.Text = "There were" & NewTesterForm.numberOfVotes.ToString() & " taste testers"

    End Sub
End Class