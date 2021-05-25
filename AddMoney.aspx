<%@ Page Title="" Language="C#" MasterPageFile="~/MainPage.Master" AutoEventWireup="true" CodeBehind="AddMoney.aspx.cs" Inherits="MasterPagesDemo.AddMoney" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <table style="width: 100%">
    <tr>
        <td class="auto-style2">
            <asp:Label ID="Label1" runat="server" Text="From Account"></asp:Label>
        </td>
        <td class="auto-style2">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label2" runat="server" Text="From Bank"></asp:Label>
        </td>
        <td>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AmazonDBConnectionString %>" SelectCommand="SELECT  concat([BankName],',',[Location]) as BankName FROM [BankDetails]"></asp:SqlDataSource>
            <asp:DropDownList ID="DropDownList3" runat="server" DataSourceID="SqlDataSource1" DataTextField="BankName" DataValueField="BankName">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label3" runat="server" Text="To Account"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label4" runat="server" Text="To Account"></asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource1" DataTextField="BankName" DataValueField="BankName">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>
            <asp:Button ID="Button1" runat="server" Text="Transfer" />
        </td>
    </tr>
</table>



</asp:Content>
