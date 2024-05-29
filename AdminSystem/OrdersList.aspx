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
        <p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 7px; top: 646px; position: absolute"></asp:Label>
            <asp:Label ID="lblItemCountFilter" runat="server" style="z-index: 1; left: 24px; top: 529px; position: absolute" Text="Enter an Item Count"></asp:Label>
        </p>
        <asp:TextBox ID="txtItemCountFilter" runat="server" style="z-index: 1; left: 172px; top: 529px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 14px; top: 574px; position: absolute" Text="Apply Filter" />
        <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 153px; top: 574px; position: absolute" Text="Clear Filter" />
        <asp:Button ID="btnReturn" runat="server" OnClick="btnReturn_Click" style="z-index: 1; left: 292px; top: 573px; position: absolute" Text="Return to Main Menu" />
    </form>
</body>
</html>
