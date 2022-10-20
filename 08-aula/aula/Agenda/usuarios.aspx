<%@ Page Title="" Language="C#" MasterPageFile="~/Princial.Master" AutoEventWireup="true" CodeBehind="usuarios.aspx.cs" Inherits="Agenda.usuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ListView runat="server" DataSourceID="SqlDataSourceAgenda" DataKeyNames="Id" InsertItemPosition="LastItem">
    <AlternatingItemTemplate>
        <tr style="background-color:#FFF8DC;">
            <td>
                <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Excluir" />
                <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Editar" />
            </td>
            <td>
                <asp:Label ID="IdLabel" runat="server" Text='<%# Eval("Id") %>' />
            </td>
            <td>
                <asp:Label ID="nomeLabel" runat="server" Text='<%# Eval("nome") %>' />
            </td>
            <td>
                <asp:Label ID="emailLabel" runat="server" Text='<%# Eval("email") %>' />
            </td>
            <td>
                <asp:Label ID="telefoneLabel" runat="server" Text='<%# Eval("telefone") %>' />
            </td>
        </tr>
    </AlternatingItemTemplate>
    <EditItemTemplate>
        <tr style="background-color:#008A8C;color: #FFFFFF;">
            <td>
                <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Atualizar" />
                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancelar" />
            </td>
            <td>
                <asp:Label ID="IdLabel1" runat="server" Text='<%# Eval("Id") %>' />
            </td>
            <td>
                <asp:TextBox ID="nomeTextBox" runat="server" Text='<%# Bind("nome") %>' />
            </td>
            <td>
                <asp:TextBox ID="emailTextBox" runat="server" Text='<%# Bind("email") %>' />
            </td>
            <td>
                <asp:TextBox ID="telefoneTextBox" runat="server" Text='<%# Bind("telefone") %>' />
            </td>
        </tr>
    </EditItemTemplate>
    <EmptyDataTemplate>
        <table runat="server" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
            <tr>
                <td>Nenhum dado foi retornado.</td>
            </tr>
        </table>
    </EmptyDataTemplate>
    <InsertItemTemplate>
        <tr style="">
            <td>
                <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Inserir" />
                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Limpar" />
            </td>
            <td>
                <asp:TextBox ID="IdTextBox" runat="server" Text='<%# Bind("Id") %>' />
            </td>
            <td>
                <asp:TextBox ID="nomeTextBox" runat="server" Text='<%# Bind("nome") %>' />
            </td>
            <td>
                <asp:TextBox ID="emailTextBox" runat="server" Text='<%# Bind("email") %>' />
            </td>
            <td>
                <asp:TextBox ID="telefoneTextBox" runat="server" Text='<%# Bind("telefone") %>' />
            </td>
        </tr>
    </InsertItemTemplate>
    <ItemTemplate>
        <tr style="background-color:#DCDCDC;color: #000000;">
            <td>
                <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Excluir" />
                <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Editar" />
            </td>
            <td>
                <asp:Label ID="IdLabel" runat="server" Text='<%# Eval("Id") %>' />
            </td>
            <td>
                <asp:Label ID="nomeLabel" runat="server" Text='<%# Eval("nome") %>' />
            </td>
            <td>
                <asp:Label ID="emailLabel" runat="server" Text='<%# Eval("email") %>' />
            </td>
            <td>
                <asp:Label ID="telefoneLabel" runat="server" Text='<%# Eval("telefone") %>' />
            </td>
        </tr>
    </ItemTemplate>
    <LayoutTemplate>
        <table runat="server">
            <tr runat="server">
                <td runat="server">
                    <table id="itemPlaceholderContainer" runat="server" border="1" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                        <tr runat="server" style="background-color:#DCDCDC;color: #000000;">
                            <th runat="server"></th>
                            <th runat="server">Id</th>
                            <th runat="server">nome</th>
                            <th runat="server">email</th>
                            <th runat="server">telefone</th>
                        </tr>
                        <tr id="itemPlaceholder" runat="server">
                        </tr>
                    </table>
                </td>
            </tr>
            <tr runat="server">
                <td runat="server" style="text-align: center;background-color: #CCCCCC;font-family: Verdana, Arial, Helvetica, sans-serif;color: #000000;">
                    <asp:DataPager ID="DataPager1" runat="server">
                        <Fields>
                            <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowLastPageButton="True" />
                        </Fields>
                    </asp:DataPager>
                </td>
            </tr>
        </table>
    </LayoutTemplate>
    <SelectedItemTemplate>
        <tr style="background-color:#008A8C;font-weight: bold;color: #FFFFFF;">
            <td>
                <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Excluir" />
                <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Editar" />
            </td>
            <td>
                <asp:Label ID="IdLabel" runat="server" Text='<%# Eval("Id") %>' />
            </td>
            <td>
                <asp:Label ID="nomeLabel" runat="server" Text='<%# Eval("nome") %>' />
            </td>
            <td>
                <asp:Label ID="emailLabel" runat="server" Text='<%# Eval("email") %>' />
            </td>
            <td>
                <asp:Label ID="telefoneLabel" runat="server" Text='<%# Eval("telefone") %>' />
            </td>
        </tr>
    </SelectedItemTemplate>
</asp:ListView>
<asp:SqlDataSource ID="SqlDataSourceAgenda" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [contato]" DeleteCommand="DELETE FROM [contato] WHERE [Id] = @Id" InsertCommand="INSERT INTO [contato] ([Id], [nome], [email], [telefone]) VALUES (@Id, @nome, @email, @telefone)" UpdateCommand="UPDATE [contato] SET [nome] = @nome, [email] = @email, [telefone] = @telefone WHERE [Id] = @Id">
    <DeleteParameters>
        <asp:Parameter Name="Id" Type="Int32" />
    </DeleteParameters>
    <InsertParameters>
        <asp:Parameter Name="Id" Type="Int32" />
        <asp:Parameter Name="nome" Type="String" />
        <asp:Parameter Name="email" Type="String" />
        <asp:Parameter Name="telefone" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="nome" Type="String" />
        <asp:Parameter Name="email" Type="String" />
        <asp:Parameter Name="telefone" Type="String" />
        <asp:Parameter Name="Id" Type="Int32" />
    </UpdateParameters>
</asp:SqlDataSource>
</asp:Content>
