using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class HistoricoOrdemServico
    {
        public int IdHistoricoOrdemServico { get; set; }
        public Nullable<int> IdOrdemServico { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
        public Nullable<int> IdUsuario { get; set; }
        public string Observacao { get; set; }
        public virtual OrdemServico ordemservico { get; set; }
    }
}
