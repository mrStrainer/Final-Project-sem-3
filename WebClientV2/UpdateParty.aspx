<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateParty.aspx.cs" Inherits="WebClientV2.UpdateParty" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
*{-webkit-box-sizing:border-box;-moz-box-sizing:border-box;box-sizing:border-box}*{text-shadow:none!important;color:#000!important;background:transparent!important;box-shadow:none!important}</style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="NameTxt" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Start Date"></asp:Label>
            <br />
            <asp:Calendar ID="StartDateCalendar" runat="server"></asp:Calendar>

            <br />
            <asp:Label ID="Label3" runat="server" Text="End Date"></asp:Label>
            <br />
            <asp:Calendar ID="EndDateCalendar" runat="server"></asp:Calendar>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Location "></asp:Label>
            <asp:TextBox ID="LocationTxt" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Privacy"></asp:Label>
            <asp:CheckBox ID="CheckBox" runat="server" Text="YES" />
            <br />
        </div>
    </form>
</body>
</html>
