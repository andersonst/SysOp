using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class Profissao
    {
        public int IdProfissoes { get; set; }
        public string Nome { get; set; }
        public Nullable<bool> Status { get; set; }
    }
}
