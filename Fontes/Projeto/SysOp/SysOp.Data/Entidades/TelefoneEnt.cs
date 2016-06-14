using System;
using System.Collections.Generic;

namespace SysOp.Data.Entidades
{
    public partial class TelefoneEnt
    {
        public int IdTelefone { get; set; }
        public string Tipo { get; set; }
        public string DDD { get; set; }
        public string Telefone1 { get; set; }
        public Nullable<int> IdPessoa { get; set; }
        public virtual PessoaEnt Pessoa { get; set; }
    }
}
