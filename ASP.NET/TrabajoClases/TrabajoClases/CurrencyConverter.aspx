<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CurrencyConverter.aspx.cs" Inherits="TrabajoClases.CurrencyConverter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style>
        div#miDiv {
            margin: 0 auto;
            width: 600px;
            text-align: center;
            border: thin ridge;
            padding: 20px;
            font-family: Verdana;
            height: 210px;
            width: 530px;
            background-color: #FFFFE8;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="miDiv">
            Convertir:
            <input type="text" runat="server" id="US"/>
            Dolares americanos a Euros.

            <select runat="server" id="Currency">
                
            </select>
            <br />
            <br />
            <input type="submit" value="Convertir"  id="btnConvertir" onserverclick="btnConvertir_ServerClick"
                runat="server"/>
        </div>
    </form>
</body>
</html>
