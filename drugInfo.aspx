<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="drugInfo.aspx.cs" Inherits="PHP_Drug_Interaction_UI.drugInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Image ID="ımgDrug" runat="server" />
        <asp:Label ID="drugPrescription" runat="server" Text=""></asp:Label>
        <asp:Button ID="btnAddDrug" runat="server" Text="Add List" OnClick="btnAddDrug_Click" />
        <asp:Button ID="btnClosePopUp" runat="server" Text="Close"  OnClientClick="window.close();"  Width="90px" />
    </div>
    </form>
</body>
</html>
