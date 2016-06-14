using System;
using System.Collections.Generic;

namespace SysOp.Data.Entidades
{
    public partial class PedidoCompraEnt
    {
        public PedidoCompraEnt()
        {
            this.EntradaProdutoNFs = new List<EntradaProdutoNFEnt>();
            this.ItemPedidoCompras = new List<ItemPedidoCompraEnt>();
            this.ItemPedidoCompraCotacaos = new List<ItemPedidoCompraCotacaoEnt>();
            this.PagamentoPedidoCompras = new List<PagamentoPedidoCompraEnt>();
            this.SolicitacaoPedidoCompras = new List<SolicitacaoPedidoCompraEnt>();
        }

        public int IdPedidoCompra { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
        public string Automatico { get; set; }
        public string Status { get; set; }
        public virtual ICollection<EntradaProdutoNFEnt> EntradaProdutoNFs { get; set; }
        public virtual ICollection<ItemPedidoCompraEnt> ItemPedidoCompras { get; set; }
        public virtual ICollection<ItemPedidoCompraCotacaoEnt> ItemPedidoCompraCotacaos { get; set; }
        public virtual ICollection<PagamentoPedidoCompraEnt> PagamentoPedidoCompras { get; set; }
        public virtual ICollection<SolicitacaoPedidoCompraEnt> SolicitacaoPedidoCompras { get; set; }
    }
}
