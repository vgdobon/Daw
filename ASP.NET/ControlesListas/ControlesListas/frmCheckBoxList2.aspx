<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmCheckBoxList2.aspx.cs" Inherits="ControlesListas.frmCheckBoxList2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>
                Elige tus lenguajes de programación favoritos:
            </p>
            <asp:CheckBoxList ID="cblLenguajes" runat="server" ></asp:CheckBoxList>
            <asp:Button Text="Mostrar Info" runat="server" ID="btnMostrar" OnClick="BtnMostrar_Click"/>
            <p>
                <asp:Label Text="" runat="server" ID="lblSalida"/>
            </p>
        </div>
    </form>
</body>
</html>
