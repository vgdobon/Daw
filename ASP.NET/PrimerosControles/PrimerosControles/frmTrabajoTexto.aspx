<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmTrabajoTexto.aspx.cs" Inherits="PrimerosControles.frmTrabajoTexto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Cuadros de texto y etiquetas</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Label id="Iniciar" runat="server" OnInit="Iniciar_Init"></asp:Label> <br />

            <asp:Label ID="Label1" runat="server" Text="Cantidad:"></asp:Label>
            <asp:TextBox ID="txtFrase" runat="server" Width="700px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnMostrar" AccessKey="+" runat="server" Text="Calcular" Height="40px" OnClick="btnCalcular_Click" Width="250px"/>
            <asp:Button ID="btnDiaHora" runat="server" Height="40px" OnClick="btnDiaHora_Click" Text="Dia/Hora" Width="250px" />
            <asp:Button ID="btnTabla" AccessKey="T" runat="server" Height="40px" Text="Tabla de multiplicar" Width="250px" OnClick="btnTabla_Click" />
            <br />
            <br />
            <asp:Label ID="lblSalida" runat="server"></asp:Label>

            <asp:TextBox ID="txtFrase1" runat="server" Width="700px" TextMode="DateTimeLocal"></asp:TextBox>
            <br />

        </div>
    </form>
</body>
</html>
