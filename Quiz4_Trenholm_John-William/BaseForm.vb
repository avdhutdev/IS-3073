'Project:       Chapter 12 Case Studies: Very Very Boards
'Programmer:    Theresa Berry
'Date:          August 2008
'Description:   Use option buttons and check boxes to determine the
'               items in a customer order.  Validate and calculate
'               totals for this customer and display a summary for
'               all customers.
'Folder:        EX12Boards

Option Strict On

Public Class BaseForm

    Public Overridable Sub OkButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OkButton.Click
        'Allow inherited classes to override this method.

        Me.Close()
    End Sub
End Class