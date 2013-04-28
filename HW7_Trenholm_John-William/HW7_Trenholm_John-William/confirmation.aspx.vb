Public Partial Class confirmation
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub form1_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles form1.PreRender
        Dim cost As Decimal
        cost = 15
        Dim numTickets As Integer
        numTickets = Request.QueryString("numTickets")


        priceLabel.Text = numTickets * cost
    End Sub
End Class