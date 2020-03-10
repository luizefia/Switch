using Switch.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Switch.Domain.Entities
{
    public class StatusRelacionamento
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public bool Casado { get { return Id == (int)StatusRelacionamentoEnum.Casado;} }
        public bool Namorando { get { return Id == (int)StatusRelacionamentoEnum.Namorando; } }
        public bool Solteiro { get { return Id == (int)StatusRelacionamentoEnum.Solteiro; } }
    }
}
