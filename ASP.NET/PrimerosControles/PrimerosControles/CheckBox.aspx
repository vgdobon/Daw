<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CheckBox.aspx.cs" Inherits="PrimerosControles.CheckBox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 63%;
        }
        .auto-style2 {
            height: 193px;
        }
        .auto-style4 {
            height: 26px;
            width: 165px;
        }
        .auto-style5 {
            width: 165px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style2">
            <asp:Label ID="Label1" runat="server" Text="Hoy es lune y mañana martes"></asp:Label>

            <br />

            <br/>

            <table class="auto-style1">
                <tr>
                    <td style="text-align: left" id="Size12" class="auto-style4"><asp:CheckBox ID="Subrayado" runat="server" AutoPostBack="True" OnCheckedChanged="Subrayado_CheckedChanged" Text="Subrayado" />
                    </td>
                    <td style="text-align: left" id="Size12" class="auto-style4">
                        <asp:RadioButton ID="Size12" runat="server" AutoPostBack="True" GroupName="btnSize" OnCheckedChanged="Size_CheckedChanged" Text="12 pt" />
                    </td>
                </tr>
                <tr>
                    <td style="text-align: left" class="auto-style4">
                        <asp:CheckBox ID="Sobrerayado" runat="server" AutoPostBack="True" OnCheckedChanged="Sobrerayado_CheckedChanged" Text="Sobrerayado" />
                    </td>
                    <td style="text-align: left" class="auto-style4">
                        <asp:RadioButton ID="Size18" runat="server" AutoPostBack="True" GroupName="btnSize" OnCheckedChanged="Size_CheckedChanged" Text="18 pt" />
                    </td>
                </tr>
                <tr>
                    <td style="text-align: left" class="auto-style5">
                        <asp:CheckBox ID="Tachado" runat="server" AutoPostBack="True" OnCheckedChanged="Tachado_CheckedChanged" Text="Tachado" />
                    </td>
                    <td style="text-align: left" class="auto-style5">
                        <asp:RadioButton ID="Size24" runat="server" AutoPostBack="True" GroupName="btnSize" OnCheckedChanged="Size_CheckedChanged" Text="24 pt" />
                    </td>
                </tr>
            </table>

        </div>
        
    </form>
</body>
</html>
