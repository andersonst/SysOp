using System;
using System.Collections.Generic;

namespace SysOp.Data.Entidades
{
    public partial class UnidadeEnt
    {
        public UnidadeEnt()
        {
            this.ItemEstoques = new List<ItemEstoqueEnt>();
            this.ItemReservaVendaProdutoes = new List<ItemReservaVendaProdutoEnt>();
            this.IdLocalOrigem = new List<ItemTransferenciaEstoqueEnt>();
            this.IdLocalDestino = new List<ItemTransferenciaEstoqueEnt>();
            this.Reservas = new List<ReservaEnt>();
            this.VendaProdutoes = new List<VendaProdutoEnt>();
        }

        public int IdUnidade { get; set; }
        public Nullable<int> IdPessoaJuridica { get; set; }
        public Nullable<int> IdMatriz { get; set; }
        public virtual ICollection<ItemEstoqueEnt> ItemEstoques { get; set; }
        public virtual ICollection<ItemReservaVendaProdutoEnt> ItemReservaVendaProdutoes { get; set; }
        public virtual ICollection<ItemTransferenciaEstoqueEnt> IdLocalOrigem { get; set; }
        public virtual ICollection<ItemTransferenciaEstoqueEnt> IdLocalDestino { get; set; }
        public virtual ICollection<ReservaEnt> Reservas { get; set; }
        public virtual ICollection<VendaProdutoEnt> VendaProdutoes { get; set; }
    }
}
