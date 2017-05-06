using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class profissao
    {
        public int IdProfissoes { get; set; }
        public string Nome { get; set; }
        public Nullable<bool> Status { get; set; }
    }
}
