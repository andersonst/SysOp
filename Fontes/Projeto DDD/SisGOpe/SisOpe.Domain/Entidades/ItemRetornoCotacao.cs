using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class ItemRetornoCotacao
    {
        public ItemRetornoCotacao()
        {
            this.ItemSolicitacaoCompraCotacaos = new List<ItemSolicitacaoCompraCotacao>();
        }

        public int IdItemRetornoCotacao { get; set; }
        public Nullable<int> IdProdutoCotacao { get; set; }
        public Nullable<int> IdFornecedorCotacao { get; set; }
        public Nullable<decimal> QuantidadeFornecedor { get; set; }
        public Nullable<decimal> ValorUnitarioFornecedor { get; set; }
        public Nullable<int> DiasParaEntrega { get; set; }
        public virtual FornecedorCotacao FornecedorCotacao { get; set; }
        public virtual ProdutoCotacao ProdutoCotacao { get; set; }
        public virtual ICollection<ItemSolicitacaoCompraCotacao> ItemSolicitacaoCompraCotacaos { get; set; }
    }
}
