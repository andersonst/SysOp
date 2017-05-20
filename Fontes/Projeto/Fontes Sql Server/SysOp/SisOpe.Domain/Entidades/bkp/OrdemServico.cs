using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class OrdemServico
    {
        public OrdemServico()
        {
            this.ArquivosOrdemServicoes = new List<ArquivosOrdemServico>();
            this.EquipeOrdemServicoes = new List<EquipeOrdemServico>();
            this.HistoricoOrdemServicoes = new List<HistoricoOrdemServico>();
            this.PagamentoOrdemServicoes = new List<PagamentoOrdemServico>();
        }

        public int IdOrdemServico { get; set; }
        public Nullable<int> IdPessoa { get; set; }
        public Nullable<int> IdStatusOrdemServico { get; set; }
        public Nullable<bool> Prioridade { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<ArquivosOrdemServico> ArquivosOrdemServicoes { get; set; }
        public virtual ICollection<EquipeOrdemServico> EquipeOrdemServicoes { get; set; }
        public virtual ICollection<HistoricoOrdemServico> HistoricoOrdemServicoes { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public virtual StatusOrdemServico StatusOrdemServico { get; set; }
        public virtual ICollection<PagamentoOrdemServico> PagamentoOrdemServicoes { get; set; }
    }
}
