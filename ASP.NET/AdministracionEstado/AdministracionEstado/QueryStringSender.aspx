<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QueryStringSender.aspx.cs" Inherits="AdministracionEstado.QueryStringSender" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Página que envía la información</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ListBox ID="lstItems" runat="server" 
            Width="170px" Height="155px"></asp:ListBox>
        <br /><br />
        <asp:CheckBox ID="chkDetalles" runat="server"
            Text="Mostrar todos los detalles" />
        <br /><br />
        <asp:Button ID="cmdGo" runat="server" 
            Text="Ver Información" OnClick="cmdGo_Click" />
        <br /><br />
        <asp:Label ID="lblError" runat="server" 
            EnableViewState="false" ></asp:Label>
    </form>
</body>
</html>
