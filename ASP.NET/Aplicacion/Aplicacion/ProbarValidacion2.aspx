<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProbarValidacion2.aspx.cs" Inherits="Aplicacion.ProbarValidacion2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <h1>Usar distintas validaciones</h1>
    <form id="form1" runat="server">
        <table bgcolor="gainsboro" cellpadding="10">
            <tr>
                <td colspan="3">
                    <!-- Mostrar mensajes de validación de un campo de texto -->
                    <asp:Label ID="lblMsg" runat="server"
                        Text="Por favor, informe aqui del error"
                        ForeColor="Red" Font-Names="Vivaldi" Font-Size="10"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Libro: 
                </td>
                <td>
                    <!-- Desplegable de libros a seleccionar uno -->
                    <asp:DropDownList runat="server" ID="ddLibros">
                        <asp:ListItem Text="-- Por favor elija un libro --"/>
                        <asp:ListItem Text="Programacion en SQL" />
                        <asp:ListItem Text="Programacion en Java" />
                        <asp:ListItem Text="Programacion en PHP" />
                        <asp:ListItem Text="Programacion en Python" />
                        <asp:ListItem Text="Programacion en Javascript" />
                        <asp:ListItem Text="Programacion en C#" />
                    </asp:DropDownList>
                </td>
                <td>
                    <!-- Validación de selección de un libro -->
                    <asp:RequiredFieldValidator runat="server" ID="rfvLibros"
                        ControlToValidate="ddLibros" Display="static" InitialValue="-- Por favor elija un libro --"
                        ErrorMessage="Por favor, elija un libro"
                        ForeColor="Red" Font-Names="Verdana" Font-Size="10">*</asp:RequiredFieldValidator>

                </td>
            </tr>
            <tr>
                <td>Edición:</td>
                <td>
                    <asp:RadioButtonList runat="server" ID="rblEdicion">
                        <asp:ListItem Text="Primera" />
                        <asp:ListItem Text="Segunda" />
                        <asp:ListItem Text="Tercera" />
                        <asp:ListItem Text="Cuarta" />
                        <asp:ListItem Text="Quinta" />
                    </asp:RadioButtonList>
                </td>
                <td>
                <!-- Validación de selección de una edición -->
                    <asp:RequiredFieldValidator runat="server" ID="rfvEdicion"
                        ControlToValidate="rblEdicion" Display="static"
                        ErrorMessage="Por favor, elija una edición" InitialValue=""
                        ForeColor="Red" Font-Names="Verdana" Font-Size="10">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                   Error:
                </td>
                <td>
                    <!-- Campo de texto para informar del error -->
                    <asp:TextBox runat="server" ID="txtError" TextMode="MultiLine" Rows="3" Columns="30"></asp:TextBox>
                </td>
                <td>
                    <!-- Validación de campo de texto -->
                    <asp:RequiredFieldValidator runat="server" ID="rfvError"
                        ControlToValidate="txtError" Display="Dynamic"
                        ErrorMessage="Por favor, informe del error"
                        SetFocusOnError="true"
                        ForeColor="Red" Font-Names="Verdana" Font-Size="10">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;
                </td>
                <td>
                    <asp:Button ID="cmdEnviar" runat="server"
                    Text="Enviar error" OnClick="cmdEnviar_Click"/>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>Mostrar informe:</td>
                <td>
                    <asp:DropDownList ID="ListFormat" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ListFormat_SelectedIndexChanged">
                        <asp:ListItem Text="List" />
                        <asp:ListItem Selected="true" Text="Bulleted List" />
                        <asp:ListItem Text="Single Paragraph" />
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    Mostrar informe:
                </td>
                <td>
                    <asp:DropDownList ID="lstDisplay" runat="server" AutoPostBack="true" OnSelectedIndexChanged="lstDisplay_SelectedIndexChanged">
                        <asp:ListItem Text="Summary" />
                        <asp:ListItem Selected="true" Text="Msg. Box"/>
                    </asp:DropDownList>
                </td>
                <td>

                </td>
            </tr>
        </table>
        <p>
            <asp:Label ID="lblResultado" runat="server" ForeColor="Red"
                Font-Names="Verdana" Font-Size="10"></asp:Label>
        </p>
        <asp:ValidationSummary runat="server" ID="vsErrores" HeaderText="Errores en la página"
            DisplayMode="BulletList" ForeColor="Red" Font-Names="Verdana" Font-Size="10" 
            ShowSummary="true"/>
    </form>
</body>
</html>
