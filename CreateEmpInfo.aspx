<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateEmpInfo.aspx.cs" Inherits="StateManagementDemo.CreateEmpInfo" %>

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
            Enter EmpId:
            <asp:TextBox ID="txtempid" runat="server"></asp:TextBox>
        </p>
        <p>
            Enter EmployeeName:
            <asp:TextBox ID="txtename" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Accept Data" />
        </p>
    </form>
</body>
</html>
