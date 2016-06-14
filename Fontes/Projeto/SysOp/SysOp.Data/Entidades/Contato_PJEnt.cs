using System;
using System.Collections.Generic;

namespace SysOp.Data.Entidades
{
    public partial class Contato_PJEnt
    {
        public int IdContatoPJ { get; set; }
        public Nullable<int> IdPessoaJuridica { get; set; }
        public string Nome { get; set; }
    }
}
