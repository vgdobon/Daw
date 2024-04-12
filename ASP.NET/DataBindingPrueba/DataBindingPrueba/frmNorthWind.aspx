<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmNorthWind.aspx.cs" Inherits="DataBindingPrueba.frmNorthWind" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 147px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="ddlProductos" runat="server"
                AutoPostBack="true" Width="200px" OnSelectedIndexChanged="ddlProductos_SelectedIndexChanged"></asp:DropDownList>

            <br /><br /><hr />

            <table>
                <tr>
                    <td style="width:auto" valign="top">
                        <asp:Label ID="lblRecordInfo" runat="server" />
                    </td>
                    <td class="auto-style1">
                        <asp:Panel ID="pnlCategoria" runat="server" Visible="false" Height="188px" Width="154px">
                            <asp:ListBox ID="lstCategoria" runat="server"
                                Width="150px" Height="140px"></asp:ListBox>
                            <asp:Button ID="cmdUpdate" runat="server" Text="Actualizar" Height="44px" OnClick="cmdUpdate_Click" Width="155px" />
                        </asp:Panel>
                    </td>
                </tr>
            </table>

            <asp:Label Text="" ID="lblSalida" runat="server" />
        </div>
    </form>
</body>
</html>
