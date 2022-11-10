<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SistemaLogin.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <asp:Menu ID="Menu1" runat="server">
            <Items>
                <asp:MenuItem NavigateUrl="~/login.aspx" Text="Home" Value="Home"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/Cadastrar.aspx" Text="Cadastrar" Value="Cadastrar"></asp:MenuItem>
            </Items>
        </asp:Menu>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Login: "> 
            </asp:Label>
            <asp:TextBox ID="txtLogin" runat="server" required=""></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Senha:: ">
            </asp:Label><asp:TextBox ID="txtSenha" runat="server" TextMode="Password" required=""></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="btnEntrar" runat="server" Text="Entrar" OnClick="btnEntrar_Click" />           
        </div>
        <div>
             <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
