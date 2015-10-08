using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Banco.Model;
using Banco.Business;

namespace Banco.Web
{
    public partial class registroCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Clientes obj = new Clientes();
            obj.cpf = Request.QueryString["cpf"];
            if (!String.IsNullOrEmpty(obj.cpf))
            {
                ClienteBO boCliente = new ClienteBO();
                Clientes ret = boCliente.Buscar(obj);
                if (ret != null)
                {
                    lblCPF.Text = ret.cpf;
                    lblIdade.Text = ret.idade;
                    lblNome.Text = ret.nome;
                    lblSobrenome.Text = ret.sobrenome;
                    lblRG.Text = ret.rg;
                } 
            }

        }
    }
}