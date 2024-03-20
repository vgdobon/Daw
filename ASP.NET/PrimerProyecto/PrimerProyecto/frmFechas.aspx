<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmFechas.aspx.cs" Inherits="PrimerProyecto.frmFechas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Dia"></asp:Label>
        <asp:TextBox ID="txtDia" runat="server"></asp:TextBox>
&nbsp;<asp:Label ID="Label2" runat="server" Text="Mes"></asp:Label>
        <asp:TextBox ID="txtMes" runat="server"></asp:TextBox>
&nbsp;<asp:Label ID="Label3" runat="server" Text="Año"></asp:Label>
        <asp:TextBox ID="txtAno" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnDia" runat="server" OnClick="btnDia_Click" Text="Día de la semana" Width="194px" />
        <br />
        <br />
        Día de la semana:
        <asp:Label ID="lblDiaSalida" runat="server"></asp:Label>
&nbsp;
        <asp:Label ID="Label4" runat="server" Text="Mes"></asp:Label>
&nbsp;<asp:Label ID="lblMesSalida" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label6" runat="server" Text="Año"></asp:Label>
&nbsp;<asp:Label ID="lblAnioSalida" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        Días para Navidad :
        <asp:Label ID="lblNavidad" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
