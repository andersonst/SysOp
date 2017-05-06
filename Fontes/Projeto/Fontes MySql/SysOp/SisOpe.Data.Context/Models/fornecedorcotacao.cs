using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class fornecedorcotacao
    {
        public fornecedorcotacao()
        {
            this.itemretornocotacaos = new List<itemretornocotacao>();
        }

        public int IdFornecedorCotacao { get; set; }
        public Nullable<int> IdFornecedor { get; set; }
        public Nullable<int> IdCotacao { get; set; }
        public Nullable<decimal> ValorFrete { get; set; }
        public string Observacao { get; set; }
        public Nullable<System.DateTime> DataRetorno { get; set; }
        public Nullable<long> IdPessoa { get; set; }
        public virtual cotacao cotacao { get; set; }
        public virtual pessoa pessoa { get; set; }
        public virtual ICollection<itemretornocotacao> itemretornocotacaos { get; set; }
    }
}
