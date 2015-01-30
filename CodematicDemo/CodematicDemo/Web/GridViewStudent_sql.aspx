<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridViewStudent_sql.aspx.cs" Inherits="Ncu.jsj.Web.GridViewStudent_sql" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1"  runat="server" AutoGenerateColumns="False" 
            CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" 
                    ReadOnly="True" SortExpression="id" />
               
                <asp:TemplateField HeaderText="name" SortExpression="name">
                                  
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("name") %>'></asp:Label>
                         </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="age" HeaderText="age" SortExpression="age" />
                <asp:TemplateField HeaderText="pictureurl" SortExpression="pictureurl">
                    
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("pictureurl") %>'></asp:Label>
                        <asp:Image ID="Image1" ImageUrl='<%# Bind("pictureurl") %>' runat="server" />
                        
                          </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="删除">
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="詳細信息">
                    <ItemTemplate>
                        <asp:LinkButton ID="lk" OnCommand="f" CommandArgument='<%# Eval("id") %>' runat="server">详细信息</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#ff0000" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#820000" />
       
        </asp:GridView> 
        <asp:CheckBox ID="CheckBox2" runat="server" Text="全选" AutoPostBack="True" 
            oncheckedchanged="CheckBox2_CheckedChanged" />
         </div>
    </form>
</body>
</html>
