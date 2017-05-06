using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class pedidocompra
    {
        public pedidocompra()
        {
            this.entradaprodutonfs = new List<entradaprodutonf>();
            this.itempedidocompras = new List<itempedidocompra>();
            this.itempedidocompracotacaos = new List<itempedidocompracotacao>();
            this.pagamentopedidocompras = new List<pagamentopedidocompra>();
            this.solicitacaopedidocompras = new List<solicitacaopedidocompra>();
        }

        public int IdPedidoCompra { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
        public string Automatico { get; set; }
        public string Status { get; set; }
        public virtual ICollection<entradaprodutonf> entradaprodutonfs { get; set; }
        public virtual ICollection<itempedidocompra> itempedidocompras { get; set; }
        public virtual ICollection<itempedidocompracotacao> itempedidocompracotacaos { get; set; }
        public virtual ICollection<pagamentopedidocompra> pagamentopedidocompras { get; set; }
        public virtual ICollection<solicitacaopedidocompra> solicitacaopedidocompras { get; set; }
    }
}
