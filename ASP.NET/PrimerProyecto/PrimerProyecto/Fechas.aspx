<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Fechas.aspx.cs" Inherits="PrimerProyecto.Fechas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

    <style>
        #Calendar1 {
            font-size: 10pt;
            font-family: Arial;
            border: 1px solid #cccccc;
            background-color: #f0f0f0;
            display: inline;
            margin-right: 100px;
        }

        #Calendar2 {
            font-size: 10pt;
            font-family: Arial;
            border: 1px solid #cccccc;
            background-color: #f0f0f0;
            display: inline;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManger1" runat="Server">
        </asp:ScriptManager>
        <div style="height: 652px" aria-multiline="True">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Añadir dias" />
            <br />
            <asp:Label ID="lblSalida" runat="server"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Calendar ID="Calendar1" runat="server" Height="260px" Width="263px" CellPadding="4" OnSelectionChanged="Calendar2_SelectionChanged" SelectionMode="DayWeekMonth">
                <SelectedDayStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="2px" Font-Bold="True" Font-Size="Medium" ForeColor="Black" />
                <SelectorStyle CssClass="calendar" />
                <TodayDayStyle BackColor="#66FF66" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" />
            </asp:Calendar>
            <asp:Calendar ID="Calendar2" runat="server" Height="260px"  Width="263px" CellPadding="4" OnSelectionChanged="Calendar2_SelectionChanged">
                <SelectedDayStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="2px" Font-Bold="True" Font-Size="Medium" Font-Underline="False" ForeColor="Black" />
                <SelectorStyle CssClass="calendar" />
            </asp:Calendar>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Calcular diferencia"></asp:Label>
            <br />
            <asp:Button ID="btnDias" runat="server" OnClick="calcular_Click" Text="Días" />
            <asp:Button ID="btnHoras" runat="server" OnClick="calcular_Click" Text="Horas" />
            <asp:Button ID="btnMinutos" runat="server" OnClick="calcular_Click" Text="Minutos" />
            <asp:Button ID="Button2" runat="server" OnClick="calcular_Click" Text="Segundos" />
            <asp:Button ID="Button3" runat="server" OnClick="calcular_Click" Text="Milisegundos" />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Diferencia:"></asp:Label>
            <asp:Label ID="lblSalidaDiferencia" runat="server"></asp:Label>
            <asp:Localize ID="Localize1" runat="server"></asp:Localize>
        </div>
    </form>
</body>
</html>
