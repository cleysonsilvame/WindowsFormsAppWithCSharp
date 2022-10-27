<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="lojaonline_prova_cleysonsilva.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="https://cdn.tailwindcss.com"></script>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>

    <style>
    </style>
</head>
<body>
    <form runat="server" class="h-screen gradient-form bg-gray-200 flex items-center justify-center lg:justify-start overflow-auto pt-16">


        <div class="max-h-full mx-auto max-w-lg flex flex-col gap-4">
            <% if (Request.QueryString["error"] != null)
                {%>
            <div class="bg-red-100 rounded-lg py-5 px-6 mb-4 text-base text-red-700 mb-3" role="alert">
                <%=Request.QueryString["error"] %>
            </div>

            <%}%>



            <p class="leading-tight text-xl">Seja bem-vindo(a) <strong><%=Session["nomeusuario"] %> </strong>(<em><%=Session["id"] %></em>) e faça boas compras!</p>
            <p class="leading-tight text-lg">Os produtos que você comprou antes foram:</p>


            <asp:GridView ID="gvProdutosComprados" runat="server" CssClass="[&_tr:first-child]:border-b [&_tr:first-child]:bg-gray-800 [&_th]:text-sm [&_th]:font-medium [&_th]:text-white [&_th]:px-6 [&_th]:py-2 [&_tr]:bg-white [&_tr]:border-b [&_td]:text-sm [&_td]:text-gray-900 [&_td]:px-6 [&_td]:py-2">
            </asp:GridView>

            <div class="pb-16">
                <a href="Listar.aspx" class="inline-block px-6 py-2 bg-gray-700 text-white font-medium text-sm leading-snug uppercase rounded shadow-md hover:bg-gray-800 hover:shadow-lg focus:bg-gray-800 focus:shadow-lg focus:outline-none focus:ring-0 active:bg-gray-900 active:shadow-lg transition duration-150 ease-in-out">Lista geral de produtos
                </a>
                <a href="Sair.aspx" class="inline-block px-6 py-2 bg-gray-700 text-white font-medium text-sm leading-snug uppercase rounded shadow-md hover:bg-gray-800 hover:shadow-lg focus:bg-gray-800 focus:shadow-lg focus:outline-none focus:ring-0 active:bg-gray-900 active:shadow-lg transition duration-150 ease-in-out">Sair
                </a>
            </div>
        </div>

    </form>
</body>
</html>
