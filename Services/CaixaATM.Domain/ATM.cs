using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaATM.Domain
{
    public class ATM
    {
        public Guid Id { get; private set; }
        public string Agencia { get; private set; }
        public ATM(string agencia)
        {
            Id = Guid.NewGuid();
            Agencia = agencia;
        }

    }
}
