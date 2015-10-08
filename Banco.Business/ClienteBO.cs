using Banco.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.Data;

namespace Banco.Business
{
   public class ClienteBO
    {

        public void Inserir(Clientes obj)
        {
            ClienteDao dao = new ClienteDao();
            dao.Inserir(obj);
        }
    }
}
