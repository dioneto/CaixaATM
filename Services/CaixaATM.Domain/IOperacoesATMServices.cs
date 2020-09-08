using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaATM.Domain
{
    public interface IOperacoesATMServices
    {
        public Cliente Autenticar(string CPF, string senha);
        public Movimentacao Depositar(int conta, double valor, Guid origemAtendimento);
        public Movimentacao Sacar(int conta, double valor, Guid origemAtendimento);
        public Movimentacao Transferir(int contaOrigem, int contaDestino, double valor, Guid origemAtendimento);
    }
}
