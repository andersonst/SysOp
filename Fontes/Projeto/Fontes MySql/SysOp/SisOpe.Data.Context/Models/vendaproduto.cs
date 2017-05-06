using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class vendaproduto
    {
        public vendaproduto()
        {
            this.itemvendaestoques = new List<itemvendaestoque>();
        }

        public int IdVendaProduto { get; set; }
        public Nullable<System.DateTime> DataVenda { get; set; }
        public Nullable<int> IdVendedor { get; set; }
        public Nullable<int> IdCliente { get; set; }
        public Nullable<int> IdEndereco { get; set; }
        public Nullable<int> IdUnidade { get; set; }
        public Nullable<int> CodigoVenda { get; set; }
        public virtual endereco_2 endereco_2 { get; set; }
        public virtual ICollection<itemvendaestoque> itemvendaestoques { get; set; }
        public virtual unidade unidade { get; set; }
    }
}
