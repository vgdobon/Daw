<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PrimerasPruebas.aspx.cs" Inherits="PrimerProyecto.PrimerasPruebas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    </head>
<body>
    <form id="form1" runat="server">
        <div style="height: 129px">
            <asp:Label ID="Label1" runat="server" Text="Número 1:"></asp:Label>
            <asp:TextBox ID="txtNumero1" runat="server" Height="16px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Numero 2:"></asp:Label>
            <asp:TextBox ID="txtNumero2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnCalcular" runat="server" Text="calcular" OnClick="btnCalcular_Click" Width="113px" />
            <br />
            <br />
            <asp:Label ID="lblResultado" runat="server" Text="Resultado:"></asp:Label>
            <br />
            <br />
            <br />
            &nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Frutas" />
            <br />
            <asp:Table ID="Table2" runat="server" Height="218px" Width="543px">
                <asp:TableRow>
                <asp:TableCell>
                    Frutas
                </asp:TableCell>
                <asp:TableCell>
                    Precio
                </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
            <br />
            <br />
        </div>
    </form>
    <p>
        &nbsp;
    </p>
    <p>
        &nbsp;
    </p>
</body>
</html>
