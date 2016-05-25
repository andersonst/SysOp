using System;
using System.Collections.Generic;

namespace SysOp.Data.Entidades
{
    public partial class StatusOrdemServicoEnt
    {
        public StatusOrdemServicoEnt()
        {
            this.OrdemServicoes = new List<OrdemServicoEnt>();
        }

        public int IdStatusOrdemServico { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }
        public virtual ICollection<OrdemServicoEnt> OrdemServicoes { get; set; }
    }
}
