<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" id="StaffPriviliges">
<head runat="server">
    <title></title>
</head>
<body style="height: 429px">
    <form id="form1" runat="server">
        <div style="height: 20px">
            <asp:Label ID="lblStaffId" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute; bottom: 631px;" Text="Staff ID"></asp:Label>
        </div>
       
        <asp:Label ID="lblStaffName" runat="server" style="z-index: 1; left: 15px; top: 96px; position: absolute; width: 74px;" Text="StaffName" height="19px"></asp:Label>
        <asp:TextBox ID="txtStaffRole" runat="server" style="z-index: 1; left: 120px; top: 54px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtStaffName" runat="server" style="z-index: 1; left: 119px; top: 95px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblStaffAddress" runat="server" style="z-index: 1; left: 14px; top: 139px; position: absolute; width: 86px;" Text="StaffAddress" height="19px"></asp:Label>
        <asp:Label ID="lblStaffDOB" runat="server" style="z-index: 1; left: 15px; top: 179px; position: absolute; width: 67px;" Text="StaffDOB" height="19px"></asp:Label>
        <asp:Label ID="lblStaffRole" runat="server" style="z-index: 1; left: 13px; top: 55px; position: absolute; width: 62px" Text="StaffRole" height="19px"></asp:Label>
        <asp:Label ID="lblStaffSalary" runat="server" style="z-index: 1; left: 14px; position: absolute; height: 19px; width: 76px; top: 230px" Text="StaffSalary"></asp:Label>
        <p style="height: 25px">
            <asp:TextBox ID="txtStaffId" runat="server" style="z-index: 1; top: 16px; position: absolute; left: 119px"></asp:TextBox>
            <asp:TextBox ID="txtStaffAddress" runat="server" style="z-index: 1; left: 118px; top: 136px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtStaffDOB" runat="server" style="z-index: 1; left: 116px; top: 177px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtStaffSalary" runat="server" style="z-index: 1; left: 115px; top: 230px; position: absolute"></asp:TextBox>
 
        </p>
        <p style="height: 26px">
        </p>
        <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 31px; top: 358px; position: absolute" Text="lblError"></asp:Label>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 117px; top: 406px; position: absolute" Text="Cancel" />
        <p>
            &nbsp;</p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click1" style="z-index: 1; left: 24px; top: 406px; position: absolute" Text="OK" />
            <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        <asp:CheckBox ID="chkStaffPriviliges" runat="server" Style="z-index: 1; left: 97px; top: 320px; position: absolute" Text="Staff Priviliges" />
    </p>
    </form>
</body>
      


</html>
