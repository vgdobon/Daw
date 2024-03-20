<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DropDownList.aspx.cs" Inherits="ControlesListas.DropDownList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
 
            <asp:DropDownList runat="server" ID="myList" OnSelectedIndexChanged="MyList_SelectedIndexChanged" AutoPostBack="True">

            </asp:DropDownList>
            <br />
            <br />
            <br />
            <asp:Label ID="lblSalida" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
