<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ChatLogin.aspx.cs" Inherits="ChatLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>登录</title>
    <link rel="stylesheet" href="ChatLogin.css"/>
</head>
<body>
    <div class="box">
        <div class="left"></div>
        <div class="right">
            <form id="form1" runat="server">
        <h1> 我的聊天室</h1>
        <p><strong>用户名: </strong><asp:TextBox ID="txtName" runat="server" CssClass="txt" ></asp:TextBox>
             <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator> </p>
        
         <p><strong> 密&nbsp;&nbsp;码: </strong><asp:TextBox ID="txtPassword" runat="server" CssClass="txt" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ControlToValidate="txtPassword" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator> </p>
        <asp:Button ID="btnLogin" runat="server" Text="登录" OnClick="btnLogin_Click" CssClass="submit"/>
    </form>
        </div>
    </div>
   
</body>
</html>
