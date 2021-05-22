<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductReceiver.aspx.cs" Inherits="StateManagementDemo.ProductReceiver" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter ProductID:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            Enter Product Name:
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            Enter Price:
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </div>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Receive" OnClick="Button1_Click" />
        </p>
    </form>
</body>
</html>
