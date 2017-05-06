using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class formapagamento
    {
        public formapagamento()
        {
            this.pagamentoretornocotacaos = new List<pagamentoretornocotacao>();
        }

        public int IdFormaPagamento { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<pagamentoretornocotacao> pagamentoretornocotacaos { get; set; }
    }
}
