<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hello Application</title>
</head>
<body bgcolor="#33ccff">
    <p>
        Ch09Hello</p>
    <form id="form1" runat="server">
    <div>
    
        <br />
        Enter Name:
        <asp:TextBox ID="NameTextBox" runat="server">Enter Name:</asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="MessageLabel" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Button ID="SubmitButton" runat="server" Text="Submit" />
        <input id="Button1" type="button" value="button" /><br />
    
    </div>
    </form>
</body>
</html>
