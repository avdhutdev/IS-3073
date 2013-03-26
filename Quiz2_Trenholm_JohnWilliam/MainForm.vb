'Project:       Exercise 6.4
'Programmer:    John-William Trenholm
'Date:          August 2008
'Description:   This program will determine the winner in a taste
'               test challenge between Apple Ade and Prune Punch.
'Folder:        EX0604
'Form:		    MainForm

Option Strict On

Public Class MainForm


    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub

    Private Sub NewTesterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewTesterToolStripMenuItem.Click
        NewTesterForm.Show()
    End Sub

    Private Sub SummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SummaryToolStripMenuItem.Click

        If NewTesterForm.numberOfVotes > 0 Then

            SummaryForm.Show()
        Else
            MessageBox.Show("No data to summarize", "No data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class
