<%@ Page Title="Banco Generic" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Banco.Web._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1><%: Title %>.</h1>
                <h2></h2>
            </hgroup>
            <p>
               <a href="http://asp.net" title="Sobre Nós"> Conheça o nosso banco.</a>.
                The page features <mark>videos, tutorials, and samples</mark> to help you get the most from ASP.NET.
                If you have any questions about ASP.NET visit
                <a href="http://forums.asp.net/18.aspx" title="ASP.NET Forum">our forums</a>.
            </p>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h3>Banco Generic:</h3>
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
