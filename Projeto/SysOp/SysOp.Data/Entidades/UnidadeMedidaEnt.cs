using System;
using System.Collections.Generic;

namespace SysOp.Data.Entidades
{
    public partial class UnidadeMedidaEnt
    {
        public UnidadeMedidaEnt()
        {
            this.Produtoes = new List<ProdutoEnt>();
        }

        public int IdUnidadeMedida { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }
        public virtual ICollection<ProdutoEnt> Produtoes { get; set; }
    }
}
