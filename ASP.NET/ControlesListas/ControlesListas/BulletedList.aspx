<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BulletedList.aspx.cs" Inherits="ControlesListas.BulletedList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:BulletedList ID="BulletdList" runat="server" DisplayMode="LinkButton" BackColor="#9966FF" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Height="243px" OnLoad="BulletdList_Load" Width="577px" OnClick="BulletdList_Click">
               
            </asp:BulletedList>
        </div>
    </form>
</body>
</html>
