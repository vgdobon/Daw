<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RetenerInfo.aspx.cs" Inherits="AdministracionEstado.RetenerInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Conservar Información</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="txtValor" runat="server"
            TextMode="MultiLine" Width="450px" Height="160px" >
            Esto es una prueba de conservar la información de la página
        </asp:TextBox>
        <br /><br />
        <asp:Button ID="btnGuardar" runat="server" 
            Text="Guardar Contenidos" OnClick="btnGuardar_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnCargar" runat="server" 
    Text="Cargar Contenidos" OnClick="btnCargar_Click" />
    </form>
</body>
</html>
