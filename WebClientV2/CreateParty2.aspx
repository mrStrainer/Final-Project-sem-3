<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateParty2.aspx.cs" Inherits="WebClientV2.CreateParty2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="assets/css/bootstrap.min.css" rel="stylesheet" />
    <link href="assets/css/github.min.css" rel="stylesheet" />
    <link href="dist/bootstrap-clockpicker.min.css" rel="stylesheet" />
    <script src="assets/js/bootstrap.min.js"></script>
    <script src="assets/js/jquery.min.js"></script>
    <script src="assets/js/highlight.min.js"></script>
    <script src="dist/jquery-clockpicker.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="NameTxt" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Start Date"></asp:Label>
            <asp:Calendar ID="StartDateCalendar" runat="server"></asp:Calendar>

            <br />
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
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="CreateBtn" runat="server" OnClick="CreateBtn_Click" Text="Create Party" />
            <br />
            <br />
            <br />
            <br />
                <div class="form-gropu col-lg-2" >
                    <div class=" input-group clockpicker" data-placement="bottom" data-aignment="left" data-donetext="Done">
                        <input type="text" class=" form-control" value="18:00" />
                           <span class="input-group-addon">
                               <span class="glyphicon glyphicon-time"></span>
                           </span>

                    </div>
                </div>
            </div>
        <script type="text/javascript">
            $('.clockpicker').clockpicker();
        </script>
        
    </form>

</body>
</html>
