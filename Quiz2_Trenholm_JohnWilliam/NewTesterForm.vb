'Project:       Exercise 6.4
'Programmer:    John-William Trenholm
'Date:          August 2008
'Description:   This program will determine the winner in a taste
'               test challenge between Apple Ade and Prune Punch.
'Folder:        EX0604
'Form:		    NewTesterForm

Option Strict On

Public Class NewTesterForm
    Friend numberOfVotes, appleInt, pruneInt As Integer
 
    Private Sub OkButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OkButton.Click
        'get input & tell the user they should type stuff in... or else....
        Try
            If Integer.Parse(AppleTextBox.Text) < 10 And Integer.Parse(AppleTextBox.Text) >= 1 Then
                appleInt += Integer.Parse(AppleTextBox.Text)

            Else
                MessageBox.Show("Must be between 1 & 10", "Apple Input error", MessageBoxButtons.OK)
            End If

            Try
                If Integer.Parse(PruneTextBox.Text) < 10 And Integer.Parse(PruneTextBox.Text) >= 1 Then
                    pruneInt += Integer.Parse(PruneTextBox.Text)
                Else
                    MessageBox.Show("Must be between 1 & 10", "Prune Input error", MessageBoxButtons.OK)
                End If

                numberOfVotes = numberOfVotes + 1
                AppleTextBox.Text = ""
                PruneTextBox.Text = ""
            Catch ex As Exception
                MessageBox.Show("Error in Prune Input Field", "Prune Input error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        Catch ex As Exception
            MessageBox.Show("Error in Apple Input Field", "Apple Input error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Me.Hide()
    End Sub
End Class