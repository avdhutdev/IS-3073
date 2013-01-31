'Project:           Ch02RichTextBoxes
'Programmer:        Bradley/Millspaugh
'Date:              June 2008
'Description:       Demonstrate some of the capabilities of a Rich Text Box.


Public Class RichTextBoxForm

    Private Sub RichTextBoxForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Fill the Rich Text Boxes.

        TitleRichTextBox.Text = "        Pamper Yourself" & Environment.NewLine _
          & "    All Your Favorite Books"
        SampleRichTextBox.LoadFile("Rich Text Boxes.rtf")
    End Sub
End Class
