using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class OrdemServico
    {
        public OrdemServico()
        {
            this.arquivosordemservicoes = new List<ArquivosOrdemServico>();
            this.equipeordemservicoes = new List<EquipeOrdemServico>();
            this.historicoordemservicoes = new List<HistoricoOrdemServico>();
            this.pagamentoordemservicoes = new List<PagamentoOrdemServico>();
        }

        public int IdOrdemServico { get; set; }
        public Nullable<long> IdPessoa { get; set; }
        public Nullable<int> IdStatusOrdemServico { get; set; }
        public Nullable<bool> Prioridade { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<ArquivosOrdemServico> arquivosordemservicoes { get; set; }
        public virtual ICollection<EquipeOrdemServico> equipeordemservicoes { get; set; }
        public virtual ICollection<HistoricoOrdemServico> historicoordemservicoes { get; set; }
        public virtual Pessoa pessoa { get; set; }
        public virtual StatusOrdemServico statusordemservico { get; set; }
        public virtual ICollection<PagamentoOrdemServico> pagamentoordemservicoes { get; set; }
    }
}
