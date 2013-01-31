Public Class Message_Formatter


    Private Sub displayButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles displayButton.Click
        messageOutPutBox.TextAlign = ContentAlignment.MiddleCenter
        messageOutPutBox.Text = nameTextBox.Text & " blah " & messageTextBox.Text
    End Sub

    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub clearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearButton.Click
        messageOutPutBox.Text = String.Empty
        nameTextBox.Text = ""
        messageTextBox.Clear()
        nameTextBox.Focus()
    End Sub

    Private Sub blackRadio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles blackRadio.CheckedChanged
        messageOutPutBox.ForeColor = Color.Black
        messageOutPutBox.BackColor = Color.White
    End Sub

    Private Sub blueRadio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles blueRadio.CheckedChanged
        messageOutPutBox.ForeColor = Color.Blue
        messageOutPutBox.BackColor = Color.White
    End Sub

    Private Sub greenRadio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles greenRadio.CheckedChanged
        messageOutPutBox.ForeColor = Color.Green
        messageOutPutBox.BackColor = Color.White
    End Sub

    Private Sub redRadio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles redRadio.CheckedChanged
        messageOutPutBox.ForeColor = Color.Red
        messageOutPutBox.BackColor = Color.White
    End Sub

    Private Sub viewMessage_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles viewMessage.CheckedChanged
        messageOutPutBox.Visible = viewMessage.Checked
    End Sub
End Class
