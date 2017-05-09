using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class FormaPagamento
    {
        public FormaPagamento()
        {
            this.pagamentoretornocotacaos = new List<PagamentoRetornoCotacao>();
        }

        public int IdFormaPagamento { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<PagamentoRetornoCotacao> pagamentoretornocotacaos { get; set; }
    }
}