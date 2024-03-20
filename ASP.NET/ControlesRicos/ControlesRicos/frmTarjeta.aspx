<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmTarjeta.aspx.cs" Inherits="ControlesRicos.frmTarjeta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!-- Aqui ponemos los controles que queremos que se muestren en la página -->
            <p>Elige un color de fondo</p>
            <asp:DropDownList ID="lstBackColor" runat="server"
                width="100px" Height="22px"/>
            <br />
            <br />
            Elige una fuente
            <asp:DropDownList ID="lstFontName" runat="server"
            width="100px" Height="22px"/>
            <br />
            <br />
            Especifica el tamaño de la fuente:
            <asp:TextBox ID="txtFontSize" runat="server"
                Width="100px" Height="22px"/>
            <br />
            <br />
            Elige un estilo de borde:
            <asp:RadioButtonList ID="rblBorderStyle" runat="server"
                RepeatDirection="Vertical" Height="60px" />
                <br />
                <br />
            <asp:CheckBox ID="chkPicture" runat="server"
                Text="Añadir la imagen por defecto"/>

            <br />
            <br />
            Entra el texto de saludo:
            <asp:TextBox ID="txtGreeting" runat="server"
                Width="200px" Height="88px" TextMode="MultiLine"/>
            <br />
            <br />

            <asp:Button ID="btnUpdate" runat="server"
                Text="Actualizar tarjeta" OnClick="btnUpdate_Click"
                Width="70px" Height="24px" />

        </div>

        <!-- Aqui viene la tarjeta -->

        <asp:Panel ID="pnlCard" runat="server"
            Width="339px" Height="481px" HorizontalAlign="Center"
            style="position:absolute; top:16px; left:313px">    
            <br />
            <asp:Label ID="lblGreeting" runat="server"
                Width="255px" Height="150px" /> <br /> <br />
            <asp:Image ID="imgDefault" runat="server"
                Width="255px" Height="150px"/>

        </asp:Panel>
    </form>
</body>
</html>
