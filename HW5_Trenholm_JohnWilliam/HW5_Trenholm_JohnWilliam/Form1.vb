﻿Public Class Form1

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
        If yachtAddBox.Text <> "" Then
            yachtAddBox.Items.Add(yachtAddBox.Text)
            yachtAddBox.Text = ""
        End If
    End Sub
End Class