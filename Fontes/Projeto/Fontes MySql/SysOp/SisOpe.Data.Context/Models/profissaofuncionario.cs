using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class ProfissaoFuncionario
    {
        public int IdProfissaoFuncionario { get; set; }
        public Nullable<int> IdProfissao { get; set; }
        public Nullable<int> IdFuncionario { get; set; }
        public Nullable<System.DateTime> DataInicio { get; set; }
        public Nullable<System.DateTime> DataFim { get; set; }
    }
}
