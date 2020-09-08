using CaixaATM.Domain;
using NUnit.Framework;
using System;

namespace Tests1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Conta_CriarConta()
        {
            Cliente cliente1 = new Cliente("00100100101", "João da Silva", Convert.ToDateTime("1987-01-31"));
            Conta conta1 = new Conta("001001", cliente1, 0);
            Assert.Pass("001001", conta1.NumeroConta);
        }

        [Test]
        public void Conta_Depositar()
        {
            Cliente cliente1 = new Cliente("00100100101", "João da Silva", Convert.ToDateTime("1987-01-31"));
            Conta conta1 = new Conta("001001", cliente1, 0);
            Assert.Pass("001001", conta1.NumeroConta);
        }
    }
}