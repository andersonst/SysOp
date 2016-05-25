using System;
using System.Collections.Generic;

namespace SysOp.Data.Entidades
{
    public partial class VendaProdutoEnt
    {
        public VendaProdutoEnt()
        {
            this.ItemReservaProdutoes = new List<ItemReservaProdutoEnt>();
            this.ItemReservaVendaProdutoes = new List<ItemReservaVendaProdutoEnt>();
            this.ItemVendaEstoques = new List<ItemVendaEstoqueEnt>();
        }

        public int IdVendaProduto { get; set; }
        public Nullable<System.DateTime> DataVenda { get; set; }
        public Nullable<int> IdVendedor { get; set; }
        public Nullable<int> IdCliente { get; set; }
        public Nullable<int> IdEndereco { get; set; }
        public Nullable<int> IdUnidade { get; set; }
        public Nullable<int> CodigoVenda { get; set; }
        public virtual EnderecoEnt Endereco { get; set; }
        public virtual ICollection<ItemReservaProdutoEnt> ItemReservaProdutoes { get; set; }
        public virtual ICollection<ItemReservaVendaProdutoEnt> ItemReservaVendaProdutoes { get; set; }
        public virtual ICollection<ItemVendaEstoqueEnt> ItemVendaEstoques { get; set; }
        public virtual UnidadeEnt Unidade { get; set; }
    }
}
