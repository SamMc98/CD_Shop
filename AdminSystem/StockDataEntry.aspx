<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblStockID" runat="server" Text="Stock Identity"></asp:Label>
        <asp:TextBox ID="txtStockID" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblInStock" runat="server" Text="In Stock" width="220px"></asp:Label>
        <asp:CheckBox ID="chkInStock" runat="server" />
        <br />
        <asp:Label ID="lblAlbumTitle" runat="server" Text="Album Title" width="220px"></asp:Label>
        <asp:TextBox ID="txtAlbumTitle" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="ReleaseDate" runat="server" Text="Release Date" width="220px"></asp:Label>
        <asp:TextBox ID="txtReleaseDate" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblStockQuantity" runat="server" Text="Stock Quantity" width="220px"></asp:Label>
        <asp:TextBox ID="txtStockQuantity" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblPrice" runat="server" Text="Price" width="220px"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
    </form>
</body>
</html>
