using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class VendaProduto
    {
        public VendaProduto()
        {
            this.ItemReservaProdutoes = new List<ItemReservaProduto>();
            this.ItemReservaVendaProdutoes = new List<ItemReservaVendaProduto>();
            this.ItemVendaEstoques = new List<ItemVendaEstoque>();
        }

        public int IdVendaProduto { get; set; }
        public Nullable<System.DateTime> DataVenda { get; set; }
        public Nullable<int> IdVendedor { get; set; }
        public Nullable<int> IdCliente { get; set; }
        public Nullable<int> IdEndereco { get; set; }
        public Nullable<int> IdUnidade { get; set; }
        public Nullable<int> CodigoVenda { get; set; }
        public virtual Endereco Endereco { get; set; }
        public virtual ICollection<ItemReservaProduto> ItemReservaProdutoes { get; set; }
        public virtual ICollection<ItemReservaVendaProduto> ItemReservaVendaProdutoes { get; set; }
        public virtual ICollection<ItemVendaEstoque> ItemVendaEstoques { get; set; }
        public virtual Unidade Unidade { get; set; }
    }
}
