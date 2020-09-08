using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaATM.Domain
{
    class OperacoesATMServices : IOperacoesATMServices
    {
        public Cliente Autenticar(string CPF, string senha)
        {
            throw new NotImplementedException();
        }

        public Movimentacao ConsultarSaldo(int conta, Guid origemAtendimento)
        {
            throw new NotImplementedException();
        }

        public Movimentacao Depositar(int conta, double valor, Guid origemAtendimento)
        {
            throw new NotImplementedException();
        }

        public Movimentacao Sacar(int conta, double valor, Guid origemAtendimento)
        {
            throw new NotImplementedException();
        }

        public Movimentacao Transferir(int contaOrigem, int contaDestino, double valor, Guid origemAtendimento)
        {
            throw new NotImplementedException();
        }
    }
}
