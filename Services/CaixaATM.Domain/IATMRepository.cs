using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaATM.Domain
{
    public interface IATMRepository
    {
        public ATM Ober(Guid id);
        public ATM Incluir(ATM atm);
        public Cliente ObterCliente(string cpf);
        public bool ValidarSenha(string cpf, string senha);
        public Cliente IncluirCliente(Cliente cliente);
        public Conta ObterConta(string numeroConta);
        public Conta IncluirConta(Conta conta);
        public bool AtualizarSaldoConta(decimal valor, int conta);
        public List<Movimentacao> ObterMovimentacoesPorConta(string numeroConta);
        public Movimentacao IncluirMovimentacao(Movimentacao movimentacao);
        public List<Conta> ObterContas(string cpf);
    }
}
