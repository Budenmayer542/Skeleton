<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstCustomerList" runat="server" Height="440px" Width="1157px"></asp:ListBox>
        </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" Width="128px" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text=" Edit" Width="113px" />
        <p>
            <asp:Button ID="lblError" runat="server" />
        </p>
    </form>
</body>
</html>
