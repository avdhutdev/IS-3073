' Project: HomeWork1 
' Programmer: John-William Trenholm
' Date: 1-27-2013
' Description: This program will allow you to change the styling of text and show a print preview.


Public Class previewWindow
    'Exit button logic.
    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        'Close the Program
        Me.Close()
    End Sub
    'Print preview logic
    Private Sub printPreviewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles printPreviewButton.Click
        'Print preview Dialog.
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub
    'clear everything button.
    Private Sub clearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearButton.Click
        outputBox.Text = String.Empty
        dobTextBox.Text = String.Empty
        nameTextBox.Text = String.Empty
    End Sub
    'Checkbox
    Private Sub visableCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles visableCheckBox.CheckedChanged
        outputBox.Visible = visableCheckBox.Checked
    End Sub
    'Display the output
    Private Sub displayButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles displayButton.Click
        outputBox.Text = nameTextBox.Text & " as born on " & dobTextBox.Text
    End Sub

    'Black Button Stuff
    Private Sub blackButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles blackButton.Click
        'When the user clicks the button, highlight the output area with the color and change the text to White.
        outputBox.BackColor = Color.Black
        outputBox.ForeColor = Color.White
    End Sub
    Private Sub blackButton_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles blackButton.MouseEnter
        'When the mouse enters the button make the button highlight White.
        Me.blackButton.BackColor = Color.Black
        Me.blackButton.ForeColor = Color.White
    End Sub
    Private Sub blackButton_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles blackButton.MouseLeave
        'When the mouse leaves the button, go back to normal.
        Me.blackButton.BackColor = Color.Transparent
        Me.blackButton.ForeColor = Color.Black
    End Sub

    'White Button Stuff
    Private Sub whiteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WhiteButton.Click
        'When the user clicks the button, highlight the output area with the color and change the text to black.
        outputBox.ForeColor = Color.Black
        outputBox.BackColor = Color.White
    End Sub
    Private Sub whiteButton_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WhiteButton.MouseEnter
        'When the mouse enters the button make the button highlight White.
        Me.WhiteButton.BackColor = Color.White
    End Sub
    Private Sub whiteButton_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WhiteButton.MouseLeave
        'When the mouse leaves the button, go back to normal.
        Me.WhiteButton.BackColor = Color.Transparent
    End Sub

    'Gray button stuff
    Private Sub greyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles greyButton.Click
        'When the user clicks the button, highlight the output area with the color and change the text to black.
        outputBox.ForeColor = Color.Black
        outputBox.BackColor = Color.Gray
    End Sub
    Private Sub greyButton_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles greyButton.MouseEnter
        'When the mouse enters the button make the button highlight gray.
        Me.greyButton.BackColor = Color.Gray
    End Sub
    Private Sub greyButton_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles greyButton.MouseLeave
        'When the mouse leaves the button, go back to normal.
        Me.greyButton.BackColor = Color.Transparent
    End Sub

    'Red Button Stuff
    Private Sub redButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles redButton.Click
        'When the user clicks the button, highlight the output area with the color and change the text to White.
        outputBox.ForeColor = Color.Red
    End Sub
    Private Sub redButton_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles redButton.MouseEnter
        'When the mouse enters the button make the button highlight White.
        Me.redButton.ForeColor = Color.Red

    End Sub
    Private Sub redButton_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles redButton.MouseLeave
        'When the mouse leaves the button, go back to normal.
        Me.redButton.ForeColor = Color.Black
    End Sub

    'Blue Button Stuff
    Private Sub blueButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles blueButton.Click
        'When the user clicks the button, highlight the output area with the color and change the text to black.
        outputBox.ForeColor = Color.Blue
    End Sub
    Private Sub blueButton_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles blueButton.MouseEnter
        'When the mouse enters the button make the button highlight White.
        Me.blueButton.ForeColor = Color.Blue
    End Sub
    Private Sub blueButton_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles blueButton.MouseLeave
        'When the mouse leaves the button, go back to normal.
        Me.blueButton.ForeColor = Color.Black
    End Sub

    'Yellow button stuff
    Private Sub yellowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles yellowButton.Click
        'When the user clicks the button, highlight the output area with the color and change the text to black.
        outputBox.ForeColor = Color.Yellow
    End Sub
    Private Sub yellowButton_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles yellowButton.MouseEnter
        'When the mouse enters the button make the button highlight gray.
        Me.yellowButton.ForeColor = Color.Yellow
    End Sub
    Private Sub yellowButton_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles yellowButton.MouseLeave
        'When the mouse leaves the button, go back to normal.
        Me.yellowButton.ForeColor = Color.Black
    End Sub

    'Font Styles
    Private Sub boldButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boldButton.Click
        'Create a new font type and set the output to bold font.
        outputBox.Font = New Font("Microsoft Sans Serif", 18, Drawing.FontStyle.Bold)
    End Sub
    Private Sub italicButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles italicButton.Click
        'Create a new font type and set the output to the italic font.
        outputBox.Font = New Font("Microsoft Sans Serif", 18, Drawing.FontStyle.Italic)
    End Sub
    Private Sub UnderlineButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles underlineButton.Click
        'Create a new font type and set the output to underline font.
        outputBox.Font = New Font("Microsoft Sans Serif", 18, Drawing.FontStyle.Underline)
    End Sub

    'Alingment
    Private Sub leftRadio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles leftRadio.CheckedChanged
        'Set the text alignment left
        outputBox.TextAlign = ContentAlignment.MiddleLeft
    End Sub
    Private Sub centerRadio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles centerRadio.CheckedChanged
        'Set the text alignment Center
        outputBox.TextAlign = ContentAlignment.MiddleCenter
    End Sub
    Private Sub rightRadio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rightRadio.CheckedChanged
        'Set the text alignment right
        outputBox.TextAlign = ContentAlignment.MiddleRight
    End Sub

    'Border Styles
    Private Sub fixedSingleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fixedSingleButton.Click
        'Set the border to fixed single
        outputBox.BorderStyle = BorderStyle.FixedSingle
    End Sub
    Private Sub fix3dButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fix3dButton.Click
        'set the border to fix3d
        outputBox.BorderStyle = BorderStyle.Fixed3D
    End Sub
    Private Sub noneButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles noneButton.Click
        'set the boarder to none
        outputBox.BorderStyle = BorderStyle.None
    End Sub

    'reset button.
    Private Sub resetButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles resetButton.Click
        'set everything back to normal
        outputBox.BorderStyle = BorderStyle.None
        outputBox.TextAlign = ContentAlignment.TopLeft
        outputBox.ForeColor = Color.Black
        outputBox.BackColor = Color.Transparent
        outputBox.Font = New Font("Microsoft Sans Serif", 18, Drawing.FontStyle.Regular)
    End Sub

End Class
