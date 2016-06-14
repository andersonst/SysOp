using System;
using System.Collections.Generic;

namespace SysOp.Data.Entidades
{
    public partial class PessoaJuridicaEnt
    {
        public int IdPessoaJuridica { get; set; }
        public string CNPJ { get; set; }
        public string IE { get; set; }
        public Nullable<int> IdPessoa { get; set; }
        public virtual PessoaEnt Pessoa { get; set; }
    }
}
