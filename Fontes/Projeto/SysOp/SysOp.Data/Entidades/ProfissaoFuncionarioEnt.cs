using System;
using System.Collections.Generic;

namespace SysOp.Data.Entidades
{
    public partial class ProfissaoFuncionarioEnt
    {
        public int IdProfissaoFuncionario { get; set; }
        public Nullable<int> IdProfissao { get; set; }
        public Nullable<int> IdFuncionario { get; set; }
        public Nullable<System.DateTime> DataInicio { get; set; }
        public Nullable<System.DateTime> DataFim { get; set; }
    }
}
