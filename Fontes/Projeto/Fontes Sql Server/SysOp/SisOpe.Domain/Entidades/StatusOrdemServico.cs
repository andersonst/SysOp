using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class StatusOrdemServico
    {
        public StatusOrdemServico()
        {
            this.ordemservicoes = new List<OrdemServico>();
        }

        public int IdStatusOrdemServico { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }
        public virtual ICollection<OrdemServico> ordemservicoes { get; set; }
    }
}
