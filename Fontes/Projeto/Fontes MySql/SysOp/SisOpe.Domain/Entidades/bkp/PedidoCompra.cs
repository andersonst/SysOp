using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class PedidoCompra
    {
        public PedidoCompra()
        {
            this.EntradaProdutoNFs = new List<EntradaProdutoNF>();
            this.ItemPedidoCompras = new List<ItemPedidoCompra>();
            this.ItemPedidoCompraCotacaos = new List<ItemPedidoCompraCotacao>();
            this.PagamentoPedidoCompras = new List<PagamentoPedidoCompra>();
            this.SolicitacaoPedidoCompras = new List<SolicitacaoPedidoCompra>();
        }

        public int IdPedidoCompra { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
        public string Automatico { get; set; }
        public string Status { get; set; }
        public virtual ICollection<EntradaProdutoNF> EntradaProdutoNFs { get; set; }
        public virtual ICollection<ItemPedidoCompra> ItemPedidoCompras { get; set; }
        public virtual ICollection<ItemPedidoCompraCotacao> ItemPedidoCompraCotacaos { get; set; }
        public virtual ICollection<PagamentoPedidoCompra> PagamentoPedidoCompras { get; set; }
        public virtual ICollection<SolicitacaoPedidoCompra> SolicitacaoPedidoCompras { get; set; }
    }
}
