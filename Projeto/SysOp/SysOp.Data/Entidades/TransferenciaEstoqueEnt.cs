using System;
using System.Collections.Generic;

namespace SysOp.Data.Entidades
{
    public partial class TransferenciaEstoqueEnt
    {
        public TransferenciaEstoqueEnt()
        {
            this.ItemReservaProdutoes = new List<ItemReservaProdutoEnt>();
            this.ItemReservaVendaProdutoes = new List<ItemReservaVendaProdutoEnt>();
            this.ItemTransferenciaEstoques = new List<ItemTransferenciaEstoqueEnt>();
        }

        public int IdTE { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> DataSeparacao { get; set; }
        public Nullable<System.DateTime> DataAtual { get; set; }
        public Nullable<int> IdOperador { get; set; }
        public virtual ICollection<ItemReservaProdutoEnt> ItemReservaProdutoes { get; set; }
        public virtual ICollection<ItemReservaVendaProdutoEnt> ItemReservaVendaProdutoes { get; set; }
        public virtual ICollection<ItemTransferenciaEstoqueEnt> ItemTransferenciaEstoques { get; set; }
    }
}
