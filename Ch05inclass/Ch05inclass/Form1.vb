Public Class Form1


    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click
        If (FontToolStripMenuItem.Checked = True) Then
            With FontDialog1
                .Font = SubTotalTextBox.Font
                .ShowDialog()
                SubTotalTextBox.Font = .Font
                TotalTextBox.Font = .Font
            End With
        End If
    End Sub

    Private Sub ColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorToolStripMenuItem.Click
        With ColorDialog1
            .Color = SubTotalTextBox.ForeColor
            .ShowDialog()
            SubTotalTextBox.ForeColor = .Color
            TotalTextBox.ForeColor = .Color
        End With
    End Sub

    Private Sub ColorToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorToolStripMenuItem1.Click
        With ColorDialog1
            .Color = SubTotalTextBox.ForeColor
            .ShowDialog()
            TotalTextBox.ForeColor = .Color
        End With
    End Sub

    Private Sub FontToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem2.Click
        With FontDialog1
            .Font = SubTotalTextBox.Font
            .ShowDialog()
            TotalTextBox.Font = .Font
        End With
    End Sub

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click, ClearToolStripMenuItem2.Click, ClearToolStripMenuItem2.Click
        TotalTextBox.Clear()
        SubTotalTextBox.Clear()
    End Sub
End Class
