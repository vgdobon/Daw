<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmControlRepeater.aspx.cs" Inherits="EnlazadoDatos.frmControlRepeater" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <h1>Control Repeater</h1>

    <form id="form1" runat="server">
        <div>
            <asp:Repeater ID="rptLocalidades" runat="server">
                <HeaderTemplate>
                    <table width="80%" style="font: verdana 12px;">
                        <tr bgcolor="#ff00d8">
                            <th>Localidades</th>
                            <th>Comarca</th>
                            <th>Provincia</th>
                            <th>Habitantes</th>
                            <th>Altitud</th>
                        </tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr bgcolor="#ffecd8">
                        <td>
                            <%# DataBinder.Eval(Container.DataItem ,"localidad") %>

                        </td>
                        <td>
                            <%# DataBinder.Eval(Container.DataItem , "comarca") %>
                        </td>
                        <td>
                            <%# DataBinder.Eval(Container.DataItem, "provincia") %>
                        </td>
                        <td align="right">
                            <%# DataBinder.Eval(Container.DataItem, "habitantes") %>
                        </td>
                        <td align="right">
                            <%# DataBinder.Eval(Container.DataItem, "altitud") %>
                        </td>
                    </tr>
                </ItemTemplate>
                <SeparatorTemplate></SeparatorTemplate>
                <AlternatingItemTemplate>
                    <tr bgcolor="#ffec00">
                        <td>
                            <%# DataBinder.Eval(Container.DataItem ,"localidad") %>

                        </td>
                        <td>
                            <%# DataBinder.Eval(Container.DataItem , "comarca") %>
                        </td>
                        <td>
                            <%# DataBinder.Eval(Container.DataItem, "provincia") %>
                        </td>
                        <td align="right">
                            <%# DataBinder.Eval(Container.DataItem, "habitantes") %>
                        </td>
                        <td align="right">
                            <%# DataBinder.Eval(Container.DataItem, "altitud") %>
                        </td>
                    </tr>
                </AlternatingItemTemplate>
                <FooterTemplate></table></FooterTemplate>
                
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
