<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmEventos.aspx.cs" Inherits="ControlesRicos.frmEventos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Seguimiendo de eventos</title>
</head>
<body>
    <h1>Seguimiento de eventos</h1>
    <form id="form1" runat="server">
        <asp:TextBox ID="txtEvento" runat="server" AutoPostBack="True" 
            OnTextChanged="ControlChanged"></asp:TextBox>
        <br />
        <asp:CheckBox ID="chk" runat="server" AutoPostBack="True" 
            OnCheckedChanged="ControlChanged" />
<br />  
        <asp:RadioButton ID="opt1" GroupName="Ejemplo" AutoPostBack="True" Text="text" runat="server" OnCheckedChanged="ControlChanged" />
        <asp:RadioButton ID="opt2" GroupName="Ejemplo" AutoPostBack="True" Text="text" runat="server" OnCheckedChanged="ControlChanged" />

        <h1>Lista de eventos</h1>
        <asp:ListBox ID="lstEventos" runat="server"
            Width="355px" Height="150px">

        </asp:ListBox>
    </form>
</body>
</html>
