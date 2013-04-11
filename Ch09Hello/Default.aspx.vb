'Web Site: Ch09Hello
'Web page: Default.aspx
'Programmer: Your Name
'Date: June 2008
'Description: Concatenate the name and display in a label.
Partial Class _Default
    Inherits System.Web.UI.Page
    Protected Sub SubmitButton_Click(ByVal sender As Object, _
    ByVal e As System.EventArgs) Handles SubmitButton.Click
        ' Display the name and a message.
        MessageLabel.Text = "Hello " & NameTextBox.Text & "!"
    End Sub
End Class