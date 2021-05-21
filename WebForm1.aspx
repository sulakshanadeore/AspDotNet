<%@ Page Language="C#" AutoEventWireup="true" Trace="true"  CodeBehind="WebForm1.aspx.cs" Inherits="FirstApp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .c1 {
            background-color:red;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label>Enter Name
            </label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label1" CssClass="c1" runat="server" Text="Enter Age">

            </asp:Label>
        &nbsp;<asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
            <br />
            Select city:
            <asp:DropDownList ID="DropDownList2" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                <asp:ListItem Value="Pls select valid categoryid ">-----Select Category ID-----</asp:ListItem>
                <asp:ListItem Value="1">Beverages</asp:ListItem>
                <asp:ListItem Value="2">Snacks</asp:ListItem>
                <asp:ListItem Value="3">Lunch</asp:ListItem>
                <asp:ListItem Value="4">HighTea</asp:ListItem>
                <asp:ListItem Value="5">Misc</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            Select Item :
            <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged">
            </asp:DropDownList>
            <br />
            <br />
            <asp:ListBox ID="ListBox1" runat="server" Width="172px"></asp:ListBox>
            <br />
            <br />
           <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
            <asp:Button ID="Button3" runat="server" Text="Button" />
            <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click" />
        </div>
    </form>
</body>
</html>
