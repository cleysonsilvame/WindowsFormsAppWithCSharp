<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IMC.aspx.cs" Inherits="IMC.IMC" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblTitle" runat="server" Text="Calcular IMC de uma pessoa" Font-Size="X-Large"></asp:Label>
        </div>
        <div>
            <asp:Label ID="lblPeso" runat="server" Text="Digite o peso: "></asp:Label>
            <asp:TextBox ID="txtPeso" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblAltura" runat="server" Text="Digite a altura: "></asp:Label>
            <asp:TextBox ID="txtAltura" runat="server"></asp:TextBox>
        </div>

        <div>
            <asp:Button ID="btnCalcular" runat="server" Text="Calcular" />
        </div>
    </form>
</body>
</html>
