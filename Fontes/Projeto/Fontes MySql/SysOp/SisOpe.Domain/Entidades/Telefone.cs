using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class Telefone
    {
        public int IdTelefone { get; set; }
        public string Tipo { get; set; }
        public string DDD { get; set; }
        public string Telefone1 { get; set; }
        public Nullable<long> IdPessoa { get; set; }
        public virtual Pessoa pessoa { get; set; }
    }
}
