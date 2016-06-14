using System;
using System.Collections.Generic;

namespace SysOp.Data.Entidades
{
    public partial class EquipeOrdemServicoEnt
    {
        public int IdEquipeOrdemServico { get; set; }
        public Nullable<int> IdOrdemServico { get; set; }
        public Nullable<int> IdFuncionario { get; set; }
        public virtual OrdemServicoEnt OrdemServico { get; set; }
    }
}
