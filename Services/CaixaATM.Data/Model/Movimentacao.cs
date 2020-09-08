using System;
using System.Collections.Generic;
using System.Text;
using static CaixaATM.Domain.DomainObjects.Enum;

namespace CaixaATM.Data.Model
{
    public class Movimentacao_Repos
    {

        public TipoMovimentacao Tipo { get; set; }
        public Guid Origem { get; set; }
        public Guid Destino { get; set; }
        public decimal Valor { get; set; }
        public string Autenticacao { get; set; }
        public DateTime Hora { get; set; }

    }
}
