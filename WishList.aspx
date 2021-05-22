<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WishList.aspx.cs" Inherits="StateManagementDemo.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            enter the product name :
            <asp:TextBox ID="txtprodname" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" Height="156px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="166px">
                <asp:ListItem Value="5000">Watch</asp:ListItem>
                <asp:ListItem Value="15000">Mobile</asp:ListItem>
                <asp:ListItem Value="40000">Ipad</asp:ListItem>
                <asp:ListItem Value="60000">Laptop</asp:ListItem>
                <asp:ListItem Value="2000">PowerBank</asp:ListItem>
            </asp:ListBox>
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Create List of Itmes" />
        <asp:Button ID="Button2" runat="server" Enabled="False" OnClick="Button2_Click" Text="Add To Cart" />
        <asp:Button ID="Button3" runat="server" Enabled="False" OnClick="Button3_Click" PostBackUrl="~/ShoppingCart.aspx" Text="Show My cart" />
    </form>
</body>
</html>
