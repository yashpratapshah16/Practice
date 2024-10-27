<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Practical5a.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Tree View</h3>
            <asp:TreeView ID="TreeView1" runat="server" DataSourceID="SiteMapDataSource1"></asp:TreeView>
            
            <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />

            <asp:DataList ID="DataList1" runat="server" DataSourceId="SiteMapDataSource1" >
                <ItemTemplate>
                    Title:
                    <asp:Label ID="TitleLabel" runat="server" Text='<%# Eval("Title") %>' />
                    <br />
                    Url:
                    <asp:Label ID="UrlLabel" runat="server" Text='<%# Eval("Url") %>' />
                    <br />
                    <br />
                </ItemTemplate>
            </asp:DataList>
        </div>
    </form>
</body>
</html>
