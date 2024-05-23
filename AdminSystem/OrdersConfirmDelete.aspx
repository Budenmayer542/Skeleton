<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 403px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 169px; top: 130px; position: absolute" Text="Are you sure you want to delete this record?"></asp:Label>
        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 311px; top: 188px; position: absolute; width: 70px" Text="No" />
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 194px; top: 189px; position: absolute; width: 74px" Text="Yes" />
    </form>
</body>
</html>
