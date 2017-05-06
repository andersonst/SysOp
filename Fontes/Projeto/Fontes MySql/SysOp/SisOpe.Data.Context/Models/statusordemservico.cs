using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class statusordemservico
    {
        public statusordemservico()
        {
            this.ordemservicoes = new List<ordemservico>();
        }

        public int IdStatusOrdemServico { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }
        public virtual ICollection<ordemservico> ordemservicoes { get; set; }
    }
}
