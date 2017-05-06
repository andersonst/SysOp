using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class pessoafisica
    {
        public int IdPessoaFisica { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public Nullable<System.DateTime> DataNascimento { get; set; }
        public string Sexo { get; set; }
        public Nullable<long> IdPessoa { get; set; }
        public virtual pessoa pessoa { get; set; }
    }
}
