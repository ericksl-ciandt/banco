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
        public void TestMethod1()
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
    }
}
