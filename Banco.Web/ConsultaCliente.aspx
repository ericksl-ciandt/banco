<%@ Page Title="Consulta" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConsultaCliente.aspx.cs" Inherits="Banco.Web.ConsultaCliente" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1><%: Title %></h1>
    </hgroup>

    <asp:Label ID="Label1" runat="server" Text="CPF"></asp:Label>
    <asp:TextBox ID="cnsCPF" runat="server"></asp:TextBox>
    <asp:Button ID="btnConsulta" runat="server" Text="Consultar" OnClick="btnConsulta_Click" />

</asp:Content>