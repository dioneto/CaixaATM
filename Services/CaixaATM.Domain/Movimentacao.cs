using System;
using System.Collections.Generic;
using System.Text;
using static CaixaATM.Domain.DomainObjects.Enum;

namespace CaixaATM.Domain
{
    public class Movimentacao
    {

        public TipoMovimentacao Tipo { get; set; }
        public Guid Origem { get; set; }
        public Guid Destino { get; set; }
        public decimal Valor { get; set; }
        public string Autenticacao { get; set; }
        public DateTime Hora { get; set; }

        public Movimentacao(TipoMovimentacao tipo, Guid origem, Guid destino, decimal valor)
        {
            Tipo = tipo;
            Origem = origem;
            Destino = destino;
            Valor = valor;
            Autenticacao = Guid.NewGuid().ToString().Replace('-', '0').PadLeft(15);
            Hora = DateTime.Now;
        }

    }
}
