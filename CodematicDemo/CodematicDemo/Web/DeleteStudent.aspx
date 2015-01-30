<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteStudent.aspx.cs" Inherits="Ncu.jsj.Web.DeleteStudent" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="学号："></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>  </div>
    <asp:Button ID="Button1" runat="server" Text="删除" onclick="Button1_Click" />
    </form>
</body>
</html>
