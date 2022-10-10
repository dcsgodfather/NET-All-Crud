<%@ Page Language="C#" AutoEventWireup="true" CodeFile="registration.aspx.cs" Inherits="registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            name:<asp:TextBox ID="txtunm" runat="server"></asp:TextBox>
        </p>
        <p>
            password:<asp:TextBox ID="txtpwd" runat="server" TextMode="Password"></asp:TextBox>
        </p>
        <p>
            gender:<asp:RadioButton ID="RadioButton1" runat="server" Text="Male" GroupName="g1" />
            <asp:RadioButton ID="RadioButton2" runat="server" Text="Female" GroupName="g1"/>
        </p>
        <p>
            email:<asp:TextBox ID="txtemail" runat="server" TextMode="Email"></asp:TextBox>
        </p>
        <p>
            date:<asp:TextBox ID="txtdate" runat="server" TextMode="Date"></asp:TextBox>
        </p>
        <p>
            course:<asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>MCA</asp:ListItem>
                <asp:ListItem>BCA</asp:ListItem>
                <asp:ListItem>BBA</asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>
            <asp:Button ID="btnregistrion" runat="server" OnClick="btnregistrion_Click" Text="Registration" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
