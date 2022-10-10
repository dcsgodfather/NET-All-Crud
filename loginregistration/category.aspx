<%@ Page Language="C#" AutoEventWireup="true" CodeFile="category.aspx.cs" Inherits="category" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" >
    <div>
        <asp:HiddenField ID="HiddenField1" runat="server" />
        <br />
        Enter Category name:<asp:TextBox ID="txtcnm" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btninsert" runat="server" Text="Insert" OnClick="btninsert_Click" />
        <asp:Button ID="btndelete" runat="server" OnClick="btndelete_Click" Text="Delete" />
        <asp:Button ID="btnupdate" runat="server" OnClick="btnUpdate_Click" Text="Update" />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="cid" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="cid" HeaderText="cid" InsertVisible="False" ReadOnly="True" SortExpression="cid" />
                <asp:BoundField DataField="cname" HeaderText="cname" SortExpression="cname" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:studentregistrationConnectionString %>" SelectCommand="SELECT * FROM [tblcategory]"></asp:SqlDataSource>
        <br />
    </div>
    </form>
</body>
</html>
