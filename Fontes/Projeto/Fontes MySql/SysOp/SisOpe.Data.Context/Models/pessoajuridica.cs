using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class pessoajuridica
    {
        public int IdPessoaJuridica { get; set; }
        public string CNPJ { get; set; }
        public string IE { get; set; }
        public Nullable<long> IdPessoa { get; set; }
        public virtual pessoa pessoa { get; set; }
    }
}
