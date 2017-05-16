using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class Email
    {
        public int IdEmail { get; set; }
        public Nullable<long> IdPessoa { get; set; }
        public string Email1 { get; set; }
        public virtual Pessoa pessoa { get; set; }
    }
}
