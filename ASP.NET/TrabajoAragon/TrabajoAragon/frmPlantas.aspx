<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmPlantas.aspx.cs" Inherits="TrabajoAragon.frmPlantas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Trabajar con parámetros</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
<h1>Trabajar con parámetros</h1>
            <asp:Label ID="Label1" runat="server" Text="Nombre de la planta: "></asp:Label>
            <asp:TextBox ID="txtPlanta" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
            <br />
            <asp:Label ID="lblResultado" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
