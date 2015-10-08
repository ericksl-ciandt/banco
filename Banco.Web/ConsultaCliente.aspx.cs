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
    public partial class ConsultaCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnConsulta_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/registroCliente.aspx?cpf="+cnsCPF.Text.Trim(), true);    
        }
    }
}