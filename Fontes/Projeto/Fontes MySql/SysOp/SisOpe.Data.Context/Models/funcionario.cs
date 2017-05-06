using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class funcionario
    {
        public int IdFuncionario { get; set; }
        public Nullable<int> IdPessoa { get; set; }
        public Nullable<decimal> ValorHora { get; set; }
        public string Foto { get; set; }
    }
}
