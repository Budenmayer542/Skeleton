<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="IblCustomerId" runat="server" Text="Customer ID"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;<asp:TextBox ID="txtCustomerId" runat="server" OnTextChanged="txtCustomerId_TextChanged"></asp:TextBox>
            &nbsp;
            </p>
        <p>
            <asp:Label ID="IblFullName" runat="server" Text="FullName"></asp:Label>
            <asp:TextBox ID="txtFullName" runat="server" OnTextChanged="txtFullName_TextChanged" style="margin-bottom: 1px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="IblEmailAddress" runat="server" Text="EmailAddress"></asp:Label>
            <asp:TextBox ID="txtEmailAddress" runat="server" style="margin-bottom: 0px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="IblPhoneNumber" runat="server" Text="PhoneNumber"></asp:Label>
            <asp:TextBox ID="txtPhoneNumber" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="IblActive" runat="server" Text="Active"></asp:Label>
            <asp:TextBox ID="txtActive" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="IblSignUp" runat="server" Text="SignUp"></asp:Label>
            <asp:TextBox ID="txtSignUp" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="chkActive" runat="server" Text="Active" />
        </p>
        <p>
            <asp:Button ID="btnOk" runat="server" Text="Ok" OnClick="btnOk_Click1" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="txtCancel" runat="server" Text="Cancel" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
    </form>
</body>
</html>
