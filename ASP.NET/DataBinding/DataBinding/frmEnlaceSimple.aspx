<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmEnlaceSimple.aspx.cs" Inherits="frmEnlaceSimple" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblDinamica" runat="server"
                Font-Size="X-Large">
                Hoy ha habido <%# NumT %> transacciones.
                Esta usando <%# Request.Browser.Browser %>
            </asp:Label>

            <br />
            <br />

            Y ahora voy a hacer una operación:

            <%# 1 + 2 * 20 %>
        </div>
    </form>
</body>
</html>
