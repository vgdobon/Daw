<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmDesconectado.aspx.cs" Inherits="EnlazadoDatos.frmDesconectado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Recuperar autores</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>
                <asp:ListBox ID="lstAutor" runat="server">

                </asp:ListBox>
            </p>
        </div>
    </form>

    <asp:Label ID="lblSalida" ForeColor="Red" runat="server"></asp:Label>
</body>
</html>
