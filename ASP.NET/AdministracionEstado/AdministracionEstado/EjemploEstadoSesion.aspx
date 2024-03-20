<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EjemploEstadoSesion.aspx.cs" Inherits="AdministracionEstado.EjemploEstadoSesion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Trabajar con el estado de sesión</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblSession" runat="server" Width="470"
                Font-Size="Medium" Font-Names="Verdana" Font-Bold="true" />

            <br />
            <div style="border: 2px groove; width: 57px; height: 160px; background-color: burlywood">
                <table>
                    <tr>
                        <td style="padding:10px">
                            <asp:ListBox ID="ListItems" runat="server" Width="150px" Height="100px" />
                        </td>
                        <td>
                            <asp:Button ID="btnSaveInfo" runat="server" Text="Guardar en sesión" OnClick="btnSaveInfo_Click"/>
                            <br/> <br/>
                            <asp:Label runat="server" Font-Names="Verdana" Font-Bold="true" ID="lblMuebleInfo"/>
                        </td>
                    </tr>
                </table>

            </div>
        </div>
    </form>
</body>
</html>
