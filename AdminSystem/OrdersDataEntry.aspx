<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 448px;
            width: 479px;
        }
    </style>
</head>
<body style="height: 407px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblOrderNo" runat="server" height="19px" style="z-index: 1; left: 12px; top: 36px; position: absolute" Text="Order No" width="86px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="chkDispatched" runat="server" style="z-index: 1; left: 148px; top: 272px; position: absolute" Text="Dispatched" />
        <asp:TextBox ID="txtDateOfOrder" runat="server" style="z-index: 1; left: 128px; top: 109px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 363px; top: 33px; position: absolute" Text="Find" />
        <br />
        <asp:Label ID="lblItemCount" runat="server" height="19px" style="z-index: 1; left: 12px; top: 67px; position: absolute" Text="Item Count" width="86px"></asp:Label>
        <asp:TextBox ID="txtItemCount" runat="server" style="z-index: 1; left: 128px; top: 68px; position: absolute"></asp:TextBox>
        <p>
            <asp:TextBox ID="txtOrderNo" runat="server" style="z-index: 1; left: 128px; top: 36px; position: absolute"></asp:TextBox>
        </p>
        <asp:Label ID="lblDateOfOrder" runat="server" style="z-index: 1; left: 12px; top: 109px; position: absolute" Text="Date of Order"></asp:Label>
        <p>
            <asp:Label ID="lblSubTotal" runat="server" height="19px" style="z-index: 1; left: 12px; top: 148px; position: absolute" Text="SubTotal" width="86px"></asp:Label>
        </p>
        <asp:Label ID="lblTotal" runat="server" height="19px" style="z-index: 1; left: 12px; top: 184px; position: absolute" Text="Total" width="86px"></asp:Label>
        <asp:TextBox ID="txtSubTotal" runat="server" style="z-index: 1; left: 128px; top: 148px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtTotal" runat="server" style="z-index: 1; left: 128px; top: 184px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtDeliveryNote" runat="server" style="z-index: 1; left: 128px; top: 221px; position: absolute"></asp:TextBox>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 25px; top: 380px; position: absolute"></asp:Label>
            <asp:Label ID="lblDeliveryNote" runat="server" height="19px" style="z-index: 1; left: 12px; top: 220px; position: absolute" Text="Delivery Note" width="86px"></asp:Label>
        </p>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 201px; top: 318px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 141px; top: 318px; position: absolute; height: 26px;" Text="OK" />
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnReturn" runat="server" OnClick="btnReturn_Click" style="z-index: 1; left: 290px; top: 319px; position: absolute" Text="Return to Main Menu" />
        </p>
    </form>
    &nbsp;
</body>
</html>
