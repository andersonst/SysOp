using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class PessoaJuridica
    {
        public int IdPessoaJuridica { get; set; }
        public string CNPJ { get; set; }
        public string IE { get; set; }
        public Nullable<int> IdPessoa { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}
