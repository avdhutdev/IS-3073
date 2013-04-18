Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RnrBooksDataSet1.Books' table. You can move, or remove it, as needed.
        Me.BooksTableAdapter1.Fill(Me.RnrBooksDataSet1.Books)


    End Sub
End Class
