<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 208px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblSupplierID" runat="server" style="z-index: 1; left: 32px; top: 35px; position: absolute; margin-bottom: 0px" Text="Supplier ID" width="122px"></asp:Label>
        <asp:TextBox ID="txtSupplierID" runat="server" style="z-index: 1; top: 35px; position: absolute; left: 187px; bottom: 617px"></asp:TextBox>
        <p>
            <asp:Label ID="lblSupplierName" runat="server" style="z-index: 1; left: 32px; top: 62px; position: absolute" Text="Supplier Name" width="122px"></asp:Label>
        </p>
        <asp:TextBox ID="txtSupplierName" runat="server" style="z-index: 1; left: 187px; top: 62px; position: absolute"></asp:TextBox>
        <p>
            <asp:Label ID="lblContactPerson" runat="server" style="z-index: 1; left: 31px; top: 91px; position: absolute" Text="Contact Person" width="122px"></asp:Label>
            <asp:Label ID="lblSupplierEmail" runat="server" style="z-index: 1; left: 32px; top: 120px; position: absolute" Text="Supplier Email" width="122px"></asp:Label>
        </p>
        <asp:Label ID="lblSupplierTelephone" runat="server" style="z-index: 1; left: 32px; top: 148px; position: absolute" Text="Supplier Telephone" width="122px"></asp:Label>
        <asp:TextBox ID="txtSupplierEmail" runat="server" style="z-index: 1; left: 187px; top: 121px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblInitialContractDate" runat="server" style="z-index: 1; left: 32px; top: 174px; position: absolute" Text="Initial Contract Date"></asp:Label>
        <asp:Label ID="lblSupplierActive" runat="server" style="z-index: 1; left: 32px; top: 199px; position: absolute" Text="Supplier Active" width="122px"></asp:Label>
        <asp:TextBox ID="txtContactPerson" runat="server" style="z-index: 1; left: 187px; top: 93px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtSupplierTelephone" runat="server" style="z-index: 1; left: 187px; top: 149px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtInitialContactDate" runat="server" style="z-index: 1; left: 187px; top: 175px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 187px; top: 201px; position: absolute" Text="Active" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 32px; top: 226px; position: absolute; bottom: 627px"></asp:Label>
        <p>
            <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 32px; top: 265px; position: absolute" Text="Ok" width="60px" />
        </p>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 187px; top: 265px; position: absolute; bottom: 383px" Text="Cancel" />
    </form>
</body>
</html>
