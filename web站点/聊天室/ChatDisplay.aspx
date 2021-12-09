<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ChatDisplay.aspx.cs" Inherits="ChatDisplay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Refresh" content="text/html; charset=utf-8"/>
    <title>聊天室</title>
    <link rel="stylesheet" href="chat.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblMsg" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
