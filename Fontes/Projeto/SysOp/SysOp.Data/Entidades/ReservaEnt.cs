using System;
using System.Collections.Generic;

namespace SysOp.Data.Entidades
{
    public partial class ReservaEnt
    {
        public ReservaEnt()
        {
            this.ItemReservaProdutoes = new List<ItemReservaProdutoEnt>();
            this.ItemReservaVendaProdutoes = new List<ItemReservaVendaProdutoEnt>();
        }

        public int IdReserva { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
        public string Status { get; set; }
        public Nullable<int> IdUsuario { get; set; }
        public Nullable<int> IdUnidade { get; set; }
        public virtual ICollection<ItemReservaProdutoEnt> ItemReservaProdutoes { get; set; }
        public virtual ICollection<ItemReservaVendaProdutoEnt> ItemReservaVendaProdutoes { get; set; }
        public virtual UnidadeEnt Unidade { get; set; }
        public virtual UsuarioEnt Usuario { get; set; }
    }
}
