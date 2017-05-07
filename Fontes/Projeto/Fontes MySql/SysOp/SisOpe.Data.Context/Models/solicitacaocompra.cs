using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class Solicitacaocompra
    {
        public Solicitacaocompra()
        {
            this.itemsolicitacaocompras = new List<ItemSolicitacaoCompra>();
            this.itemsolicitacaocompracotacaos = new List<ItemSolicitacaoCompraCotacao>();
            this.solicitacaopedidocompras = new List<Solicitacaopedidocompra>();
        }

        public int IdSolicitacaoCompra { get; set; }
        public Nullable<int> IdAprovador { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
        public virtual ICollection<ItemSolicitacaoCompra> itemsolicitacaocompras { get; set; }
        public virtual ICollection<ItemSolicitacaoCompraCotacao> itemsolicitacaocompracotacaos { get; set; }
        public virtual ICollection<Solicitacaopedidocompra> solicitacaopedidocompras { get; set; }
    }
}
