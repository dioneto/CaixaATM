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

        public Cliente(string cPF, string nome, DateTime dataNascimento, string senha = "Senha@123")
        {
            Id = Guid.NewGuid();
            CPF = cPF;
            Nome = nome;
            DataNascimento = dataNascimento;
            Senha = senha;
        }

        public bool ValidarSenha(string passw)
        {
            return Senha == passw;
        }

        public bool AlterarSenha(string passw)
        {
            throw new NotImplementedException();
        }
    }
}
