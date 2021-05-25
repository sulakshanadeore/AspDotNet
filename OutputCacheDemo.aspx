<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OutputCacheDemo.aspx.cs" Inherits="CachingDemo.WebForm1" %>
<%@ OutputCache Duration="15" VaryByParam="txtname" Location="Any" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
        <p>
            Enter Name:
            <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </p>
    </form>
</body>
</html>
