<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="WebClientChooseEm.LogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="EmailLbl" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="EmailTxt" runat="server"></asp:TextBox>
        <div>
            <asp:Label ID="PasswordLbl" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="PasswordTxt" runat="server" TextMode="Password" ></asp:TextBox>
        </div>
        <asp:Button ID="LogInBtn" runat="server" OnClick="LogInBtn_Click" Text="Log In " />
        <asp:Button ID="RegisterBtn" runat="server" OnClick="RegisterBtn_Click" Text="Register" />
    </form>
</body>
</html>
