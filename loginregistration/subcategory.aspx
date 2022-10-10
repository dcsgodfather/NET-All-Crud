<%@ Page Language="C#" AutoEventWireup="true" CodeFile="subcategory.aspx.cs" Inherits="subcategory" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:HiddenField ID="HiddenField1" runat="server" />
    select Category:
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="cname" DataValueField="cid">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:studentregistrationConnectionString %>" SelectCommand="SELECT * FROM [tblcategory]"></asp:SqlDataSource>
        <br />
        <br />
        Enter sub category:
        <asp:TextBox ID="txtsubcat" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btninsert" runat="server" Text="Insert" OnClick="btninsert_Click" />
        <asp:Button ID="btndelete" runat="server" OnClick="btndelete_Click" Text="delete" />
        <asp:Button ID="btnupdate" runat="server" OnClick="btnupdate_Click" Text="update" />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="sid" DataSourceID="SqlDataSource2" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="sid" HeaderText="sid" InsertVisible="False" ReadOnly="True" SortExpression="sid" />
                <asp:BoundField DataField="cname" HeaderText="cname" SortExpression="cname" />
                <asp:BoundField DataField="sname" HeaderText="sname" SortExpression="sname" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:studentregistrationConnectionString %>" SelectCommand="select s.sid,c.cname,s.sname from tblcategory c,tbl_subcat s where c.cid=s.cid"></asp:SqlDataSource>
        <br />
        <br />
    </div>
    </form>
</body>
</html>
