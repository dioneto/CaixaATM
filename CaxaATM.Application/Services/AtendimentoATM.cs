using CaixaATM.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaATM.Application.Services
{
    class AtendimentoATM : IAtendimentoATM
    {
        public ClienteDTO Autenticar(string cpf, string senha, Guid origemAtendimento)
        {
            throw new NotImplementedException();
        }

        public ProtocoloDTO Depositar(int conta, double valor, Guid origemAtendimento)
        {
            throw new NotImplementedException();
        }

        public ProtocoloDTO Sacar(int conta, double valor, Guid origemAtendimento)
        {
            throw new NotImplementedException();
        }

        public ProtocoloDTO Transferir(int contaOrigem, int contaDestino, double valor, Guid origemAtendimento)
        {
            throw new NotImplementedException();
        }
    }
}
