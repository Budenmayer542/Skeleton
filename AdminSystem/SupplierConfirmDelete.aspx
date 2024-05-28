<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 476px; width: 637px">
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblConfirmDelete" runat="server" style="top: 83px; left: 41px; position: absolute; height: 19px; width: 296px" Text="Are you sure you want to delete this record?"></asp:Label>
        </p>
        <asp:Button ID="btnNo" runat="server" style="top: 128px; left: 190px; position: absolute; height: 26px; width: 88px" Text="No" OnClick="btnNo_Click" />
        <asp:Button ID="btnYes" runat="server" style="top: 128px; left: 59px; position: absolute; height: 26px; width: 88px; margin-bottom: 0px;" Text="Yes" OnClick="btnYes_Click" />
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
