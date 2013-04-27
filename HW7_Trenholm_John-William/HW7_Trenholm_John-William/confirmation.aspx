<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="confirmation.aspx.vb" Inherits="HW7_Trenholm_John_William.confirmation" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Thank you for your order<br />
        <br />
        <br />
        <br />
        <asp:Label ID="Label11" runat="server" Text="Price:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="priceLabel" runat="server" Visible="False"></asp:Label>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
