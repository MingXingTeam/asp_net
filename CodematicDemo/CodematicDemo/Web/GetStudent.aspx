<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GetStudent.aspx.cs" Inherits="Ncu.jsj.Web.GetStudent" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="学号："></asp:Label>  
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox> </div>
    <asp:Button ID="Button1" runat="server" Text="查找" onclick="Button1_Click" />
    <br />
    姓名：<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    年龄：<asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
    图片：<asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
    <br /><br />
    <asp:Label ID="Label5" runat="server" Text="修改姓名："></asp:Label>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label6" runat="server" Text="修改年龄："></asp:Label>
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    <br /><asp:Label ID="Label7" runat="server" Text="修改图片"></asp:Label>
    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    <asp:Button ID="Button2" runat="server" Text="修改" onclick="Button2_Click" />
    </form>
</body>
</html>
