<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblComicID" runat="server" style="z-index: 1; left: 23px; top: 25px; position: absolute" Text="ComicID" height="19px" width="150px"></asp:Label>
        <asp:TextBox ID="txtComicID" runat="server" style="z-index: 1; position: absolute; left: 205px; top: 25px;"></asp:TextBox>
        <asp:Label ID="lblComicName" runat="server" style="z-index: 1; left: 23px; top: 55px; position: absolute" Text="Comic Name" height="19px" width="150px"></asp:Label>
        <asp:TextBox ID="txtComicName" runat="server" style="z-index: 1; top: 55px; position: absolute; left: 205px"></asp:TextBox>
        <asp:Label ID="lblComicInitialReleaseDate" runat="server" style="z-index: 1; left: 23px; top: 85px; position: absolute" Text="Comic initial release date" height="19px"></asp:Label>
        <asp:TextBox ID="txtComicInitialReleaseDate" runat="server" style="z-index: 1; top: 85px; position: absolute; left: 205px"></asp:TextBox>
        <asp:Label ID="lblComicArtist" runat="server" style="z-index: 1; left: 23px; top: 115px; position: absolute" Text="Comic artist" height="19px" width="150px"></asp:Label>
        <asp:TextBox ID="txtComicArtist" runat="server" style="z-index: 1; top: 115px; position: absolute; left: 205px"></asp:TextBox>
        <asp:Label ID="lblComicPrice" runat="server" style="z-index: 1; left: 23px; top: 145px; position: absolute" Text="Comic price" height="19px" width="150px"></asp:Label>

        <asp:TextBox ID="txtComicPrice" runat="server" style="z-index: 1; top: 145px; position: absolute; left: 205px"></asp:TextBox>
        <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 195px; top: 269px; position: absolute" Text="OK" OnClick="btnOK_Click" />

        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 271px; top: 269px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:Label ID="lblComicGenre" runat="server" style="z-index: 1; left: 23px; top: 175px; position: absolute" Text="Comic genre" height="19px" width="150px"></asp:Label>
        <asp:TextBox ID="txtComicGenre" runat="server" style="z-index: 1; top: 175px; position: absolute; left: 205px"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 25px; position: absolute; top: 341px"></asp:Label>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 206px; top: 216px; position: absolute" Text="Comic in stock" />
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 441px; top: 37px; position: absolute" Text="Find" />
        <asp:Button ID="btnReturn" runat="server" style="z-index: 1; left: 374px; top: 269px; position: absolute; width: 138px" Text="Return to Main Menu" OnClick="btnReturn_Click" />
    </form>
</body>
</html>
