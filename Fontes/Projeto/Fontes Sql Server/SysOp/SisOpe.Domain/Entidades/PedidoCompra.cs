using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class PedidoCompra
    {
        public PedidoCompra()
        {
            this.entradaprodutonfs = new List<EntradaProdutoNF>();
            this.itempedidocompras = new List<ItemPedidoCompra>();
            this.itempedidocompracotacaos = new List<ItemPedidoCompraCotacao>();
            this.pagamentopedidocompras = new List<PagamentoPedidoCompra>();
            this.solicitacaopedidocompras = new List<SolicitacaoPedidoCompra>();
        }

        public int IdPedidoCompra { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
        public string Automatico { get; set; }
        public string Status { get; set; }
        public virtual ICollection<EntradaProdutoNF> entradaprodutonfs { get; set; }
        public virtual ICollection<ItemPedidoCompra> itempedidocompras { get; set; }
        public virtual ICollection<ItemPedidoCompraCotacao> itempedidocompracotacaos { get; set; }
        public virtual ICollection<PagamentoPedidoCompra> pagamentopedidocompras { get; set; }
        public virtual ICollection<SolicitacaoPedidoCompra> solicitacaopedidocompras { get; set; }
    }
}
