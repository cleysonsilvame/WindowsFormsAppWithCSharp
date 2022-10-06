<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculadora.aspx.cs" Inherits="Calculadora.Calculadora" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblValor1" runat="server" Text="Digite o primeiro valor:"></asp:Label>
            <br />
            <asp:TextBox ID="txtValor1" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblValor2" runat="server" Text="Digite o segundo valor:"></asp:Label>
            <br />
            <asp:TextBox ID="txtValor2" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:RadioButtonList ID="dblOpcoes" runat="server">
                <asp:ListItem>Somar</asp:ListItem>                
                <asp:ListItem>Subtrair</asp:ListItem>                
                <asp:ListItem>Multiplicar</asp:ListItem>                
                <asp:ListItem>Dividir</asp:ListItem>
            </asp:RadioButtonList>
        </div>
        <div>
            <asp:Button ID="btnCalcular" runat="server" Text="Calcular" OnClick="btnCalcular_Click" />
        </div>
        <div>
            <asp:Label ID="lblResultado" runat="server" Text="Resultado: "></asp:Label>
        </div>
    </form>
</body>
</html>
