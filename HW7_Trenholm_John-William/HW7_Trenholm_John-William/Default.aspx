<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="HW7_Trenholm_John_William._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <asp:Label ID="Label1" runat="server" Text="Number of tickets:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="numTicketsBox" runat="server"></asp:TextBox>
    <asp:RangeValidator ID="RangeValidator1" runat="server" 
        ControlToValidate="numTicketsBox" ErrorMessage="Must be between 1 &amp; 250" 
        MaximumValue="250" MinimumValue="1"></asp:RangeValidator>
    <br />
    <br />
    <asp:Label ID="Label7" runat="server" Text="Shipping Address"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="shippingAddressTicketBox" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="shippingValidator" runat="server" 
        ControlToValidate="shippingAddressTicketBox" 
        ErrorMessage="Must ship tickets somewhere."></asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="Label8" runat="server" Text="ZipCode"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="zipCodeBox" runat="server"></asp:TextBox>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
        ControlToValidate="zipCodeBox" ErrorMessage="ZipCode" 
        ValidationExpression="\d{5}(-\d{4})?"></asp:RegularExpressionValidator>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Credit Card Number"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="creditCardBox1" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label3" runat="server" Text="Verify Credit Card Number"></asp:Label>
&nbsp;&nbsp;
    <asp:TextBox ID="creditCardBox2" runat="server"></asp:TextBox>
    <asp:CompareValidator ID="CompareValidator1" runat="server" 
        ControlToCompare="creditCardBox1" ControlToValidate="creditCardBox2" 
        ErrorMessage="CreditCard Numbers must match"></asp:CompareValidator>
    <br />
    <br />
    <asp:Label ID="Label4" runat="server" Text="Expiration Date:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="ccExpiration" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
        ControlToValidate="ccExpiration" ErrorMessage="MM/YYYY" 
        ValidationExpression="^(1[0-2]|0[1-9]|\d)\/(20\d{2}|19\d{2}|0(?!0)\d|[1-9]\d)$"></asp:RegularExpressionValidator>
    <br />
&nbsp;<asp:Label ID="Label9" runat="server" Text="CreditCard Type"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="CreditCardSelection" runat="server">
        <asp:ListItem>Diners Card</asp:ListItem>
        <asp:ListItem>MasterCard</asp:ListItem>
        <asp:ListItem>Visa</asp:ListItem>
        <asp:ListItem>FEDERAL GOVERNMENT</asp:ListItem>
    </asp:DropDownList>
    <br />
    <asp:Label ID="Label10" runat="server" Text="Attend Award Show"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:CheckBox ID="awardShowCheckBox" runat="server" />
    <br />
    <br />
    <br />
    <div style="margin-left: 120px">
        <asp:Button ID="Button1" runat="server" style="height: 29px" Text="Submit" />
        <br />
    </div>
    <asp:Label ID="statusOutPut" runat="server" Visible="False"></asp:Label>
    <br />
    <br />
    <br />
    <asp:HyperLink ID="confirmLink" runat="server" Enabled="False">Confirm Order</asp:HyperLink>
    <br />
    </form>
</body>
</html>
