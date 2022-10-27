<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="lojaonline_prova_cleysonsilva.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="https://cdn.tailwindcss.com"></script>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="login" runat="server" action="autentica.aspx" class="h-screen gradient-form bg-gray-200 flex items-center justify-center lg:justify-start">


        <div class="mx-auto flex flex-col gap-4">
            <% if (Request.QueryString["error"]!= null)
                {%>
           <div class="bg-red-100 rounded-lg py-5 px-6 mb-4 text-base text-red-700 mb-3" role="alert">
                <%=Request.QueryString["error"] %>
            </div>

            <%}%>

            

            <h3 class="font-medium leading-tight text-2xl mt-0 mb-2 text-zync-600">Bem-vindo(a) à loja online!</h3>

            <h4 class="font-medium leading-tight text-1xl mt-0 mb-2 text-zync-600">Insira suas informações:</h4>

            <asp:TextBox ID="username" runat="server" placeholder="Usuário" CssClass="form-control block w-full px-4 py-2 text-xl font-normal text-gray-700 bg-white bg-clip-padding border border-solid border-gray-300 rounded transition ease-in-out m-0 focus:text-gray-700 focus:bg-white focus:border-blue-600 focus:outline-none"></asp:TextBox>
            <asp:TextBox ID="password" runat="server" TextMode="Password" placeholder="Senha" CssClass="form-control block w-full px-4 py-2 text-xl font-normal text-gray-700 bg-white bg-clip-padding border border-solid border-gray-300 rounded transition ease-in-out m-0 focus:text-gray-700 focus:bg-white focus:border-blue-600 focus:outline-none"></asp:TextBox>
            <asp:Button ID="submit" runat="server" Text="Entrar" CssClass="cursor-pointer inline-block px-7 py-3 bg-gray-700 text-white font-medium text-sm leading-snug uppercase rounded shadow-md hover:bg-gray-800 hover:shadow-lg focus:bg-gray-800 focus:shadow-lg focus:outline-none focus:ring-0 active:bg-gray-900 active:shadow-lg transition duration-150 ease-in-out" />
        </div>

    </form>


</body>
</html>
<%--  --%>