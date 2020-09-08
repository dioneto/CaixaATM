using CaixaATM.Data.Model;
using CaixaATM.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaixaATM.Data.Repository
{
    public class ATMRepository : IATMRepository
    {
        private List<ATM_Repos> _atm { get; set; }
        private List<Cliente_Repos> _cliente { get; set; }
        private List<Conta_Repos> _conta { get; set; }
        private List<Movimentacao_Repos> _movimentacaos { get; set; }

        public ATMRepository()
        {
            _atm = new List<ATM_Repos>();
            _cliente = new List<Cliente_Repos>();
            _conta = new List<Conta_Repos>();
        }

        public bool AtualizarSaldoConta(decimal valor, string conta)
        {
            _conta.Find(x => x.NumeroConta == conta).Saldo=valor;
            
            return true;
        }

        public ATM Incluir(ATM atm)
        {
            _atm.Add(new ATM_Repos() { Agencia = atm.Agencia, Id = atm.Id });

            return atm;
        }

        public Cliente IncluirCliente(Cliente cliente)
        {
            _cliente.Add(new Cliente_Repos()
            {
                Id = cliente.Id,
                CPF = cliente.CPF,
                DataNascimento = cliente.DataNascimento,
                Nome = cliente.Nome,
                Senha = cliente.Senha
            });

            return cliente;
        }

        public Conta IncluirConta(Conta conta)
        {
            _conta.Add(new Conta_Repos()
            {
                Id = conta.Id,
                CPFCliente = conta.Correntista.CPF,
                NumeroConta = conta.NumeroConta,
                Saldo = conta.Saldo
            });

            return conta;
        }

        public Movimentacao IncluirMovimentacao(Movimentacao movimentacao)
        {
            throw new NotImplementedException();
        }

        public ATM Ober(Guid id)
        {
            throw new NotImplementedException();
        }

        public Cliente ObterCliente(string cpf)
        {
            throw new NotImplementedException();
        }

        public Conta ObterConta(string numeroConta)
        {
            throw new NotImplementedException();
        }

        public List<Movimentacao> ObterMovimentacoesPorConta(string numeroConta)
        {
            throw new NotImplementedException();
        }

        public bool ValidarSenha(string cpf, string senha)
        {
            throw new NotImplementedException();
        }
    }
}
