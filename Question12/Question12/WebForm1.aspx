﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Question12.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
         <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
        <br/>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        <br/>
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <br/>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
