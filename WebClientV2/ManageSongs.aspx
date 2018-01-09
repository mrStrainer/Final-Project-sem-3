<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageSongs.aspx.cs" Inherits="WebClientV2.ManageSongs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel1" runat="server" Height="510px" Width="338px">
                <asp:TextBox ID="SearchSongTxt" runat="server"></asp:TextBox>
                <asp:Button ID="SearchSongBtn" runat="server" Text="Search" />
                <br />
                <br />
                <asp:ListBox ID="ListBox1" runat="server" Height="462px" Width="338px"></asp:ListBox>
                <asp:Panel ID="Panel2" runat="server" Height="222px">
                    <asp:Image ID="Image1" runat="server" Height="168px" Width="129px" />
                    <br />
                    <asp:Button ID="PlaySelectedBtn" runat="server" Text="Play Selected Song" />
                    <asp:Button ID="ResumeBtn" runat="server" Text="Resume" />
                    <asp:Button ID="addBtn" runat="server" Text="Add it!" />
                </asp:Panel>
                <asp:Panel ID="Panel3" runat="server" Height="51px">
                    <asp:Button ID="UpvoteBtn" runat="server" Text="Upvote" />
                    <asp:Button ID="ResetBtn" runat="server" Text="Reset" />
                    <asp:Button ID="DownvoteBtn" runat="server" Text="Downvote" />
                </asp:Panel>
                <asp:Panel ID="Panel4" runat="server" Height="402px">
                    <asp:Button ID="GetSongbtn" runat="server" Text="Button" />
                    <br />
                    <asp:ListBox ID="ListBox2" runat="server" Height="335px" Width="334px"></asp:ListBox>
                    <br />
                    <asp:Button ID="DeleteBtn" runat="server" Text="Delete this song" />
                </asp:Panel>
                <br />
                <br />
                <br />
            </asp:Panel>
        </div>
    </form>
</body>
</html>
