<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 340px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblSupplierID" runat="server" style="z-index: 1; left: 32px; top: 35px; position: absolute; margin-bottom: 0px" Text="Supplier ID" width="135px"></asp:Label>
        <asp:TextBox ID="txtSupplierID" runat="server" style="z-index: 1; top: 35px; position: absolute; left: 192px; width: 200px;"></asp:TextBox>
        <p>
            <asp:Label ID="lblSupplierName" runat="server" style="z-index: 1; left: 32px; top: 62px; position: absolute" Text="Supplier Name" width="135px"></asp:Label>
        </p>
        <asp:TextBox ID="txtSupplierName" runat="server" style="z-index: 1; top: 62px; position: absolute; left: 192px" width="200px"></asp:TextBox>
        <p>
            <asp:Label ID="lblContactPerson" runat="server" style="z-index: 1; left: 31px; top: 91px; position: absolute" Text="Contact Person" width="135px"></asp:Label>
            <asp:Label ID="lblSupplierEmail" runat="server" style="z-index: 1; left: 32px; top: 120px; position: absolute" Text="Supplier Email" width="135px"></asp:Label>
        </p>
        <asp:Label ID="lblSupplierTelephone" runat="server" style="z-index: 1; left: 32px; top: 148px; position: absolute" Text="Supplier Telephone" width="135px"></asp:Label>
        <asp:TextBox ID="txtSupplierEmail" runat="server" style="z-index: 1; left: 192px; top: 121px; position: absolute" width="200px"></asp:TextBox>
        <asp:Label ID="lblInitialContractDate" runat="server" style="z-index: 1; left: 32px; top: 174px; position: absolute; width: 135px; bottom: 455px;" Text="Initial Contract Date"></asp:Label>
        <asp:Label ID="lblSupplierActive" runat="server" style="z-index: 1; left: 32px; top: 199px; position: absolute" Text="Supplier Active" width="135px"></asp:Label>
        <asp:TextBox ID="txtContactPerson" runat="server" style="z-index: 1; left: 192px; top: 93px; position: absolute" width="200px"></asp:TextBox>
        <asp:TextBox ID="txtSupplierTelephone" runat="server" style="z-index: 1; left: 192px; top: 149px; position: absolute" width="200px"></asp:TextBox>
        <asp:TextBox ID="txtInitialContactDate" runat="server" style="z-index: 1; left: 192px; top: 175px; position: absolute" width="200px"></asp:TextBox>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 192px; top: 201px; position: absolute" Text="Active" width="200px" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 32px; top: 226px; position: absolute; bottom: 627px"></asp:Label>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 192px; top: 264px; position: absolute" Text="Cancel" />
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 32px; top: 264px; position: absolute" Text="Ok" width="60px" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 405px; top: 35px; position: absolute" Text="Find" Width="60px" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
