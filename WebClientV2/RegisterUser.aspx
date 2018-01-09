<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterUser.aspx.cs" Inherits="WebClientV2.RegisterUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="First Name"></asp:Label>
        <asp:TextBox ID="FnameTxt" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Last Name"></asp:Label>
        <asp:TextBox ID="LnameTxt" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Zip"></asp:Label>
        <asp:TextBox ID="ZipTxt" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="EmailTxt" runat="server"></asp:TextBox>
        <br />
        <br />
        <div>
            <asp:Label ID="Label5" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="PasswordTxt" runat="server" EnableViewState="False"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="RegisterBtn" runat="server" OnClick="RegisterBtn_Click" Text="Register" />
            <asp:Button ID="BackBtn" runat="server" OnClick="BackBtn_Click" Text="Back" />
            <br />
        </div>
    </form>
</body>
</html>
