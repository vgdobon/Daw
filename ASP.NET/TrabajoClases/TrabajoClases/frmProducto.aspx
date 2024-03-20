<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmProducto.aspx.cs" Inherits="TrabajoClases.frmProducto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Button ID="btnProducto" runat="server" Text="Crear producto" OnClick="btnProducto_Click" ToolTip="Con datos fijos" />
            <br />
            <asp:Label ID="lblProducto" runat="server" Text="Producto"></asp:Label>
            <p>
                ID:
                <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
                <br />
                Nombre:
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                <br />
                Precio:
                <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox>

                <br />
                <br />

                <asp:Button ID="btnCrearProducto" runat="server" Text="Guardar Nuevo producto" OnClick="btnCrearProducto_Click" 
                    Tooltip="Crear producto con TextBox"/>

            </p>
            <p>
                <asp:Label ID="lblNuevoProducto" runat="server"></asp:Label>

            </p>
        </div>
    </form>
</body>
</html>
