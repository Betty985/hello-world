<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SendMessage.aspx.cs" Inherits="SendMesage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>发消息</title>
    <link rel="stylesheet" href="chat.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblName" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:TextBox ID="txtMessage" runat="server" TextMode="MultiLine"></asp:TextBox>
            <br />
            <asp:Button ID="btnSend" runat="server" OnClick="btnSend_Click" Text="发送" />
        </div>
    </form>
</body>
</html>
