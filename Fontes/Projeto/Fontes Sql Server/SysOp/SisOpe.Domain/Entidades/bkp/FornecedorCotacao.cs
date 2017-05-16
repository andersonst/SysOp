using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class FornecedorCotacao
    {
        public FornecedorCotacao()
        {
            this.ItemRetornoCotacaos = new List<ItemRetornoCotacao>();
        }

        public int IdFornecedorCotacao { get; set; }
        public Nullable<int> IdFornecedor { get; set; }
        public Nullable<int> IdCotacao { get; set; }
        public Nullable<decimal> ValorFrete { get; set; }
        public string Observacao { get; set; }
        public Nullable<System.DateTime> DataRetorno { get; set; }
        public Nullable<int> IdPessoa { get; set; }
        public virtual Cotacao Cotacao { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public virtual ICollection<ItemRetornoCotacao> ItemRetornoCotacaos { get; set; }
    }
}
