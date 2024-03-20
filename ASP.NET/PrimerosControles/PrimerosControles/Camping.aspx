<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Camping.aspx.cs" Inherits="PrimerosControles.Camping" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 278px;
        }

        .auto-style2 {
            width: 300px;
        }

        .auto-style3 {
            width: 302px;
        }

        .auto-style5 {
            width: 351px;
            height: 26px;
        }

        .auto-style6 {
            height: 26px;
        }

        .auto-style7 {
            width: 304px;
        }

        .auto-style8 {
            width: 64%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">

            <asp:Label ID="Label1" runat="server" Text="Camping &quot;La Sombra&quot;"></asp:Label>
            <br />
            <br />
            <table style="width: 100%;">
                <tr>
                    <td>Entrada:</td>
                    <td>Salida:</td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="CalendarEntrada" runat="server" Height="30px" OnTextChanged="Calcular_TextChanged" TextMode="Date" AutoPostBack="True"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="CalendarSalida" runat="server" Height="30px" OnTextChanged="Calcular_TextChanged" TextMode="Date" AutoPostBack="True"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <br />
            
            <p>
                Alojamiento:
            </p>
            <asp:RadioButton ID="RadioBtn" runat="server" GroupName="rdBtnTienda" OnCheckedChanged="Calcular_TextChanged" Text="Tienda Iglu" AutoPostBack="True" Checked="True"></asp:RadioButton>
            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="rdBtnTienda" OnCheckedChanged="Calcular_TextChanged" Text="Tienda Familiar" AutoPostBack="True"></asp:RadioButton>
            <asp:RadioButton ID="RadioButton1" runat="server" GroupName="rdBtnTienda" OnCheckedChanged="Calcular_TextChanged" Text="Bungalow" AutoPostBack="True"></asp:RadioButton>


            <p>
                &nbsp;
            </p>
            <p>
                <table style="width: 100%;">
                    <tr>
                        <td class="auto-style5">Extras:</td>
                        <td class="auto-style6"></td>
                        <td class="auto-style6"></td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:CheckBox ID="CheckBox3" runat="server" OnCheckedChanged="Calcular_TextChanged" Text="Toma de Luz" AutoPostBack="True" />
                        </td>
                        <td class="auto-style2">
                            <asp:CheckBox ID="CheckBox1" runat="server" OnCheckedChanged="Calcular_TextChanged" Text="Agua caliente" AutoPostBack="True" />
                        </td>
                        <td class="auto-style2">
                            <asp:CheckBox ID="CheckBox2" runat="server" OnCheckedChanged="Calcular_TextChanged" Text="Aparcamiento" AutoPostBack="True" />
                        </td>
                    </tr>
                </table>
            </p>
            <p>
                &nbsp;
            </p>
            <p>
                <asp:Label ID="Label2" runat="server" Text="Detalles del pago:"></asp:Label>
            </p>
            <p>
                &nbsp;
            </p>
            <p>
                <table class="auto-style8">
                    <tr>
                        <td class="auto-style7">Coste por alojamiento:</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style2" style="text-align: right">Tipo de Alojamiento</td>
                        <td id="tdTipoAlojamiento" runat="server">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style2" style="text-align: right">Días</td>
                        <td id="tdDias" runat="server">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style2" style="text-align: right">Costo</td>
                        <td id="tdCostoAlojamiento" runat="server">&nbsp;</td>
                    </tr>
                </table>
            </p>
            <p>
                &nbsp;
            </p>
            <p>
                &nbsp;
            </p>
            <table class="auto-style8">
                <tr>
                    <td class="auto-style7">Costes extras:</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2" style="text-align: right">Toma de luz:</td>
                    <td id="tdTomaLuz" runat="server">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2" style="text-align: right">Agua caliente:</td>
                    <td id="tdAguaCaliente" runat="server">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2" style="text-align: right">Aparcamiento:</td>
                    <td id="tdAparcamiento" runat="server">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2" style="text-align: right">Coste extras</td>
                    <td id="tdCosteExtras" runat="server">&nbsp;</td>
                </tr>
            </table>
            <br />
            <br />
            <table class="auto-style8">
                <tr>
                    <td class="auto-style7">Coste total:</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2" style="text-align: right">Coste alojamiento:</td>
                    <td id="tdCosteAlojamientoTotal" runat="server">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2" style="text-align: right">Coste extras</td>
                    <td id="tdCosteExtasTotal" runat="server">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2" style="text-align: right">Total</td>
                    <td id="tdCosteTotal" runat="server">&nbsp;</td>
                </tr>
            </table>
            <br />
            <br />
            <br />
            <br />

        </div>

    </form>
</body>
</html>
