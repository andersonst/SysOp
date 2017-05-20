using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class FornecedorCotacao
    {
        public FornecedorCotacao()
        {
            this.itemretornocotacaos = new List<ItemRetornoCotacao>();
        }

        public int IdFornecedorCotacao { get; set; }
        public Nullable<int> IdFornecedor { get; set; }
        public Nullable<int> IdCotacao { get; set; }
        public Nullable<decimal> ValorFrete { get; set; }
        public string Observacao { get; set; }
        public Nullable<System.DateTime> DataRetorno { get; set; }
        public Nullable<long> IdPessoa { get; set; }
        public virtual Cotacao cotacao { get; set; }
        public virtual Pessoa pessoa { get; set; }
        public virtual ICollection<ItemRetornoCotacao> itemretornocotacaos { get; set; }
    }
}
