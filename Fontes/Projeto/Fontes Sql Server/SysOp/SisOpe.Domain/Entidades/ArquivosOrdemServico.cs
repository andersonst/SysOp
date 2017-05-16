using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class ArquivosOrdemServico
    {
        public int IdArquivosOrdemServico { get; set; }
        public Nullable<int> IdOrdemServico { get; set; }
        public string PathArquivo { get; set; }
        public virtual OrdemServico ordemservico { get; set; }
    }
}
