using System;
using System.Collections.Generic;

namespace SysOp.Data.Entidades
{
    public partial class ProdutoEnt
    {
        public ProdutoEnt()
        {
            this.ItemEstoques = new List<ItemEstoqueEnt>();
            this.ItemProdutoNotaFiscals = new List<ItemProdutoNotaFiscalEnt>();
            this.ItemReservaProdutoes = new List<ItemReservaProdutoEnt>();
            this.ItemTransferenciaEstoques = new List<ItemTransferenciaEstoqueEnt>();
            this.ItemVendaEstoques = new List<ItemVendaEstoqueEnt>();
            this.TabelaPrecoes = new List<TabelaPrecoEnt>();
        }

        public int IdProduto { get; set; }
        public Nullable<int> IdUnidadeMedida { get; set; }
        public Nullable<int> IdMarcaProduto { get; set; }
        public Nullable<int> IdTipoProduto { get; set; }
        public string Nome { get; set; }
        public Nullable<int> QtdMinimaEstoque { get; set; }
        public string CodigoBarras { get; set; }
        public string Observacoes { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> DataValidade { get; set; }
        public virtual ICollection<ItemEstoqueEnt> ItemEstoques { get; set; }
        public virtual ICollection<ItemProdutoNotaFiscalEnt> ItemProdutoNotaFiscals { get; set; }
        public virtual ICollection<ItemReservaProdutoEnt> ItemReservaProdutoes { get; set; }
        public virtual ICollection<ItemTransferenciaEstoqueEnt> ItemTransferenciaEstoques { get; set; }
        public virtual ICollection<ItemVendaEstoqueEnt> ItemVendaEstoques { get; set; }
        public virtual MarcaProdutoEnt MarcaProduto { get; set; }
        public virtual TipoProdutoEnt TipoProduto { get; set; }
        public virtual UnidadeMedidaEnt UnidadeMedida { get; set; }
        public virtual ICollection<TabelaPrecoEnt> TabelaPrecoes { get; set; }
    }
}
