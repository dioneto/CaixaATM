using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaATM.Domain
{
    public class Cliente
    {
        public Guid Id { get; private set; }
        public string CPF { get; private set; }
        public string Nome { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public string Senha { get; private set; }

        public Cliente(string cPF, string nome, DateTime dataNascimento)
        {
            Id = Guid.NewGuid();
            CPF = cPF;
            Nome = nome;
            DataNascimento = dataNascimento;
        }

        public bool DefinirSenha(string passw)
        {
            throw new NotImplementedException();
        }

        public bool AlterarSenha(string passw)
        {
            throw new NotImplementedException();
        }
    }
}
