<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaginaHtmlServidor.aspx.cs" Inherits="TrabajoClases.PaginaHtmlServidor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form runat="server" id="formulario1">
	<p>
        Escribe un texto: <input type="text" name="texto" id="txtFrase" runat="server"/>
    </p>
    <p>
        <input type="button" id="btnMostrar" value="Mostrar" runat="server" onserverclick="btnMostrar_ServerClick" />
    </p>
        <input type="text" runat="server" id="txtSalida" readonly/>

</form>
</body>
</html>
