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
        
        <p>
            <asp:ListBox ID="lstComicList" runat="server" Height="399px" Width="351px"></asp:ListBox>
            <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 120px; top: 448px; position: absolute" Text="Edit" OnClick="btnEdit_Click" />
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 26px; top: 447px; position: absolute" Text="Add" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 75px; top: 486px; position: absolute; height: 21px"></asp:Label>
        </p>
    </form>
</body>
</html>
