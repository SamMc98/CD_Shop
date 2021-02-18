<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblOrderID" runat="server" Text="Order ID"></asp:Label>
            <asp:TextBox ID="txtOrderID" runat="server"></asp:TextBox>
        </div>
        <asp:Label ID="lblShippingAddress" runat="server" Text="Shipping Address" width="87px"></asp:Label>
        <asp:TextBox ID="txtShippingAddress" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblDeliveryDate" runat="server" Text="Delivery Date" width="87px"></asp:Label>
        <asp:TextBox ID="txtDeliveryDate" runat="server" TextMode="DateTime"></asp:TextBox>
        <br />
        <asp:CheckBox ID="ChkOrderPlaced" runat="server" CheckedChanged="ChkOrderPlaced_CheckedChanged" Text="Order Placed" />
        <br />
        <br />
        <br />
        <asp:Label ID="lblOrderLineID" runat="server" Text="OrderLine ID" width="87px"></asp:Label>
        <asp:TextBox ID="txtOrderLineID" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblCheckoutDate" runat="server" Text="Checkout Date" width="87px"></asp:Label>
        <asp:TextBox ID="txtCheckoutDate" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblOrderLineTotal" runat="server" Text="OrderLine Total" width="87px"></asp:Label>
        <asp:TextBox ID="txtOrderLineTotal" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblTotalCost" runat="server" Text="Total Cost" width="87px"></asp:Label>
        <asp:TextBox ID="txtTotalCost" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:CheckBox ID="ChkOrderLineCheckout" runat="server" Text="OrderLine Checkout" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnOk" runat="server" onClick="btnOk_Click" Text="Ok" />
<asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
