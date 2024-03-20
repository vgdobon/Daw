<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ContadorSencillo.aspx.cs" Inherits="AdministracionEstado.ContadorSencillo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Contador sencillo</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnIncremento" runat="server" 
                Text="Incrementar" OnClick="btnIncremento_Click" ViewStateMode="Enabled" />
            <br /><br />
            <asp:Label ID="lblContar" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
