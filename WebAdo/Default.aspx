﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebAdo.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click1" />
            
        </div>
            <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="105px" AutoPostBack="True"></asp:DropDownList>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>

    </form>
</body>
</html>
