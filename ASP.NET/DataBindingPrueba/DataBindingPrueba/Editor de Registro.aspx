<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Editor de Registro.aspx.cs" Inherits="DataBindingPrueba.Editor_de_Registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <h1>Editor de registros</h1>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="ddlProductos" runat="server"
                AutoPostBack="true" Width="280px">

            </asp:DropDownList>
        </div>
    </form>
</body>
</html>
