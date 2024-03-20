<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmTabla.aspx.cs" Inherits="ControlesListas.frmTabla" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>


            <table>
                <tr>
                    <td>
                        <strong></strong>
                    </td>
                    <td>
                        <asp:CheckBoxList runat="server"
                            ID="cblFontStyle" AutoPostBack="true"
                            CellPadding="5" CellSpacing="10" OnInit="cblFontStyle_Init"
                            RepeatColumns="3">
                        </asp:CheckBoxList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:RadioButtonList ID="rblSize" runat="server"
                            AutoPostBack="true" CellPadding="20" CellSpacing="10"
                            RepeatColumns="3" RepeatDirection="Horizontal"
                            OnInit="rblSize_Init">
                            <asp:ListItem Text="10pt" Value="10"></asp:ListItem>
                            <asp:ListItem Text="12pt" Value="12" Selected="True"></asp:ListItem>
                            <asp:ListItem Text="14pt" Value="14"></asp:ListItem>
                            <asp:ListItem Text="16pt" Value="16"></asp:ListItem>
                            <asp:ListItem Text="18pt" Value="18"></asp:ListItem>
                            <asp:ListItem Text="20pt" Value="20"></asp:ListItem>
                            <asp:ListItem Text="22pt" Value="22"></asp:ListItem>
                            <asp:ListItem Text="24pt" Value="24"></asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
            </table>

            <asp:Table ID="tblFontStyle" runat="server" CellPadding="5" CellSpacing="10"
                Font-Names="Times New Roman" Font-Size="12" BorderWidth="1"
                GridLines="Both" HorizontalAlign="Left" Width="100%" OnInit="tblFontStyle_Init">
                <asp:TableHeaderRow HorizontalAlign="Center">
                    <asp:TableHeaderCell>Font-Family</asp:TableHeaderCell>
                    <asp:TableHeaderCell Width="80%">Textp de ejemplo</asp:TableHeaderCell>
                </asp:TableHeaderRow>
            </asp:Table>
        </div>
    </form>
</body>
</html>
