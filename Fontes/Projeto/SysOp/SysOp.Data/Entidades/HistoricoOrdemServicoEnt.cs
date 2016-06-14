using System;
using System.Collections.Generic;

namespace SysOp.Data.Entidades
{
    public partial class HistoricoOrdemServicoEnt
    {
        public int IdHistoricoOrdemServico { get; set; }
        public Nullable<int> IdOrdemServico { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
        public Nullable<int> IdUsuario { get; set; }
        public string Observacao { get; set; }
        public virtual OrdemServicoEnt OrdemServico { get; set; }
    }
}
