using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaATM.Data.Model
{
    public class Cliente_Repos
    {
        public Guid Id { get; set; }
        public string CPF { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Senha { get; set; }

    }
}
