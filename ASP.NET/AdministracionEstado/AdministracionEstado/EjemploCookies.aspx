<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EjemploCookies.aspx.cs" Inherits="AdministracionEstado.EjemploCookies" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="backgorund-color:antiquewhite">
            <asp:Label ID="lblSaludo" runat="server"
                EnableViewState="false" />
        </div>
        <br />
        Nombre : <asp:TextBox ID="txtNombre" runat="server"/>
        &nbsp;&nbsp;&nbsp;&nbsp;

        <asp:Button ID="cmdAlmacen" runat="server" Text="Crear Cookie" OnClick="cmdAlmacen_Click" />
    </form>
</body>
</html>
