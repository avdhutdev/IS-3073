Public Class DetailsForm

    Private Sub DetailsForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RnrBooksDataSet.Books' table. You can move, or remove it, as needed.
        Me.BooksTableAdapter.Fill(Me.RnrBooksDataSet.Books)

    End Sub

    Private Sub BooksBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BooksBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BooksBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RnrBooksDataSet)

    End Sub

    Private Sub FictionCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FictionCheckBox.CheckedChanged

    End Sub
End Class
