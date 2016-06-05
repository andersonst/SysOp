using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class TransferenciaEstoque
    {
        public TransferenciaEstoque()
        {
            this.ItemReservaProdutoes = new List<ItemReservaProduto>();
            this.ItemReservaVendaProdutoes = new List<ItemReservaVendaProduto>();
            this.ItemTransferenciaEstoques = new List<ItemTransferenciaEstoque>();
        }

        public int IdTE { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> DataSeparacao { get; set; }
        public Nullable<System.DateTime> DataAtual { get; set; }
        public Nullable<int> IdOperador { get; set; }
        public virtual ICollection<ItemReservaProduto> ItemReservaProdutoes { get; set; }
        public virtual ICollection<ItemReservaVendaProduto> ItemReservaVendaProdutoes { get; set; }
        public virtual ICollection<ItemTransferenciaEstoque> ItemTransferenciaEstoques { get; set; }
    }
}
