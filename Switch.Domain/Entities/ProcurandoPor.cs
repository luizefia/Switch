using Switch.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Switch.Domain.Entities
{
    public class ProcurandoPor
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public bool Amizade { get { return Id == (int)ProcurandoEnum.Amizade; } }
        public bool Namoro { get { return Id == (int)ProcurandoEnum.Namoro; } }
        public bool RelacionamentoSerio { get { return Id == (int)ProcurandoEnum.RelacionamentoSerio; } }
    }
}

