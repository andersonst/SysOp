using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class SolicitacaoCompra
    {
        public SolicitacaoCompra()
        {
            this.ItemSolicitacaoCompras = new List<ItemSolicitacaoCompra>();
            this.ItemSolicitacaoCompraCotacaos = new List<ItemSolicitacaoCompraCotacao>();
            this.SolicitacaoPedidoCompras = new List<SolicitacaoPedidoCompra>();
        }

        public int IdSolicitacaoCompra { get; set; }
        public Nullable<int> IdAprovador { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
        public virtual ICollection<ItemSolicitacaoCompra> ItemSolicitacaoCompras { get; set; }
        public virtual ICollection<ItemSolicitacaoCompraCotacao> ItemSolicitacaoCompraCotacaos { get; set; }
        public virtual ICollection<SolicitacaoPedidoCompra> SolicitacaoPedidoCompras { get; set; }
    }
}
