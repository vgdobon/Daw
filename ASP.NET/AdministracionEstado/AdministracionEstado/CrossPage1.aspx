<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrossPage1.aspx.cs" Inherits="AdministracionEstado.CrossPage1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>CrossPage1 (primer formulario)</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Nombre:
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            <br /><br />
            Apellido:
            <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Button ID="btnEnviar" runat="server" 
                Text="Enviar a otra página"
                PostBackUrl="CrossPage2.aspx" />
            <br /><br />
            <asp:Button ID="btnTransferir" runat="server" 
                Text="Transferencia Manual" Visible="false" />
        </div>
    </form>
</body>
</html>
