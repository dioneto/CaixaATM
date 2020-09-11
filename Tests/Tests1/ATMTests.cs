using CaixaATM.Domain;
using CaixaATM.Domain.DomainObjects;
using NUnit.Framework;
using System;

namespace ATMTests
{
    public class Conta_Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Conta_CriarConta()
        {
            Cliente cliente1 = new Cliente("00100100101", "João da Silva", Convert.ToDateTime("1987-01-31"));
            Conta conta1 = new Conta(001001, cliente1, 0);
            Assert.Pass("001001", conta1.NumeroConta);
        }

        [Test]
        public void Conta_Depositar()
        {
            Cliente cliente1 = new Cliente("00100100101", "João da Silva", Convert.ToDateTime("1987-01-31"));
            Conta conta1 = new Conta(001001, cliente1, 0);
            var ret = conta1.DepositarValor(10);
            Assert.Pass("true", ret);
        }
        [Test]
        public void Conta_DepositoNegativo()
        {
            Cliente cliente1 = new Cliente("00100100101", "João da Silva", Convert.ToDateTime("1987-01-31"));
            Conta conta1 = new Conta(001001, cliente1, 0);

            var ex = Assert.Throws<DomainException>(() =>
                conta1.DepositarValor(-10)
            );

            Assert.Pass("O campo Nome do produto não pode estar vazio", ex.Message);
        }

        [Test]
        public void Conta_ValidarSaldoAposDeposito()
        {
            Cliente cliente1 = new Cliente("00100100101", "João da Silva", Convert.ToDateTime("1987-01-31"));
            Conta conta1 = new Conta(001001, cliente1, 0);
            conta1.DepositarValor(10);
            conta1.DepositarValor(10);
            conta1.DepositarValor(10);
            conta1.DepositarValor(60);
            Assert.Pass("90.00", conta1.Saldo);
        }
        [Test]
        public void Conta_Sacar()
        {
            Cliente cliente1 = new Cliente("00100100101", "João da Silva", Convert.ToDateTime("1987-01-31"));
            Conta conta1 = new Conta(001001, cliente1, 0);
            conta1.DepositarValor(1000);
            conta1.DepositarValor(1000);
            conta1.DepositarValor(1000);
            conta1.DepositarValor(1000);

            var ret = conta1.RetirarValor(200);
            Assert.Pass("true", ret);
        }

        [Test]
        public void Conta_ValidarSaldoAposSaque()
        {
            Cliente cliente1 = new Cliente("00100100101", "João da Silva", Convert.ToDateTime("1987-01-31"));
            Conta conta1 = new Conta(001001, cliente1, 0);
            conta1.DepositarValor(1000);
            conta1.DepositarValor(1000);
            conta1.DepositarValor(1000);
            conta1.DepositarValor(1000);

            var ret = conta1.RetirarValor(200);

            Assert.Pass("3800.00", conta1.Saldo);
        }
    }

    public class Cliente_Tests
    {

        [Test]
        public void Conta_NovoCliente()
        {
            Cliente cliente1 = new Cliente("00100100101", "João da Silva", Convert.ToDateTime("1987-01-31"), "Teste@123");

            Assert.Pass("00100100101", cliente1.CPF);
        }
        [Test]
        public void Conta_SenhaInvalida()
        {
            Cliente cliente1 = new Cliente("00100100101", "João da Silva", Convert.ToDateTime("1987-01-31"), "Teste@123");

            Assert.Pass("false", cliente1.ValidarSenha("Senha@123"));
        }
        [Test]
        public void Conta_SenhaValida()
        {
            Cliente cliente1 = new Cliente("00100100101", "João da Silva", Convert.ToDateTime("1987-01-31"), "Teste@123");

            Assert.Pass("true", cliente1.ValidarSenha("Teste@123"));
        }
    }
}