using CaixaATM.Domain.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaATM.Domain
{
    public class OperacoesATMServices : IOperacoesATMServices
    {

        private readonly IATMRepository _ATMRepository;

        public OperacoesATMServices(IATMRepository ATMRepository)
        {
            _ATMRepository = ATMRepository;
        }

        public Cliente Autenticar(string CPF, string senha)
        {
            var cliente = _ATMRepository.ObterCliente(CPF);

            if (cliente == null) throw new DomainException("Usuario ou Senha inválidos");

            return cliente.ValidarSenha(senha) ? cliente : throw new DomainException("Usuario ou Senha inválidos"); ;

        }

        public Movimentacao ConsultarSaldo(string conta, Guid origemAtendimento)
        {
            throw new NotImplementedException();
        }

        public List<Conta> Contas(string cpf)
        {
            var contas = _ATMRepository.ObterContas(cpf);

            if (contas == null) throw new DomainException("Não encontrado contas para o CPF informado.");

            return contas;
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
