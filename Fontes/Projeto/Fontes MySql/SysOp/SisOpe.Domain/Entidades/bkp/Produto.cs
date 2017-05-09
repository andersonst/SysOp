using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class Produto
    {
        public Produto()
        {
            this.ItemEstoques = new List<ItemEstoque>();
            this.ItemProdutoNotaFiscals = new List<ItemProdutoNotaFiscal>();
            this.ItemReservaProdutoes = new List<ItemReservaProduto>();
            this.ItemTransferenciaEstoques = new List<ItemTransferenciaEstoque>();
            this.ItemVendaEstoques = new List<ItemVendaEstoque>();
            this.TabelaPrecoes = new List<TabelaPreco>();
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
        public virtual ICollection<ItemEstoque> ItemEstoques { get; set; }
        public virtual ICollection<ItemProdutoNotaFiscal> ItemProdutoNotaFiscals { get; set; }
        public virtual ICollection<ItemReservaProduto> ItemReservaProdutoes { get; set; }
        public virtual ICollection<ItemTransferenciaEstoque> ItemTransferenciaEstoques { get; set; }
        public virtual ICollection<ItemVendaEstoque> ItemVendaEstoques { get; set; }
        public virtual MarcaProduto MarcaProduto { get; set; }
        public virtual TipoProduto TipoProduto { get; set; }
        public virtual UnidadeMedida UnidadeMedida { get; set; }
        public virtual ICollection<TabelaPreco> TabelaPrecoes { get; set; }
    }
}
