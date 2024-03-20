<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddClientes.aspx.cs" Inherits="ObjetosADO.AddClientes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <h1>Añadir Cliente</h1>
            <asp:Button ID="buttonAddClient" runat="server" Text="Button" OnClick="buttonAddClient_Click" />
            <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
          </div>
    </form>
</body>
</html>
