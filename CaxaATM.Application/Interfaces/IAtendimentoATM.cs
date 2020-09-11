using CaixaATM.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaATM.Application.Services
{
    public interface IAtendimentoATM
    {
        public ClienteDTO Autenticar(string cpf, string senha, Guid origemAtendimento);
        public ProtocoloDTO Depositar(int conta, decimal valor, Guid origemAtendimento);
        public ProtocoloDTO Sacar(int conta, decimal valor, Guid origemAtendimento);
        public ProtocoloDTO Transferir(int contaOrigem, int contaDestino, decimal valor, Guid origemAtendimento);
        public List<ContaClienteDTO> ListarContasCliente(string cpf);
    }
}
