using CaixaATM.Domain.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaATM.Data.Model
{
    public class Conta_Repos
    {

        public Guid Id { get; set; }
        public string NumeroConta { get; set; }
        public string CPFCliente { get; set; }
        public decimal Saldo { get; set; }

   

    }
}
