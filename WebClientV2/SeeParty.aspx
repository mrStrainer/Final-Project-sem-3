﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SeeParty.aspx.cs" Inherits="WebClientV2.SeeParty" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Party</title>
    <style type="text/css">
      #login, #loggedin {
        display: none;
      }
      #dontshow {
          display:none;
      }
      .text-overflow {
        overflow: hidden;
        text-overflow: ellipsis;
        white-space: nowrap;
        width: 500px;
      }
    </style>
</head>
<body>
    <div class="container">
      <div id="login">
        <h1>Spotify login</h1>
        <button id="login-button" class="btn btn-primary">Log in with Spotify</button>
      </div>
      <div id="loggedin">
        <div id="user-profile">
        </div>
        <div id="oauth">
        </div>
      </div>
    </div>
    <form id="form1"  runat="server">
        <asp:HiddenField ID="hfield" runat="server" />
        <div id="dontshow">
            <asp:Button ID="GetListBtn" runat="server" OnClick="GetList" Text="Get playlist" />
        </div>
        
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>

    <script src="http://code.jquery.com/jquery-1.10.1.min.js"></script>
    <script>
        (function () {
            var stateKey = 'spotify_auth_state';
            /**
             * Obtains parameters from the hash of the URL
             * @return Object
             */
            function getHashParams() {
                var hashParams = {};
                var e, r = /([^&;=]+)=?([^&;]*)/g,
                    q = window.location.hash.substring(1);
                while (e = r.exec(q)) {
                    hashParams[e[1]] = decodeURIComponent(e[2]);
                }
                return hashParams;
            }
            /**
             * Generates a random string containing numbers and letters
             * @param  {number} length The length of the string
             * @return {string} The generated string
             */
            function generateRandomString(length) {
                var text = '';
                var possible = 'ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789';
                for (var i = 0; i < length; i++) {
                    text += possible.charAt(Math.floor(Math.random() * possible.length));
                }
                return text;
            };


            var oauthDiv = document.getElementById("oauth");
            var hf = document.getElementById("hfield");
            var params = getHashParams();
            var access_token = params.access_token,
                state = params.state,
                storedState = localStorage.getItem(stateKey);
            if (access_token && (state == null || state !== storedState)) {
                alert('There was an error during the authentication');
            } else {
                localStorage.removeItem(stateKey);
                if (access_token) {
                    $.ajax({
                        url: 'https://api.spotify.com/v1/me',
                        headers: {
                            'Authorization': 'Bearer ' + access_token
                        },
                        success: function (response) {
                            console.log("Success");
                            oauth.innerHTML = "ready";
                            hf.value = access_token;

                            $("#dontshow").show();
                            $('#login').hide();
                            $('#loggedin').show();
                        }
                    });
                } else {
                    console.log("No success");
                    $('#login').show();
                    $('#loggedin').hide();
                }
                document.getElementById('login-button').addEventListener('click', function () {
                    var client_id = 'cfbe22855aaf48518cf3009a0ff87b9e'; // Your client id
                    var redirect_uri = 'http://localhost:54436/SeeParty.aspx'; // Your redirect uri
                    var state = generateRandomString(16);
                    localStorage.setItem(stateKey, state);
                    var scope = 'user-read-private user-read-email';
                    var url = 'https://accounts.spotify.com/authorize';
                    url += '?response_type=token';
                    url += '&client_id=' + encodeURIComponent(client_id);
                    url += '&scope=' + encodeURIComponent(scope);
                    url += '&redirect_uri=' + encodeURIComponent(redirect_uri);
                    url += '&state=' + encodeURIComponent(state);
                    window.location = url;
                }, false);
            }
        })();
    </script>
</body>
</html>
