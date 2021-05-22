<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ServerSideControlsDemo.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
   
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Do u want to continue?<br />
            <br />
            <br />
            <asp:RadioButton ID="RadioButton2" runat="server" AutoPostBack="True" GroupName="continuestatus" OnCheckedChanged="RadioButton2_CheckedChanged" Text="Yes" />
            <br />
            <asp:RadioButton ID="rdoNo" runat="server" AutoPostBack="True" GroupName="continuestatus" OnCheckedChanged="rdoNo_CheckedChanged" Text="No" />
            <hr />
        </div>
        <asp:TextBox ID="TextBox1" runat="server" AutoCompleteType="Email" AutoPostBack="True"></asp:TextBox>
        <hr />
        <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#3366CC" BorderStyle="Groove" BorderWidth="3px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="200px" NextPrevFormat="FullMonth" OnSelectionChanged="Calendar1_SelectionChanged" Width="220px">
            <DayHeaderStyle BackColor="#FF5050" ForeColor="#336666" Height="1px" />
            <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
            <OtherMonthDayStyle BackColor="Fuchsia" ForeColor="#999999" />
            <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
            <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
            <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
            <WeekendDayStyle BackColor="#CCCCFF" />
        </asp:Calendar>
        <br />
        <asp:TextBox ID="TextBox2" runat="server" Enabled="False"></asp:TextBox>
        <br />
        <hr />
        <br />
        <asp:FileUpload ID="FileUpload1" runat="server" AllowMultiple="True" />
        <asp:Button ID="btnUpload" runat="server" OnClick="btnUpload_Click" Text="Upload" />
    </form>
    <p>
   <%--     <input id="File1" type="file" />
        <input id="Submit1" type="submit" value="submit" /></p>--%>
</body>
</html>
