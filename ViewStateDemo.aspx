<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="StateManagementDemo.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter Name:
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Save" />
        </div>
        <p>
            Show Name:
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Show" />
        </p>
        <p>
            &nbsp;</p>
        <hr />
        <p>
            &nbsp;</p>
        <p>
            Number of hits made to this page
            <asp:Label ID="Label1" runat="server" ForeColor="#66FF33" Text="Label"></asp:Label>
        </p>
        <p>
            <asp:Button ID="Button3" runat="server" Text="Click" />
        </p>
    </form>
</body>
</html>
