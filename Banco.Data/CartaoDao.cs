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
    public class CartaoDao : IData<Cartao>
    {
        public void Inserir(Cartao obj)
        {
            Database db = new DatabaseProviderFactory().Create("database");
            String sql = "INSERT INTO TableCartao (idCartao, validadeCartao,idCPF)";
            sql += "Values(@idCartao, @validadeCartao, @idCPF)";

            using (DbCommand cmd = db.GetSqlStringCommand(sql))
            {
                db.AddInParameter(cmd, "idCartao", System.Data.DbType.String, obj.idCartao);
                db.AddInParameter(cmd, "validadeCartao", System.Data.DbType.String, obj.validadeCartao);
                db.AddInParameter(cmd, "idCPF", System.Data.DbType.String, obj.idCPF);
                db.ExecuteNonQuery(cmd);
            }
        }

        public CartaoDao Buscar(Cartao obj)
        {
            Cartao cartao = null;
            try
            {
                Database db = new DatabaseProviderFactory().Create("Database");
                string sql = "SELECT idCartao,validadeCartao, idCPF FROM TableCartao WHERE idCartao = @idCartao";
                using (DbCommand cmd = db.GetSqlStringCommand(sql))
                {
                    db.AddInParameter(cmd, "idCartao", DbType.String, obj.idCartao);
                    using (IDataReader dr = db.ExecuteReader(cmd))
                    {
                        if (dr.Read())
                        {
                            cartao = new Cartao();
                            cartao.idCartao = Convert.ToString(dr["idCartao"]);
                            cartao.validadeCartao = Convert.ToString(dr["validadeCartao"]);
                            cartao.idCPF = Convert.ToString(dr["idCPF"]);

                    
                        }
                    }
                }
                return cartao;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}