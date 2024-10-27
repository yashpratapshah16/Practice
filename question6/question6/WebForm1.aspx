<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="question6.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:RadioButton ID="RadioButton1" runat="server" GroupName="font" OnCheckedChanged="FontfaceChange" Font-Names="Britannic Bold" Text="Britannic Bold" AutoPostBack="True" />
            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="font" OnCheckedChanged="FontfaceChange" Font-Names="Algerian" Text="Algerian" AutoPostBack="True" />
            <asp:RadioButton ID="RadioButton3" runat="server" GroupName="font" OnCheckedChanged="FontfaceChange" Font-Names="Brush Script MT" Text="Brush Script MT" AutoPostBack="True" />
            <br />
            <br />
            <asp:RadioButton ID="RadioButton4" runat="server" GroupName="fontsize" OnCheckedChanged="FontsizeChange" Text="10" AutoPostBack="True" />
            <asp:RadioButton ID="RadioButton5" runat="server" GroupName="fontsize" OnCheckedChanged="FontsizeChange" Text="20" AutoPostBack="True" />
            <asp:RadioButton ID="RadioButton6" runat="server" GroupName="fontsize" OnCheckedChanged="FontsizeChange" Text="30" AutoPostBack="True" />
            <br />
        <asp:Label ID="Label1" runat="server" Text="Hello world"></asp:Label>
        </div>
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem Value="91">india</asp:ListItem>
            <asp:ListItem Value="101">america</asp:ListItem>
            <asp:ListItem Value="88">london</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </form>
</body>
</html>
