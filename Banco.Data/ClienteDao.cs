using Banco.Model;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.Data.Interfaces;

namespace Banco.Data
{
    public class ClienteDao : IData<Clientes>
    {
        public void Inserir(Clientes obj)
        {
            Database db = new DatabaseProviderFactory().Create("database");
            String sql = "INSERT INTO TableCliente (idCPF,Nome, Sobrenome, Rg, Idade)";
            sql += "Values(@idCPF, @Nome, @Sobrenome, @Rg,@Idade)";

            using (DbCommand cmd = db.GetSqlStringCommand(sql))
            {
                db.AddInParameter(cmd, "idCPF",System.Data.DbType.String, obj.cpf);
                db.AddInParameter(cmd, "Nome", System.Data.DbType.String, obj.nome);
                db.AddInParameter(cmd, "Sobrenome", System.Data.DbType.String, obj.sobrenome);
                db.AddInParameter(cmd, "Rg",System.Data.DbType.String, obj.rg);
                db.AddInParameter(cmd, "Idade", System.Data.DbType.String, obj.idade);
                db.ExecuteNonQuery(cmd);
            }

        }




        public void Atualizar(Clientes obj)
        {
            throw new NotImplementedException();
        }

        public void Remover(Clientes obj)
        {
            throw new NotImplementedException();
        }

        public Clientes Buscar(Clientes obj)
        {
            Clientes Clientes = null;
            try
            {
                Database db = new DatabaseProviderFactory().Create("Database");
                string sql = @"SELECT idCPF,Nome, Sobrenome, Rg, Idade FROM TableClientes WHERE cpf = @idCPF";
                using (DbCommand cmd = db.GetSqlStringCommand(sql))
                {
                    db.AddInParameter(cmd, "idCPF", DbType.String, obj.cpf);
                    using (IDataReader dr = db.ExecuteReader(cmd))
                    {
                        if (dr.Read())
                        {
                            Clientes = new Clientes();
                            Clientes.cpf = Convert.ToString(dr["idCPF"]);
                            Clientes.nome = Convert.ToString(dr["Nome"]);
                            Clientes.sobrenome = Convert.ToString(dr["Sobrenome"]);
                            Clientes.rg = Convert.ToString(dr["Rg"]);
                            Clientes.idade = Convert.ToString(dr["Idade"]);

                        }
                    }
                }
                return Clientes;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
