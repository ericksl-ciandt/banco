using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Banco.Data;
using Banco.Model;

namespace TesteBanco
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestInsertCliente()
        {
            Clientes obj = new Clientes();
            obj.cpf = "123456789";
            obj.nome = "Erick";
            obj.sobrenome = "Lourenço";
            obj.rg = "3049128391";
            obj.idade = "19";
            ClienteDao dao = new ClienteDao();
            dao.Inserir(obj);

            Assert.IsTrue(true);
        }
        [TestMethod]
        public void TesteConsulta()
        {
            Clientes obj = new Clientes();
            obj.cpf = "123456789";
            ClienteDao dao = new ClienteDao();
            Clientes ret =  dao.Buscar(obj );
            Assert.IsTrue(ret.nome == "Erick");
        }
    }
}
