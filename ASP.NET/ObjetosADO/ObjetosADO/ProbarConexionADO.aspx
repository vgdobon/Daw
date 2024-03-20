<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProbarConexionADO.aspx.cs" Inherits="ObjetosADO.ProbarConexionADO" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="buttonProbarConection"
runat="server"
                Text="Probar Conexión"
                OnClick="buttonProbarConection_Click" />
            <asp:Label ID="labelResultado" runat="server" ></asp:Label>
        </div>
    </form>
</body>
</html>
