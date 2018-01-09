<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Friends.aspx.cs" Inherits="WebClientV2.Friends" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="FriendsGridView" runat="server" Height="107px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="932px" AutoGenerateSelectButton="True" EnableModelValidation="False" ShowFooter="True" ViewStateMode="Enabled">
        </asp:GridView>
        <asp:Button ID="UsersBtn" runat="server" Text="See users" />
        <asp:Button ID="BackBtn" runat="server" Text="Back" />
        <br />
        <br />
    </form>
</body>
</html>
