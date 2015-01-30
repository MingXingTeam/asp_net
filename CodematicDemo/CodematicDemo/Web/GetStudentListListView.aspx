<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GetStudentListListView.aspx.cs"
    Inherits="Ncu.jsj.Web.GetStudentListListView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ListView ID="ListView1" runat="server" DataKeyNames="id" GroupItemCount="3">
            <EmptyDataTemplate>
                <table runat="server" style="background-color: #FFFFFF; border-collapse: collapse;
                    border-color: #999999; border-style: none; border-width: 1px;">
                    <tr>
                        <td>
                            未返回数据。
                        </td>
                    </tr>
                </table>
            </EmptyDataTemplate>
            <GroupTemplate>
                <tr id="itemPlaceholderContainer" runat="server">
                    <td id="itemPlaceholder" runat="server">
                    </td>
                </tr>
            </GroupTemplate>
            <ItemTemplate>
                <td runat="server" style="background-color: #E0FFFF; color: #333333;">
                    <table>
                        <tr>
                            <td>
                                <img alt="" height="150" width="200" src='<%#"/Images/"+ Eval("pictureurl") %>' />
                            </td>
                            <td>
                            id:
                    <asp:Label ID="idLabel" runat="server" Text='<%# Eval("id") %>' />
                    <br />name:
                    <asp:Label ID="nameLabel" runat="server" Text='<%# Eval("name") %>' />
                    <br />age:
                    <asp:Label ID="ageLabel" runat="server" Text='<%# Eval("age") %>' />
                    <%--<br />sex:
                    <asp:Label ID="sexLabel1" runat="server" Text='<%# Convert.ToBoolean(Eval("sex"))?"男":"女" %>' />
                    --%> 
                    <br />sex:
                    <asp:Label ID="Label1" runat="server" Text='<%# getsex(Eval("sex")) %>' />
                   
                    <br />pictureurl:
                    <asp:Label ID="pictureurlLabel" runat="server" 
                        Text='<%# Eval("pictureurl") %>' />
                    <br />
                                <asp:LinkButton ID="LinkButton1" OnClientClick="return com" CommandArgument='<%# Eval("id") %>' OnCommand="del" runat="server">删除</asp:LinkButton>
                            </td>
                        </tr>
                    </table>
                </td>
            </ItemTemplate>
            <LayoutTemplate>
                <table runat="server" align="center">
                    <tr runat="server">
                        <td runat="server">
                            <table id="groupPlaceholderContainer" runat="server" border="1" style="background-color: #FFFFFF;
                                border-collapse: collapse; border-color: #999999; border-style: none; border-width: 1px;
                                font-family: Verdana, Arial, Helvetica, sans-serif;">
                                <tr id="groupPlaceholder" runat="server">
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr runat="server">
                        <td runat="server" style="text-align: center; background-color: #5D7B9D; font-family: Verdana, Arial, Helvetica, sans-serif;
                            color: #FFFFFF">
                        </td>
                    </tr>
                </table>
            </LayoutTemplate>
        </asp:ListView>
    </div>
    </form>
</body>
</html>
