using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class solicitacaocompra
    {
        public solicitacaocompra()
        {
            this.itemsolicitacaocompras = new List<itemsolicitacaocompra>();
            this.itemsolicitacaocompracotacaos = new List<itemsolicitacaocompracotacao>();
            this.solicitacaopedidocompras = new List<solicitacaopedidocompra>();
        }

        public int IdSolicitacaoCompra { get; set; }
        public Nullable<int> IdAprovador { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
        public virtual ICollection<itemsolicitacaocompra> itemsolicitacaocompras { get; set; }
        public virtual ICollection<itemsolicitacaocompracotacao> itemsolicitacaocompracotacaos { get; set; }
        public virtual ICollection<solicitacaopedidocompra> solicitacaopedidocompras { get; set; }
    }
}
