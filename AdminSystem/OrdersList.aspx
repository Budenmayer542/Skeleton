<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 123px; top: 472px; position: absolute" Text="Delete" />
            <asp:ListBox ID="lstOrdersList" runat="server" Height="438px" Width="430px" OnSelectedIndexChanged="lstOrdersList_SelectedIndexChanged"></asp:ListBox>
        </div>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 14px; top: 473px; position: absolute" Text="Add" />
        </p>
        <p>
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 67px; top: 473px; position: absolute" Text="Edit" />
        </p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 548px; position: absolute"></asp:Label>
    </form>
</body>
</html>
