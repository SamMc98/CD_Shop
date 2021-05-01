<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderLineDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:Label ID="lblOrderLineID" runat="server" Text="OrderLine ID" width="189px"></asp:Label>
        <asp:TextBox ID="txtOrderLineID" runat="server"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
            <br />
        <asp:Label ID="lblCheckoutDate" runat="server" Text="Checkout Date" width="189px"></asp:Label>
        <asp:TextBox ID="txtCheckoutDate" runat="server"></asp:TextBox>
            <br />
        <asp:Label ID="lblOrderLineTotal" runat="server" Text="OrderLine Total" width="189px"></asp:Label>
        <asp:TextBox ID="txtOrderLineTotal" runat="server"></asp:TextBox>
            <br />
        <asp:Label ID="lblTotalCost" runat="server" Text="Total Cost" width="189px"></asp:Label>
        <asp:TextBox ID="txtTotalCost" runat="server"></asp:TextBox>
            <br />
        <asp:CheckBox ID="ChkOrderLineCheckout" runat="server" Text="OrderLine Checkout" />
            <br />
            <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
            <br />
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" Text="Ok" />
&nbsp;<asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
        </div>
    </form>
</body>
</html>
