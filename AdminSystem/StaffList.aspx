<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstStaffList" runat="server" Height="348px" Width="337px"></asp:ListBox>
        </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="Button1_Click" Text="Add" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <asp:Label ID="StaffName" runat="server" Text="Enter a Staff Name"></asp:Label>
        <asp:TextBox ID="filterBox" runat="server"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" Text="Apply" />
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" />
    </form>
</body>
</html>
