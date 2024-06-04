<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstComicList" runat="server" Height="399px" Width="351px"></asp:ListBox>
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 87px; top: 455px; position: absolute" Text="Edit" OnClick="btnEdit_Click" />
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 26px; top: 454px; position: absolute" Text="Add" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 22px; top: 648px; position: absolute; height: 21px"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 148px; top: 456px; position: absolute" Text="Delete" />
        <asp:Label ID="lblSearchMessage" runat="server" style="z-index: 1; left: 33px; top: 505px; position: absolute" Text="Enter a comic name:"></asp:Label>
        <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 66px; top: 547px; position: absolute" Text="Clear filter" />
        <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; top: 548px; position: absolute; left: 218px" Text="Apply filter" />
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 191px; top: 505px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnReturn" runat="server" style="z-index: 1; left: 268px; top: 456px; position: absolute; width: 138px" Text="Return to Main Menu" OnClick="btnReturn_Click" />
    </form>
</body>
</html>
