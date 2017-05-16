using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class SolicitacaoCompra
    {
        public SolicitacaoCompra()
        {
            this.itemsolicitacaocompras = new List<ItemSolicitacaoCompra>();
            this.itemsolicitacaocompracotacaos = new List<ItemSolicitacaoCompraCotacao>();
            this.solicitacaopedidocompras = new List<SolicitacaoPedidoCompra>();
        }

        public int IdSolicitacaoCompra { get; set; }
        public Nullable<int> IdAprovador { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
        public virtual ICollection<ItemSolicitacaoCompra> itemsolicitacaocompras { get; set; }
        public virtual ICollection<ItemSolicitacaoCompraCotacao> itemsolicitacaocompracotacaos { get; set; }
        public virtual ICollection<SolicitacaoPedidoCompra> solicitacaopedidocompras { get; set; }
    }
}
