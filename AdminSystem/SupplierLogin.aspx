<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierLogin.aspx.cs" Inherits="SupplierLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 341px">
        </div>
        <asp:Label ID="lblSupplierLoginPage" runat="server" style="top: 27px; left: 16px; position: absolute; height: 19px; width: 139px" Text="Supplier Login Page"></asp:Label>
        <asp:Label ID="lblUserName" runat="server" style="top: 86px; left: 64px; position: absolute; height: 19px; width: 88px; right: 873px;" Text="UserName:"></asp:Label>
        <asp:Label ID="lblPassword" runat="server" style="top: 116px; left: 64px; position: absolute; height: 19px; width: 79px" Text="Password:"></asp:Label>
        <asp:TextBox ID="txtUsername" runat="server" style="top: 84px; left: 175px; position: absolute; height: 22px; width: 155px"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="top: 119px; left: 175px; position: absolute; height: 22px; width: 155px" TextMode="Password"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="top: 116px; left: 374px; position: absolute; height: 19px; width: 280px" ForeColor="#FF3300"></asp:Label>
        <asp:Button ID="btnLogin" runat="server" style="top: 177px; left: 175px; position: absolute; height: 26px; width: 56px" Text="Login" OnClick="btnLogin_Click" />
        <asp:Button ID="btnCancel" runat="server" style="top: 177px; left: 259px; position: absolute; height: 26px; width: 56px" Text="Cancel" />
    </form>
</body>
</html>
