<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body id="btnFind">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblStaffID" runat="server" Text="Staff ID"></asp:Label>
        <asp:TextBox ID="txtStaffID" runat="server" style="margin-left: 13px"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        <p>
            <asp:Label ID="lblFullName" runat="server" Text="Full Name" width="48px"></asp:Label>
            <asp:TextBox ID="txtFullName" runat="server" style="margin-left: 12px" ></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblDateOfBirth" runat="server" Text="Date of Birth" width="48px"></asp:Label>
            <asp:TextBox ID="txtDOB" runat="server" style="margin-left: 15px; margin-top: 0px"></asp:TextBox>
        </p>
        <asp:Label ID="lblSalary" runat="server" Text="Salary" width="48px"></asp:Label>
        <asp:TextBox ID="txtSalary" runat="server" style="margin-left: 22px"></asp:TextBox>
        <p>
            <asp:CheckBox ID="chkManager" runat="server" Text="Manager" />
        </p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" Width="48px" />
            <asp:Button ID="btnCancel" runat="server" style="margin-left: 13px" Text="Cancel" OnClick="btnCancel_Click" />
        </p>
    </form>
</body>
</html>
