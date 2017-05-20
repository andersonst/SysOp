using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class Email
    {
        public int IdEmail { get; set; }
        public Nullable<long> IdPessoa { get; set; }
        public string Email1 { get; set; }
        public virtual Pessoa pessoa { get; set; }
    }
}
