using System;
using System.Collections.Generic;

namespace SysOp.Data.Entidades
{
    public partial class EmailEnt
    {
        public int IdEmail { get; set; }
        public Nullable<int> IdPessoa { get; set; }
        public string Email1 { get; set; }
        public virtual PessoaEnt Pessoa { get; set; }
    }
}
