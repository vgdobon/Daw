<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmProductos.aspx.cs" Inherits="EnlazadoDatos.frmProductos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <div>
        <h1>Gestión de productos de papelería</h1>
        <form id="form1" runat="server">

            <p>
                Selecciona un producto;
                    <asp:DropDownList ID="ddlProductos" runat="server"
                        AutoPostBack="true" OnSelectedIndexChanged="ddlProductos_SelectedIndexChanged">
                    </asp:DropDownList>
            </p>

            <p>
                Id Producto:

                    <asp:TextBox ID="txtIdProducto" runat="server"></asp:TextBox>
            </p>

            <p>
                Producto:

                    <asp:TextBox ID="txtProducto" runat="server"></asp:TextBox>
            </p>

            <p>
                Categoria:
                    <asp:TextBox ID="txtCategoria" runat="server"></asp:TextBox>
            </p>
            <p>
                Subcategoria:
                     <asp:TextBox ID="txtSubcategoria" runat="server"></asp:TextBox>
            </p>
            <p>
                Precio:
                     <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox>
            </p>
            <p>
                Entrega:
                    <asp:TextBox ID="txtEntrega" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="lblSalida" runat="server"></asp:Label>
            </p>
            <asp:Button ID="btnLimpiar" runat="server" OnClick="btnLimpiar_Click" Text="Limpiar"/>

            <asp:Button ID="btnAgregar" runat="server" OnClick="btnAgregar_Click" Text="Insertar producto" />

            <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" />
            
            <asp:Button ID="btnBorrar" runat="server" Text="Eliminar producto" OnClick="btnBorrar_Click" />
            
            <asp:Button ID="btnInfo" runat="server" Text="Información de la tabla" OnClick="btnInfo_Click"/>
        

            <asp:Label ID="lblInfo" runat="server"></asp:Label>
        </form>
    </div>
</body>
</html>
