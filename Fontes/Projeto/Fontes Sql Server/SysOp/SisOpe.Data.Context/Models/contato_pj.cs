using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class Contato_PJ
    {
        public int IdContatoPJ { get; set; }
        public Nullable<int> IdPessoaJuridica { get; set; }
        public string Nome { get; set; }
    }
}
