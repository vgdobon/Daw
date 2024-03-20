<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProbarValidacion.aspx.cs" Inherits="Aplicacion.ProbarValidacion" %>

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
                Nº del 1 al 10:
                <asp:TextBox ID="txtNumero" runat="server" ></asp:TextBox>
                <asp:RangeValidator ID="RangeValidatorNumero" runat="server" 
                    ErrorMessage="Número fuera de rango (de 1 a 10)"
                    ControlToValidate="txtNumero" Type="Integer"
                    MinimumValue="5" MaximumValue="10" EnableClientScript="false" ForeColor="Red"
                    Font-Bold="true"
                        >*</asp:RangeValidator>
                <br />
                <br />

                No validado:
                <asp:TextBox ID="txtNoValidado" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Button ID="btnValidar" runat="server" Text="Enviar" OnClick="btnValidar_Click"
                    CausesValidation="true"/>
                <br />
                <asp:Label ID="lblResultado" runat="server" ForeColor="WhiteSmoke"
                    EnableViewState="false"></asp:Label>

                <asp:Label ID="lblMensaje" runat="server" ForeColor="Tomato"
    EnableViewState="false"></asp:Label>
            </p>

            <p>Hoy es viernes y mañana será sabado</p>
            <asp:ValidationSummary ID="ValidationSummary" runat="server"/>
        </div>
    </form>
</body>
</html>
