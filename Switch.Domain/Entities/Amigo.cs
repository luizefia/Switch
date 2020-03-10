﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Switch.Domain.Entities
{
    public class Amigo
    {
        public int Id { get; set; }
        public virtual Usuario Usuario { get; set; }
        public int UsuarioAmigoId { get; set; }
        public Usuario UsuarioAmigo { get; set; }
    }
}
