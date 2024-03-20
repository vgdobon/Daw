<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmProbarExcepcion.aspx.cs" Inherits="ControlesRicos.frmProbarExcepcion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server"
                Text="A: "></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server">5</asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="B:"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server">0</asp:TextBox>
            <br />

            <asp:Button ID="cmdCalcular" runat="server" Text="Dividir A/B" Height="30px" Width="100px" OnClick="cmdCalcular_Click" />
            <br />

            <asp:Label ID="Label3" runat="server" Font-Bold="true" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>
