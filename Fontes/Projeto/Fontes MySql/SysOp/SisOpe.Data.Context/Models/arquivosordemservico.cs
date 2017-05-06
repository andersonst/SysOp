using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class arquivosordemservico
    {
        public int IdArquivosOrdemServico { get; set; }
        public Nullable<int> IdOrdemServico { get; set; }
        public string PathArquivo { get; set; }
        public virtual ordemservico ordemservico { get; set; }
    }
}
