<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddStudent.aspx.cs" Inherits="Ncu.jsj.Web.AddStudent" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="姓名"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
  <br /> <asp:Label ID="Label2" runat="server" Text="年龄"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
       <br /> <asp:Label ID="Label4" runat="server" Text="性别"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    <br /><asp:Label ID="Label3" runat="server" Text="图片"></asp:Label>
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <br /> <asp:Button ID="Button1" runat="server" Text="添加" 
            onclick="Button1_Click" />
    </div>
    </form>
</body>
</html>
