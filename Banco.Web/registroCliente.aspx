<%@ Page Title="Registro do Cliente" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="registroCliente.aspx.cs" Inherits="Banco.Web.registroCliente" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1><%: Title %></h1>
    </hgroup>
    <h3>
    <asp:Label ID="rgsNome" runat="server" Text="Nome: "></asp:Label>
    <asp:Label ID="lblNome" runat="server" Text=""></asp:Label><br />

    <asp:Label ID="rgsSobrenome" runat="server" Text="Sobrenome: "></asp:Label>
    <asp:Label ID="lblSobrenome" runat="server" Text=" "></asp:Label><br />

    <asp:Label ID="rgsCPF" runat="server" Text="CPF: "></asp:Label>
    <asp:Label ID="lblCPF" runat="server" Text=""></asp:Label><br />

    <asp:Label ID="rgsRG" runat="server" Text="RG: "></asp:Label>
    <asp:Label ID="lblRG" runat="server" Text=""></asp:Label><br />

    <asp:Label ID="rgsIdade" runat="server" Text="Idade: "></asp:Label>
    <asp:Label ID="lblIdade" runat="server" Text=""></asp:Label><br />
        </h3> 
</asp:Content>