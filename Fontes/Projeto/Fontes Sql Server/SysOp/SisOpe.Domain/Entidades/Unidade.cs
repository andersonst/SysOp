using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class Unidade
    {
        public Unidade()
        {
            this.itemestoques = new List<ItemEstoque>();
            this.itemtransferenciaestoques = new List<ItemTransferenciaEstoque>();
            this.itemtransferenciaestoques1 = new List<ItemTransferenciaEstoque>();
            this.reservas = new List<Reserva>();
            this.vendaprodutoes = new List<VendaProduto>();
        }

        public int IdUnidade { get; set; }
        public Nullable<int> IdPessoaJuridica { get; set; }
        public Nullable<int> IdMatriz { get; set; }
        public virtual ICollection<ItemEstoque> itemestoques { get; set; }
        public virtual ICollection<ItemTransferenciaEstoque> itemtransferenciaestoques { get; set; }
        public virtual ICollection<ItemTransferenciaEstoque> itemtransferenciaestoques1 { get; set; }
        public virtual ICollection<Reserva> reservas { get; set; }
        public virtual ICollection<VendaProduto> vendaprodutoes { get; set; }
    }
}
