using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaATM.Application.DTOs
{
    public class ContaClienteDTO
    {
        public int Conta { get; set; }
        public string Tipo { get; set; }
        public decimal Saldo { get; set; }
    }
}
