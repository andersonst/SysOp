using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class VendaProduto
    {
        public VendaProduto()
        {
            this.itemvendaestoques = new List<ItemVendaEstoque>();
        }

        public int IdVendaProduto { get; set; }
        public Nullable<System.DateTime> DataVenda { get; set; }
        public Nullable<int> IdVendedor { get; set; }
        public Nullable<int> IdCliente { get; set; }
        public Nullable<int> IdEndereco { get; set; }
        public Nullable<int> IdUnidade { get; set; }
        public Nullable<int> CodigoVenda { get; set; }
        public virtual Endereco_2 endereco_2 { get; set; }
        public virtual ICollection<ItemVendaEstoque> itemvendaestoques { get; set; }
        public virtual Unidade unidade { get; set; }
    }
}
