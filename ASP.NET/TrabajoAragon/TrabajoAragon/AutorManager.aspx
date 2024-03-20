<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AutorManager.aspx.cs" Inherits="TrabajoAragon.AutorManager" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="background-color:#FFE0c0; padding:10px;height:100px;width:450px;">
            <asp:Label ID="Label1" runat="server" Text="Selecciona un autor:"></asp:Label>
            <asp:DropDownList ID="ddlAutores" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlAutores_SelectedIndexChanged">
                </asp:DropDownList>
            <br /> <br />

            <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" />
            <asp:Button ID="btnBorrar" runat="server" Text="Eliminar" OnClick="btnBorrar_Click" />
            <asp:Button ID="btnCrearNuevo" runat="server" Text="Crear Nuevo" OnClick="btnCrearNuevo_Click" />
            <asp:Button ID="btnInsertar" runat="server" Text="Insertar" OnClick="btnInsertar_Click" />

        </div>

        <br /> <br />

        <div style="background-color:#E0E0E0; height:400px; width:600px;padding:10px">
            <asp:Label ID="Label2" runat="server" Text="Id Único:"></asp:Label>
            <asp:TextBox ID="txtId" runat="server"></asp:TextBox>

            &nbsp;&nbsp;&nbsp;(se requiere un formato ###-##-####)

<br /> <br />

            <asp:Label ID="Label3" runat="server" Text="Nombre:"></asp:Label>
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>

            <asp:Label ID="Label4" runat="server" Text="Apellido:"></asp:Label>
            <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>

            <br /> <br />

            <asp:Label ID="Label5" runat="server" Text="Teléfono:"></asp:Label>
            <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>

            <br /> <br />

            <asp:Label ID="Label6" runat="server" Text="Dirección:"></asp:Label>
            <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>

            <br /> <br />

            <asp:Label ID="Label7" runat="server" Text="Ciudad:"></asp:Label>
            <asp:TextBox ID="txtCiudad" runat="server"></asp:TextBox>

            <br /> <br />

            <asp:Label ID="Label8" runat="server" Text="Estado:"></asp:Label>
            <asp:TextBox ID="txtEstado" runat="server"></asp:TextBox>

            <br /> <br />

            <asp:Label ID="Label9" runat="server" Text="Código Postal:"></asp:Label>
            <asp:TextBox ID="txtCodigoPostal" runat="server"></asp:TextBox>


            <br /> <br />

            <asp:Label ID="Label11" runat="server" Text="Contrato:"></asp:Label>
            <asp:CheckBox ID="chkActivo" runat="server" Text="Activo" />

            <br /> <br />

            
            

        </div>
    </form>


    <asp:Label ID="lblError" runat="server"  Text=""></asp:Label>
</body>
</html>
