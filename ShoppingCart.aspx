<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="StateManagementDemo.ShoppingCart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-top: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            My Shopping Cart:<br />
            <br />
            <br />
            <asp:ListBox ID="ListBox1" runat="server" Height="153px" Width="210px"></asp:ListBox>
            <asp:ListBox ID="ListBox2" runat="server" CssClass="auto-style1" Height="147px" Width="179px"></asp:ListBox>
        </div>
    </form>
</body>
</html>
