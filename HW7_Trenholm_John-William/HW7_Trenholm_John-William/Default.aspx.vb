Partial Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        'compare today's date vs the expiration date.
        Dim result As Integer = DateTime.Compare(ccExpiration.Text, Date.Now)
        Dim awards As String
        If awardShowCheckBox.Checked Then
            awards = True
        Else
            awards = False
        End If

        'Credit card number must be 16 digits long
        If creditCardBox2.Text.Length = 16 Then
            'Allow the user to progress to the confirmation page.
            If result > 0 Then
                confirmLink.NavigateUrl = "confirmation.aspx?numTickets=" & numTicketsBox.Text & "&awardShow=" & awards
                confirmLink.Enabled = True
                statusOutPut.Text = ""
                'Tell the user what went wrong.
            Else
                statusOutPut.Visible = True
                statusOutPut.Text = "Expiration Date is before Today!"
            End If
        Else
            'the user inputed an invalid creditcard number
            statusOutPut.Visible = True
            statusOutPut.Text = "Credit Card number is invalid, Number should be 16 digits. It is currently" & creditCardBox2.Text.Length
        End If
    End Sub
End Class