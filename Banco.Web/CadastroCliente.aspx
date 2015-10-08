<%@ Page Title="Cadastro" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroCliente.aspx.cs" Inherits="Banco.Web.CadastroCliente" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1><%: Title %>.</h1>
        <h2>Cadastro de Cliente.</h2>
    </hgroup>

   <br> <asp:Label ID="Label1" runat="server" Text="Nome"></asp:Label></br>
    <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
    <br><asp:Label ID="Label4" runat="server" Text="Sobrenome"></asp:Label></br> 
    <asp:TextBox ID="txtSobrenome" runat="server"></asp:TextBox>
    <br><asp:Label ID="Label2" runat="server" Text="CPF"></asp:Label></br>
    <asp:TextBox ID="txtCPF" runat="server"></asp:TextBox>
    <br><asp:Label ID="Label3" runat="server" Text="RG"></asp:Label></br>
    <asp:TextBox ID="txtRG" runat="server"></asp:TextBox>
    <br><asp:Label ID="Label5" runat="server" Text="Idade"></asp:Label></br>
    <asp:TextBox ID="txtIdade" runat="server"></asp:TextBox>
    <br><asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" OnClick="btnCadastrar_Click" /></br>

</asp:Content>