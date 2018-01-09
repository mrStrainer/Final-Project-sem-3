<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainMenu.aspx.cs" Inherits="WebClientChooseEm.MainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="CreatePartyBtn" runat="server" Text="Create Party" OnClick="CreatePartyBtn_Click" style="z-index: 1; left: 588px; top: 24px; position: absolute" />
        <asp:Button ID="PartiesBtn" runat="server" Text="See parties" OnClick="PartiesBtn_Click" style="z-index: 1; left: 591px; top: 65px; position: absolute; width: 106px" />
        </div>
        <p>
            <asp:Button ID="FriendsBtn" runat="server" Text="Friends" style="z-index: 1; left: 592px; top: 118px; position: absolute; width: 106px" />
        </p>
    </form>
</body>
</html>
