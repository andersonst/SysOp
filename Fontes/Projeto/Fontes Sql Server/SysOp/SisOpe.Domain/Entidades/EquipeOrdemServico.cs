using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class EquipeOrdemServico
    {
        public int IdEquipeOrdemServico { get; set; }
        public Nullable<int> IdOrdemServico { get; set; }
        public Nullable<int> IdFuncionario { get; set; }
        public virtual OrdemServico ordemservico { get; set; }
    }
}
