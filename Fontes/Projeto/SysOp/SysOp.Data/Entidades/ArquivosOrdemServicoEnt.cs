using System;
using System.Collections.Generic;

namespace SysOp.Data.Entidades
{
    public partial class ArquivosOrdemServicoEnt
    {
        public int IdArquivosOrdemServico { get; set; }
        public Nullable<int> IdOrdemServico { get; set; }
        public string PathArquivo { get; set; }
        public virtual OrdemServicoEnt OrdemServico { get; set; }
    }
}
