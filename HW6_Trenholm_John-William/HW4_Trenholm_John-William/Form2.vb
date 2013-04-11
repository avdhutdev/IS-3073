'Project: Homework 4
'Programmer: John-William Trenholm
'Date: 3-16-2012
'Description: Calculations, menus, functions oh my.
Public Class Form2
    'closes the window
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
    'opens up the about window.
    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub
    'Calls the remote form
    Private Sub InputSaleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputSaleToolStripMenuItem.Click
        vbinfo.Show()
    End Sub
    'Calls the remote form's color
    Private Sub ColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorToolStripMenuItem.Click
        vbinfo.ColorDialog1.ShowDialog()
        vbinfo.amountDueBox.ForeColor = vbinfo.ColorDialog1.Color
    End Sub
    'Calls the remote form's Font
    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click
        vbinfo.FontDialog1.ShowDialog()
        vbinfo.amountDueBox.Font = vbinfo.FontDialog1.Font
    End Sub
End Class