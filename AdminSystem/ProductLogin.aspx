<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductLogin.aspx.cs" Inherits="ProductLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Product Login Page<asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 30px; top: 83px; position: absolute" Text="User Name:"></asp:Label>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 33px; top: 127px; position: absolute" Text="Password:"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 124px; top: 83px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 126px; top: 128px; position: absolute" TextMode="Password"></asp:TextBox>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 192px; top: 206px; position: absolute" Text="Cancel" />
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 85px; top: 205px; position: absolute" Text="Login" />
        <asp:Label ID="lblError" runat="server" ForeColor="#FF3000" style="z-index: 1; left: 350px; top: 116px; position: absolute"></asp:Label>
    </form>
</body>
</html>
