<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataSetBinding.aspx.cs" Inherits="DataBindingPrueba.DataSetBinding" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Enlace con un DataSet</title>
</head>
<body>
    <h1>Enlace con un DataSet</h1>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstUsuarios" runat="server"
                Width="200px" Height="200px" ></asp:ListBox>
        </div>
    </form>
</body>
</html>
