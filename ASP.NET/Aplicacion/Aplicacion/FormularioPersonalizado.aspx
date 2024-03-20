<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormularioPersonalizado.aspx.cs" Inherits="Aplicacion.FormularioPersonalizado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="border: thin groove; width: 700px; font-family: Verdana; height: 300px;">
            <table style="width: auto; margin: auto">
                <tr>
                    <td>
                        <asp:Label ID="lblUser" runat="server" Text="Nombre de usuario:"
                            Font-Bold="true"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="requiredFieldValidatorUserName" runat="server"
                            ErrorMessage="Debes poner un nombre de usuario"
                            ControlToValidate="txtUserName"></asp:RequiredFieldValidator>

                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblPassword" runat="server" Text="Contraseña:"
                            Font-Bold="true"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="requiredFieldValidatorPassword" runat="server"
                            ErrorMessage="Debes poner una contraseña"
                            ControlToValidate="txtPassword"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblPassword2" runat="server" Text="Repite la contraseña:"
                            Font-Bold="true"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPassword2" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                    <td>
                        <asp:CompareValidator ID="compareValidatorPassword" runat="server"
                            ErrorMessage="Las contraseñas no coinciden"
                            ControlToValidate="txtPassword2"
                            ControlToCompare="txtPassword"></asp:CompareValidator>
                        <asp:RequiredFieldValidator ID="requiredFieldValidatorPassword2" runat="server"
                            ErrorMessage="Debes repetir la contraseña"
                            ControlToValidate="txtPassword2"></asp:RequiredFieldValidator>
                    </td>

                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblEmail" runat="server" Text="Correo electrónico:"
                            Font-Bold="true"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RegularExpressionValidator ID="regularExpressionValidatorEmail" runat="server"
                            ErrorMessage="El correo electrónico no es válido"
                            ControlToValidate="txtEmail"
                            ValidationExpression="^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$"></asp:RegularExpressionValidator>
                        <asp:RequiredFieldValidator ID="requiredFieldValidatorEmail" runat="server"
                            ErrorMessage="Debes poner un correo electrónico"
                            ControlToValidate="txtEmail"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblPhone" runat="server" Text="Teléfono:"
                            Font-Bold="true"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RegularExpressionValidator ID="regularExpressionValidatorPhone" runat="server"
                            ErrorMessage="El teléfono no es válido"
                            ControlToValidate="txtPhone"
                            ValidationExpression="^\d{9}$"></asp:RegularExpressionValidator>
                        <asp:RequiredFieldValidator ID="requiredFieldValidatorPhone" runat="server"
                            ErrorMessage="Debes poner un teléfono"
                            ControlToValidate="txtPhone"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblAge" runat="server" Text="Edad:"
                            Font-Bold="true"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RangeValidator ID="rangeValidatorAge" runat="server"
                            ErrorMessage="La edad debe estar entre 18 y 99"
                            ControlToValidate="txtAge" Type="Integer"
                            MinimumValue="18"
                            MaximumValue="99"></asp:RangeValidator>
                        <asp:RequiredFieldValidator ID="requiredFieldValidatorAge" runat="server"
                            ErrorMessage="Debes poner una edad"
                            ControlToValidate="txtAge"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblSex" runat="server" Text="Código de referencia:"
                            Font-Bold="true"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtCode" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:CustomValidator ID="customValidatorCode" runat="server"
                            ErrorMessage="El código de referencia no es válido"
                            ControlToValidate="txtCode" ValidateEmptyText="false"
                            ClientValidationFunction="MyCustomValidation" OnServerValidate="customValidatorCode_ServerValidate"></asp:CustomValidator>
                    </td>
                </tr>
            </table>

            <br />
            <br />

            <asp:Button ID="btnSubmit" runat="server" Text="Enviar" OnClick="btnSubmit_Click" />
            <asp:Button ID="btnReset" runat="server" Text="Limpiar" OnClick="btnReset_Click" CausesValidation="false"/>

        </div>
        <br />
        <br />
        <asp:Label ID="lblMessage" runat="server" Text=""
            Width="620px"></asp:Label>
    </form>

    <script>
        function MyCustomValidation(sender, args) {

            //Obtener el valor del campo
            var code = args.Value;
            code = code.substring(0, 3);
            if (code%7 ==0) {
                args.IsValid = true;
            }
            else {
                args.IsValid = false;
            }

            //Si el valor no es válido, mostrar el mensaje de error
            if (!args.IsValid) {
                sender.errormessage = "El código de referencia debe tener 8 caracteres";
            }
        }
    </script>
</body>
</html>
