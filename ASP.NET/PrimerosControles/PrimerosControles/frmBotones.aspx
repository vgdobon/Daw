<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmBotones.aspx.cs" Inherits="PrimerosControles.frmBotones" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 312px;
        }
        .auto-style2 {
            width: 544px;
        }
    </style>
</head>
<body>
    <h1>Tipos de Botones</h1>
    <form id="form1" runat="server">
        <div>
            <asp:LinkButton ID="LinkButton1" runat="server" Text="Marca.com" OnClick="LinkButton1_Click"
                Tooltip="Ir a la página de Marca"/><br>
            <asp:ImageButton ID="ImageButton1" runat="server" 
                ImageUrl="Images/Marvel.jpeg" Height="900px" OnClick="ImageButton1_Click" /><br> 

            <br />
            <br />
            <br />
            <table style="width:100%; font-size: 20px; text-align: center;">
                <tr>
                    <td class="auto-style1">
                        <asp:HyperLink ID="HyperLink1" runat="server" ImageUrl="Images/calcots.jpg" Width="332px" Height="194px" ImageHeight="200px"></asp:HyperLink>
                    </td>
                    <td class="auto-style2">
                        <asp:HyperLink ID="HyperLink3" runat="server" ImageUrl="Images/brocoli.jpg" Width="346px" Height="195px" ImageHeight="200px"></asp:HyperLink>
                    </td>
                    <td>
                        <asp:HyperLink ID="HyperLink6" runat="server" ImageUrl="Images/ajosTiernos.jpg" Width="311px" Height="196px" ImageHeight="200px"></asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:HyperLink ID="HyperLink2" runat="server" >Calçots</asp:HyperLink>
                    <td class="auto-style2">
                        <asp:HyperLink ID="HyperLink4" runat="server" >Brócoli</asp:HyperLink>
                    </td>
                    <td>
                        <asp:HyperLink ID="HyperLink5" runat="server">Ajos tiernos</asp:HyperLink>
                    </td>
                </tr>
            </table>
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
