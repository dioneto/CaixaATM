using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaATM.Application.DTOs
{
    public class ProtocoloDTO
    {
        public Guid Id { get; set; }
        public DateTime RealizadoEm { get; set; }
        public Guid LocalAtendimento { get; set; }

    }
}
