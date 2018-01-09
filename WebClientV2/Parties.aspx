<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Parties.aspx.cs" Inherits="WebClientV2.Parties" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="PartiesGridView" runat="server" Height="107px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="932px" AutoGenerateSelectButton="True" EnableModelValidation="False" ShowFooter="True" ViewStateMode="Enabled">
        </asp:GridView>
        <asp:Button ID="JoinBtn" runat="server" Text="Join" />
        <asp:Button ID="SeeBtn" runat="server" OnClick="SeeBtn_Click" Text="See" />
        <asp:Button ID="MyPartiesBtn" runat="server" Text="My parties" OnClick="MyPartiesBtn_Click" />
        <asp:Button ID="AvailablePartiesBtn" runat="server" Text="Available Parties" OnClick="AvailablePartiesBtn_Click" />
        <asp:Button ID="BackBtn" runat="server" Text="Back" />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
