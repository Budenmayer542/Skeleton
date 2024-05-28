<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 485px">
    <form id="form1" runat="server">
        <asp:Label ID="lblMangaExpressMainMenu" runat="server" style="top: 23px; left: 166px; position: absolute; height: 19px; width: 202px" Text="Manga Express Main Menu"></asp:Label>
        <asp:Button ID="btnCustomer" runat="server" OnClick="btnCustomer_Click" style="top: 78px; left: 23px; position: absolute; height: 27px; width: 84px; right: 836px; margin-bottom: 1px" Text="Customers" />
        <asp:Button ID="btnOrder" runat="server" OnClick="btnOrder_Click" style="top: 78px; left: 116px; position: absolute; height: 27px; width: 84px" Text="Orders" />
        <asp:Button ID="btnStaff" runat="server" OnClick="btnStaff_Click" style="top: 78px; left: 301px; position: absolute; height: 27px; width: 84px; right: 558px" Text="Staff" />
        <asp:Button ID="btnSupplier" runat="server" OnClick="btnSupplier_Click" style="top: 78px; left: 393px; position: absolute; height: 27px; width: 84px" Text="Suppliers" />
        <p>
            <asp:Button ID="btnProduct" runat="server" OnClick="btnProduct_Click" style="top: 78px; position: absolute; height: 27px; width: 84px; left: 209px" Text="Products" />
        </p>
        <div style="height: 664px">
        </div>
    </form>
</body>
</html>
