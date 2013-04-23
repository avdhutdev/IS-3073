Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RnrBooksDataSet1.DataTable2' table. You can move, or remove it, as needed.
        'Me.DataTable2TableAdapter.Fill(Me.RnrBooksDataSet1.DataTable2)
        'TODO: This line of code loads data into the 'RnrBooksDataSet1.Books' table. You can move, or remove it, as needed.
        Me.BooksTableAdapter1.Fill(Me.RnrBooksDataSet1.Books)


    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
