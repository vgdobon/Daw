<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmVisorLocalidades.aspx.cs" Inherits="TrabajoAragon.frmVisorLocalidades" %>

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
                Seleccione una localidad:
             <asp:DropDownList ID="ddlLocalidades" runat="server" AutoPostBack="True" 
                OnSelectedIndexChanged="ddlLocalidades_SelectedIndexChanged">
</asp:DropDownList>


            </p>

            <br /> <br /> 

            <asp:Label ID="lblLocalidad" runat="server" Text="Label"></asp:Label>
        </div>
    </form>


    <asp:Label ID="lblError" runat="server" Text="Label"></asp:Label>
</body>
</html>
