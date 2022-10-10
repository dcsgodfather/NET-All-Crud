<%@ Page Language="C#" AutoEventWireup="true" CodeFile="userpage.aspx.cs" Inherits="userpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       user page
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><br />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label><br />
        <asp:Button ID="Button1" runat="server" Text="Category" OnClick="Button1_Click" /><br />
        <asp:Button ID="Button2" runat="server" Text="Subcategory" />
    </div>
    </form>
</body>
</html>
