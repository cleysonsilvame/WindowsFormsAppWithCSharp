<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Listar.aspx.cs" Inherits="lojaonline_prova_cleysonsilva.Listar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="https://cdn.tailwindcss.com"></script>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form runat="server" class="h-screen gradient-form bg-gray-200 flex items-center justify-center lg:justify-start pt-16 overflow-auto">


        <div class="max-h-full mx-auto max-w-xl flex flex-col gap-4">
            <% if (Request.QueryString["error"] != null)
                {%>
            <div class="bg-red-100 rounded-lg py-5 px-6 mb-4 text-base text-red-700 mb-3" role="alert">
                <%=Request.QueryString["error"] %>
            </div>

            <%}%>



            <p class="leading-tight text-xl">Lista de produtos</p>


            <asp:GridView ID="gvProdutos" runat="server" CssClass="[&_tr:first-child]:border-b [&_tr:first-child]:bg-gray-800 [&_th]:text-sm [&_th]:font-medium [&_th]:text-white [&_th]:px-6 [&_th]:py-2 [&_tr]:bg-white [&_tr]:border-b [&_td]:text-sm [&_td]:text-gray-900 [&_td]:px-6 [&_td]:py-2">
            </asp:GridView>

            <div class="pb-16">
                <a href="Menu.aspx" class="inline-block px-6 py-2 bg-gray-700 text-white font-medium text-sm leading-snug uppercase rounded shadow-md hover:bg-gray-800 hover:shadow-lg focus:bg-gray-800 focus:shadow-lg focus:outline-none focus:ring-0 active:bg-gray-900 active:shadow-lg transition duration-150 ease-in-out">Voltar
                </a>
            </div>
        </div>

    </form>
</body>
</html>
