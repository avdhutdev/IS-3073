Public Partial Class confirmation
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        Dim numTickets1 As integer = Request.QueryString["numTickets"].ToString()
        Dim cost As Integer


        priceLabel.Text = numTickets1 * cost




    End Sub

End Class