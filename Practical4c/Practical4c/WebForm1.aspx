<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Practical4c.WebForm1" %>

<%@ Register TagPrefix="uc1" TagName="WebUserControl1" Src="~/WebUserControl1.ascx" %>

<!DOCTYPE html>

<html style="height:100%" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height:100%">
        <div style="height:100%;display:flex;justify-content:center">
            <uc1:WebUserControl1 runat="server" ID="WebUserControl1"  />
        </div>
</body>
</html>
