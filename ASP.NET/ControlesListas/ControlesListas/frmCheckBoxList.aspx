<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmCheckBoxList.aspx.cs" Inherits="ControlesListas.frmCheckBoxList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <h1>El contorl CheckBoxList</h1>
    <h2>Añadir elemento de forma declarativa</h2>
    <form id="form1" runat="server">
        <div>
            <asp:CheckBoxList ID="CheckBoxList1" runat="server" AutoPostBack="True" CellPadding="10" CellSpacing="5" OnInit="CheckBoxList1_Init" RepeatColumns="2" RepeatDirection="Horizontal">
                <asp:ListItem Text="Elemento 1" Value="1"></asp:ListItem>
                <asp:ListItem Text="Elemento 2" Value="2"></asp:ListItem>
                <asp:ListItem Text="Elemento 3vdfssdf" Value="3"></asp:ListItem>
                <asp:ListItem Text="Elemento 4" Value="4"></asp:ListItem>
                <asp:ListItem Text="Elemento 5" Value="5"></asp:ListItem>
            </asp:CheckBoxList>

            <br />
            <hr />

            <asp:CheckBoxList ID="cbListDeportes" runat="server" AutoPostBack="True" OnInit="cbListDeportes_Init" RepeatColumns="3">
            </asp:CheckBoxList>


            <br />
            <hr />

            <asp:CheckBoxList ID="cbdListFrutas" runat="server" AutoPostBack="True" OnInit="cbdListFrutas_Init" OnSelectedIndexChanged="cbdListFrutas_SelectedIndexChanged" RepeatColumns="3">
            </asp:CheckBoxList>


            <br />
            <br />
            <asp:Label ID="lblSalida" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblFrase" runat="server" Text="Hoy es lunes y mañana es martes 19/02/2024"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnSB" runat="server" OnClick="btnSB_Click" Text="Probar StringBuilder" />


        </div>
    </form>
</body>
</html>
