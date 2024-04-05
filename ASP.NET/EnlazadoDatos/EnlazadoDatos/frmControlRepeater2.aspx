<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmControlRepeater2.aspx.cs" Inherits="EnlazadoDatos.frmControlRepeater2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Repeater ID="rptDestinos" runat="server">
                <HeaderTemplate>
                    <h2>Destinos</h2>
                </HeaderTemplate>
                <ItemTemplate>
                    <font face="Comic Sans Ms" size="4" color="blue">
                        <%# Container.DataItem %>
                    </font>
                </ItemTemplate>
                <SeparatorTemplate>
                    <hr width="50%" color="green" />
                </SeparatorTemplate>
                <AlternatingItemTemplate>
                    <font face="Tahoma" size="4" color="red">
                        <%# Container.DataItem %>
                    </font>
                </AlternatingItemTemplate>
                <FooterTemplate>
                    <hr /> <br />
                    <small>
                        <i> <a href="mailto:raguillar@integratecnologia.es">
                            Haz tu reserva aquí
                            </a></i>
                    </small>
                </FooterTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
