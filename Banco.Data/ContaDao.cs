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
    class ContaDao
    {
        public class ContaDao : IData<Conta>
        {
            public void Inserir(Conta obj)
            {
                Database db = new DatabaseProviderFactory().Create("database");
                String sql = "INSERT INTO TableConta (idConta, Saldo, idCartao, idCPF)";
                sql += "Values(@idConta, @Saldo, @idCartao, @idCPF)";

                using (DbCommand cmd = db.GetSqlStringCommand(sql))
                {
                    db.AddInParameter(cmd, "idConta", System.Data.DbType.String, obj.idConta);
                    db.AddInParameter(cmd, "Saldo", System.Data.DbType.String, obj.Saldo);
                    db.AddInParameter(cmd, "idCartao", System.Data.DbType.String, obj.idCartao);
                    db.AddInParameter(cmd, "idCPF", System.Data.DbType.String, obj.idCPF);
                    db.ExecuteNonQuery(cmd);
                }
            }

            public Conta Buscar(Conta obj)
            {
                Conta novaConta = new Conta();
                try
                {
                    Database db = new DatabaseProviderFactory().Create("Database");
                    string sql = "SELECT idConta,Saldo, idCartao, idCPF FROM TableCartao WHERE idConta = @idConta";
                    using (DbCommand cmd = db.GetSqlStringCommand(sql))
                    {
                        db.AddInParameter(cmd, "idConta", DbType.String, obj.idConta);
                        using (IDataReader dr = db.ExecuteReader(cmd))
                        {
                            if (dr.Read())
                            {
                                novaConta.idConta = Convert.ToString(dr["idConta"]);
                                novaConta.Saldo = Convert.ToDecimal(dr["Saldo"]);
                                novaConta.idCartao = Convert.ToString(dr["idCartao"]);
                                novaConta.idCPF = Convert.ToString(dr["idCPF"]);
                            }
                        }
                    }
                    return novaConta;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}