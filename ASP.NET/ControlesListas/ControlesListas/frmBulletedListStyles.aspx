<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmBulletedListStyles.aspx.cs" Inherits="ControlesListas.frmBulletedListStyles" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <h1>Ejemplo de Bulleted List</h1>
    <form id="form1" runat="server">
        <div>

            <asp:BulletedList ID="BulletedList1" runat="server" BulletStyle="Circle" DisplayMode="HyperLink" OnClick="BulletedList1_Click" OnLoad="BulletedList1_Load" Width="319px">
                <asp:ListItem Text="Marca" Value="http://www.marca.com"></asp:ListItem>
                <asp:ListItem Text="As" Value="http://www.as.com"></asp:ListItem>
                <asp:ListItem Text="El periódico" Value="http://www.elperiodico.com"></asp:ListItem>
            </asp:BulletedList>

            <br />

            <asp:DropDownList ID="DDLStyle" runat="server" OnLoad="DDLStyle_Load" AutoPostBack="True" OnSelectedIndexChanged="DDLStyle_SelectedIndexChanged">
            </asp:DropDownList>

            <asp:DropDownList ID="DDLPrimerElemento" runat="server" OnLoad="DDLPrimerElemento_Load" AutoPostBack="True" OnSelectedIndexChanged="DDLStyle_SelectedIndexChanged">
            </asp:DropDownList>

            <asp:DropDownList ID="DDLDisplayMode" runat="server" OnLoad="DDLDisplayMode_Load" AutoPostBack="True" OnSelectedIndexChanged="DDLStyle_SelectedIndexChanged">
            </asp:DropDownList>

        </div>
    </form>
</body>
</html>
