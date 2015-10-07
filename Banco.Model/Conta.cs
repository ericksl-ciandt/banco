using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Model
{
    class Conta
    {
        public string idConta { get; set; }
        public decimal Saldo { get; set; }
        public string idCartao { get; set; }
        public string idCPF { get; set; }
    }
}
