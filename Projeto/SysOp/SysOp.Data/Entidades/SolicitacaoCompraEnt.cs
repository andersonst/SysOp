using System;
using System.Collections.Generic;

namespace SysOp.Data.Entidades
{
    public partial class SolicitacaoCompraEnt
    {
        public SolicitacaoCompraEnt()
        {
            this.ItemSolicitacaoCompras = new List<ItemSolicitacaoCompraEnt>();
            this.ItemSolicitacaoCompraCotacaos = new List<ItemSolicitacaoCompraCotacaoEnt>();
            this.SolicitacaoPedidoCompras = new List<SolicitacaoPedidoCompraEnt>();
        }

        public int IdSolicitacaoCompra { get; set; }
        public Nullable<int> IdAprovador { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
        public virtual ICollection<ItemSolicitacaoCompraEnt> ItemSolicitacaoCompras { get; set; }
        public virtual ICollection<ItemSolicitacaoCompraCotacaoEnt> ItemSolicitacaoCompraCotacaos { get; set; }
        public virtual ICollection<SolicitacaoPedidoCompraEnt> SolicitacaoPedidoCompras { get; set; }
    }
}
