using System;
using System.Collections.Generic;

namespace SysOp.Data.Entidades
{
    public partial class FuncionarioEnt
    {
        public int IdFuncionario { get; set; }
        public Nullable<int> IdPessoa { get; set; }
        public Nullable<decimal> ValorHora { get; set; }
        public string Foto { get; set; }
    }
}
