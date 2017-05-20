using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class Contato_PJ
    {
        public int IdContatoPJ { get; set; }
        public Nullable<int> IdPessoaJuridica { get; set; }
        public string Nome { get; set; }
    }
}
