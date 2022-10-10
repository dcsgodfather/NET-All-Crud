<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Login Page<br />

    </div>
        <p>
            Enter email:<asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
        </p>
        <p>
            Enter Password:<asp:TextBox ID="txtpwd" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnlogin" runat="server" OnClick="btnlogin_Click" Text="Login" />
        </p>
        <p>
            &nbsp;</p>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
