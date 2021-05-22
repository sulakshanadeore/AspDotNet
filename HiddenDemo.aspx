<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HiddenDemo.aspx.cs" Inherits="StateManagementDemo.HiddenDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HiddenField ID="HiddenField1" runat="server" Value="a" />
            <br />
            What is&nbsp; www?</div>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True">
            <asp:ListItem>World Wide </asp:ListItem>
            <asp:ListItem>World</asp:ListItem>
            <asp:ListItem>Wide</asp:ListItem>
            <asp:ListItem Value="a">World Wide Web</asp:ListItem>
        </asp:RadioButtonList>
        <asp:HiddenField ID="HiddenField2" runat="server" Value="c" />
        <br />
        What is full form of Asp?<br />
        <br />
        <asp:RadioButtonList ID="RadioButtonList2" runat="server" AutoPostBack="True">
            <asp:ListItem Value="d">as</asp:ListItem>
            <asp:ListItem Value="b">asp</asp:ListItem>
            <asp:ListItem Value="c">Active Server Pages</asp:ListItem>
            <asp:ListItem Value="a">Inactive Server Pages</asp:ListItem>
        </asp:RadioButtonList>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit " />
        <br />
        <p>
            Marks: <asp:TextBox ID="TextBox1" runat="server" Enabled="False" Visible="False"></asp:TextBox>
        </p>
    </form>
</body>
</html>
