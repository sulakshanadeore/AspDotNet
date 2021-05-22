<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowEmpInfo.aspx.cs" Inherits="StateManagementDemo.ShowEmpInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <p>
            Enter EmpId:
            <asp:TextBox ID="txtempid" runat="server"></asp:TextBox>
        </p>
        <p>
            Enter EmployeeName:
            <asp:TextBox ID="txtename" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Display Data" />
        </p>
    </form>
    
</body>
</html>
