using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Banco.Model;
using Banco.Web;
using Banco.Data;
using Banco.Business;


namespace Banco.Web
{
    public partial class CadastroCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            Clientes obj = new Clientes();
            obj.cpf = txtCPF.Text.Trim();
            obj.nome = txtNome.Text.Trim();
            obj.sobrenome = txtSobrenome.Text.Trim();
            obj.rg = txtRG.Text.Trim();
            obj.idade = txtIdade.Text.Trim();
            ClienteBO boClient = new ClienteBO();
            boClient.Inserir(obj);
            
            Response.Redirect("~/MensagemSucesso.aspx", true);            
        }
    }
}