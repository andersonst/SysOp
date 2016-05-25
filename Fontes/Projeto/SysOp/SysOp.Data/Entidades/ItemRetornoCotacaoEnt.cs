using System;
using System.Collections.Generic;

namespace SysOp.Data.Entidades
{
    public partial class ItemRetornoCotacaoEnt
    {
        public ItemRetornoCotacaoEnt()
        {
            this.ItemSolicitacaoCompraCotacaos = new List<ItemSolicitacaoCompraCotacaoEnt>();
        }

        public int IdItemRetornoCotacao { get; set; }
        public Nullable<int> IdProdutoCotacao { get; set; }
        public Nullable<int> IdFornecedorCotacao { get; set; }
        public Nullable<decimal> QuantidadeFornecedor { get; set; }
        public Nullable<decimal> ValorUnitarioFornecedor { get; set; }
        public Nullable<int> DiasParaEntrega { get; set; }
        public virtual FornecedorCotacaoEnt FornecedorCotacao { get; set; }
        public virtual ProdutoCotacaoEnt ProdutoCotacao { get; set; }
        public virtual ICollection<ItemSolicitacaoCompraCotacaoEnt> ItemSolicitacaoCompraCotacaos { get; set; }
    }
}
