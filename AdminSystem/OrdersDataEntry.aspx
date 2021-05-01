<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblOrderID" runat="server" Text="Order ID" width="183px"></asp:Label>
            <asp:TextBox ID="txtOrderID" runat="server"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        </div>
        <asp:Label ID="lblShippingAddress" runat="server" Text="Shipping Address" width="183px"></asp:Label>
        <asp:TextBox ID="txtShippingAddress" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblDeliveryDate" runat="server" Text="Delivery Date" width="183px"></asp:Label>
        <asp:TextBox ID="txtDeliveryDate" runat="server" TextMode="DateTime"></asp:TextBox>
        <br />
        <asp:CheckBox ID="ChkOrderPlaced" runat="server" CheckedChanged="ChkOrderPlaced_CheckedChanged" Text="Order Placed" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" Text="Ok" />
&nbsp;<asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
    </form>
</body>
</html>
