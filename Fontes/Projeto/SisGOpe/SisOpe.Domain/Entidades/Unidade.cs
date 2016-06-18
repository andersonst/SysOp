using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class Unidade
    {
        public Unidade()
        {
            this.ItemEstoques = new List<ItemEstoque>();
            this.ItemReservaVendaProdutoes = new List<ItemReservaVendaProduto>();
            this.IdLocalOrigem = new List<ItemTransferenciaEstoque>();
            this.IdLocalDestino = new List<ItemTransferenciaEstoque>();
            this.Reservas = new List<Reserva>();
            this.VendaProdutoes = new List<VendaProduto>();
        }

        public int IdUnidade { get; set; }
        public Nullable<int> IdPessoaJuridica { get; set; }
        public Nullable<int> IdMatriz { get; set; }
        public virtual ICollection<ItemEstoque> ItemEstoques { get; set; }
        public virtual ICollection<ItemReservaVendaProduto> ItemReservaVendaProdutoes { get; set; }
        public virtual ICollection<ItemTransferenciaEstoque> IdLocalOrigem { get; set; }
        public virtual ICollection<ItemTransferenciaEstoque> IdLocalDestino { get; set; }
        public virtual ICollection<Reserva> Reservas { get; set; }
        public virtual ICollection<VendaProduto> VendaProdutoes { get; set; }
    }
}
