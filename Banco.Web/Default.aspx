<%@ Page Title="Banco Treinamento" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Banco.Web._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1><%: Title %></h1>
                <h2></h2>
            </hgroup>
            <p>
                 <mark>Site demonstrativo de cadastro e consulta de cliente</mark>
            </p>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h3>Banco Treinamento:</h3>
    <ol class="round">
        <li class="one">
            <h5>Faça sua conta</h5>
           Abra a sua conta rápido e fácil.
            <a href="http://go.microsoft.com/fwlink/?LinkId=245146">Saiba mais.</a>
        </li>
        <li class="two">
            <h5>Vantagens</h5>
            Conheça as vantagens do nosso Banco
            <a href="http://go.microsoft.com/fwlink/?LinkId=245147">Saiba mais.</a>
        </li>
        <li class="three">
            <h5>Agências</h5>
            Encontre a agência mais próxima.
            <a href="http://go.microsoft.com/fwlink/?LinkId=245143">Saiba mais.</a>
        </li>
    </ol>
</asp:Content>
