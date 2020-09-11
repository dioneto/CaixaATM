using CaixaATM.Application.DTOs;
using CaixaATM.Domain;
using CaixaATM.Domain.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaixaATM.Application.Services
{
    public class AtendimentoATM : IAtendimentoATM
    {
        private readonly IOperacoesATMServices _operacoesATMServices;
        public AtendimentoATM(IOperacoesATMServices operacoesATMServices)
        {
            _operacoesATMServices = operacoesATMServices;
        }

        public ClienteDTO Autenticar(string cpf, string senha, Guid origemAtendimento)
        {
            var cliente = _operacoesATMServices.Autenticar(cpf, senha);
            //if (cliente == null) throw new DomainException("Usuario ou Senha inválidos");

            return new ClienteDTO() { Cpf = cliente.CPF, Nome = cliente.Nome };
        }

        public ProtocoloDTO Depositar(int conta, decimal valor, Guid origemAtendimento)
        {
            throw new NotImplementedException();
        }

        public List<ContaClienteDTO> ListarContasCliente(string cpf)
        {
            var contas = _operacoesATMServices.Contas(cpf);

            return contas.Select(x => new ContaClienteDTO() {Conta = x.NumeroConta, Saldo = x.Saldo, Tipo = "Conta Corrente" }).ToList();
        }

        public ProtocoloDTO Sacar(int conta, decimal valor, Guid origemAtendimento)
        {
            throw new NotImplementedException();
        }

        public ProtocoloDTO Transferir(int contaOrigem, int contaDestino, decimal valor, Guid origemAtendimento)
        {
            throw new NotImplementedException();
        }
    }
}
