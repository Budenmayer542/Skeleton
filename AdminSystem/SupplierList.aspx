<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 522px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstSupplierList" runat="server" Height="241px" Width="355px"></asp:ListBox>
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" style="top: 298px; left: 190px; position: absolute; height: 26px; width: 51px" />
        <p>
            <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" style="top: 298px; left: 106px; position: absolute; height: 26px; right: 470px" width="51px" />
            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" style="top: 297px; left: 21px; position: absolute; height: 26px; width: 51px; right: 555px; bottom: 351px;" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" Text="" style="top: 459px; left: 21px; position: absolute; height: 19px; width: 56px"></asp:Label>
            <asp:Label ID="lblEnterSupplierName" runat="server" style="top: 357px; left: 21px; position: absolute; height: 19px; width: 153px; right: 801px;" Text="Enter a Supplier Name"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="TxtSupplierNameInput" runat="server" style="top: 352px; position: absolute; height: 19px; width: 128px; left: 190px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="top: 401px; left: 21px; position: absolute; height: 26px; width: 99px" Text="Apply Filter" />
            <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="top: 401px; left: 166px; position: absolute; height: 26px; width: 99px" Text="Clear Filter" />
            <asp:Button ID="Button1" runat="server" Text="Button" />
        </p>
    </form>
</body>
</html>
