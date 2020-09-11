using CaixaATM.Domain.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaATM.Domain
{
    public class Conta
    {

        public Guid Id { get; private set; }
        public int NumeroConta { get; private set; }
        public Cliente Correntista { get; private set; }
        public decimal Saldo { get; private set; }

        public Conta(int numeroConta, Cliente correntista, decimal saldo)
        {
            Id = Guid.NewGuid();
            NumeroConta = numeroConta;
            Correntista = correntista;
            Saldo = saldo;
        }

        public bool DepositarValor(decimal valor)
        {
            if (valor <= 0)
            {
                throw new DomainException("Valor do depósito inválido");
            }

            Saldo += valor;

            return true;
        }

        public bool RetirarValor(decimal valor)
        {
            if (valor <= 0)
            {
                throw new DomainException("Valor do depósito inválido");
            }

            Saldo -= valor;

            return true;
        }

    }
}
