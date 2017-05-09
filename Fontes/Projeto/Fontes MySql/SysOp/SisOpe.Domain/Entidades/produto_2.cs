using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class Produto_2
    {
        public Produto_2()
        {
            this.itemtransferenciaestoques = new List<ItemTransferenciaEstoque>();
            this.tabelaprecoes = new List<TabelaPreco>();
        }

        public long IdProduto { get; set; }
        public Nullable<int> IdUnidadeMedida { get; set; }
        public Nullable<int> IdMarcaProduto { get; set; }
        public Nullable<int> IdTipoProduto { get; set; }
        public string Nome { get; set; }
        public Nullable<int> QtdMinimaEstoque { get; set; }
        public string CodigoBarras { get; set; }
        public string Observacoes { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> DataValidade { get; set; }
        public virtual ICollection<ItemTransferenciaEstoque> itemtransferenciaestoques { get; set; }
        public virtual MarcaProduto marcaproduto { get; set; }
        public virtual TipoProduto tipoproduto { get; set; }
        public virtual UnidadeMedida unidademedida { get; set; }
        public virtual ICollection<TabelaPreco> tabelaprecoes { get; set; }
    }
}
