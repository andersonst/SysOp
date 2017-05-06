using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class itemretornocotacao
    {
        public itemretornocotacao()
        {
            this.itemsolicitacaocompracotacaos = new List<itemsolicitacaocompracotacao>();
        }

        public int IdItemRetornoCotacao { get; set; }
        public Nullable<int> IdProdutoCotacao { get; set; }
        public Nullable<int> IdFornecedorCotacao { get; set; }
        public Nullable<decimal> QuantidadeFornecedor { get; set; }
        public Nullable<decimal> ValorUnitarioFornecedor { get; set; }
        public Nullable<int> DiasParaEntrega { get; set; }
        public virtual fornecedorcotacao fornecedorcotacao { get; set; }
        public virtual produtocotacao produtocotacao { get; set; }
        public virtual ICollection<itemsolicitacaocompracotacao> itemsolicitacaocompracotacaos { get; set; }
    }
}
