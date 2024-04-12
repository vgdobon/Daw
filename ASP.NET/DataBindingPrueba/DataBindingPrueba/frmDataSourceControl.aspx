<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmDataSourceControl.aspx.cs" Inherits="DataBindingPrueba.frmDataSourceControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:SqlDataSource ID="OleDataSource" runat="server"
                DataSourceMode="DataReader"
                ProviderName="System.Data.OleDb"
                ConnectionString="<%$ ConnectionStrings:Northwind %>"
                SelectCommand="SELECT [Nombre del producto], Id, 
				Categoría FROM Productos"></asp:SqlDataSource>
            <asp:GridView
                ID="gvDataSource"
                runat="server"
                DataSourceID="OleDataSource">
            </asp:GridView>

            <asp:SqlDataSource ID="SqlDataSourceClients" runat="server"
                DataSourceMode="DataReader"
                ProviderName="System.Data.OleDb"
                ConnectionString="<%$ ConnectionStrings:Northwind %>"
                SelectCommand="SELECT Apellidos, Nombre, Id FROM Clientes"></asp:SqlDataSource>
            <asp:ListBox
                ID="gvDataSourceClientes"
                DataTextField="Apellidos"
                runat="server"
                DataSourceID="SqlDataSourceClients"></asp:ListBox>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server"
                DataSourceMode="DataReader"
                ProviderName="System.Data.OleDb"
                ConnectionString="<%$ ConnectionStrings:Northwind %>"
                SelectCommand="SELECT Id de pedido, [Fecha de pedido], [Fecha de envio]
                FROM Pedidos WHERE [Id de Cliente]=@id AND [Fecha de pago] >= @fecha">
                <SelectParameters >
                    <asp:ControlParameter Name="id" ControlId="gvDataSourceClientes" PropertyName="SelectedValue" />
                    <asp:ControlParameter Name="fecha" ControlId="gvDataSourceClientes" DefaultValue="1900/01/01"/>
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:GridView
                ID="GridView1"
                runat="server"
                AutoGenerateColumns="False"
                DataKeyNames="Id de Pedido"
                AutoGenerateEditButton="True"
                DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField HeaderText="Id" DataField="Id de pedido" 
                        InsertVisible="true" SortExpression="Id de pedido"/>
                    <asp:BoundField HeaderText="Fecha de Pedido" DataField="Fecha de pedido"
                        SortExpression="Fecha de pedido" DataFormatString="{0:d}"/>
                    
                    
                    <asp:BoundField HeaderText="Fecha de envio" DataField="Fecha de envio" />
                    
                </Columns>

            </asp:GridView>


        </div>
    </form>
</body>
</html>
