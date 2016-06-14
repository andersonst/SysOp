using System;
using System.Collections.Generic;

namespace SysOp.Data.Entidades
{
    public partial class PessoaFisicaEnt
    {
        public int IdPessoaFisica { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public Nullable<System.DateTime> DataNascimento { get; set; }
        public string Sexo { get; set; }
        public Nullable<int> IdPessoa { get; set; }
        public virtual PessoaEnt Pessoa { get; set; }
    }
}
