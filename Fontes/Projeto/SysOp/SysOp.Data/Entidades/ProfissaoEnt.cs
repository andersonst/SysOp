using System;
using System.Collections.Generic;

namespace SysOp.Data.Entidades
{
    public partial class ProfissaoEnt
    {
        public int IdProfissoes { get; set; }
        public string Nome { get; set; }
        public Nullable<bool> Status { get; set; }
    }
}
