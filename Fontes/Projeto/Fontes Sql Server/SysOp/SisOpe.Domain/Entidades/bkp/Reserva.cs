using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class Reserva
    {
        public Reserva()
        {
            this.ItemReservaProdutoes = new List<ItemReservaProduto>();
            this.ItemReservaVendaProdutoes = new List<ItemReservaVendaProduto>();
        }

        public int IdReserva { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
        public string Status { get; set; }
        public Nullable<int> IdUsuario { get; set; }
        public Nullable<int> IdUnidade { get; set; }
        public virtual ICollection<ItemReservaProduto> ItemReservaProdutoes { get; set; }
        public virtual ICollection<ItemReservaVendaProduto> ItemReservaVendaProdutoes { get; set; }
        public virtual Unidade Unidade { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
