<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="ServerSideControlsDemo.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="https://www.google.com">Google</asp:HyperLink>
            <asp:ImageButton ID="ImageButton1" runat="server" Height="130px" ImageUrl="~/Myfiles/celebration.jpg" Width="200px" />
            <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/WebForm1.aspx">Insert</asp:LinkButton>
            <br />
            <hr />
            <br />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Select : <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem Value="View1">Personal</asp:ListItem>
                <asp:ListItem Value="View2">Educational</asp:ListItem>
                <asp:ListItem Value="View3">OtherInfo</asp:ListItem>
            </asp:DropDownList>

            <br />

            <asp:MultiView ID="MultiView1" runat="server">
                <asp:View ID="View1" runat="server">

                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    &nbsp;&nbsp;
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    &nbsp;
                    <asp:Button ID="Button1" runat="server" Text="Button" />

                </asp:View>
                <asp:View ID="View2" runat="server">
                    <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                </asp:View>
                <asp:View ID="View3" runat="server">
                    <asp:BulletedList ID="BulletedList1" runat="server">
                        <asp:ListItem>Gold Medal</asp:ListItem>
                        <asp:ListItem>Silver Medal</asp:ListItem>
                        <asp:ListItem>Gold Medal</asp:ListItem>
                    </asp:BulletedList>
                </asp:View>
            </asp:MultiView>
        </div>
    </form>
</body>
</html>
