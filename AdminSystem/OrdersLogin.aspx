<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersLogin.aspx.cs" Inherits="OrdersLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 615px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblLoginPage" runat="server" style="z-index: 1; left: 15px; top: 39px; position: absolute" Text="Order Login Page"></asp:Label>
        <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 56px; top: 143px; position: absolute" Text="UserName:"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 148px; top: 144px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 57px; top: 197px; position: absolute" Text="Password:"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 149px; top: 197px; position: absolute" TextMode="Password"></asp:TextBox>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 124px; top: 284px; position: absolute" Text="Login" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 197px; top: 284px; position: absolute" Text="Cancel" />
        <asp:Label ID="lblError" runat="server" ForeColor="#FF3300" style="z-index: 1; left: 353px; top: 173px; position: absolute"></asp:Label>
    </form>
</body>
</html>
