using System;
using System.Collections.Generic;

namespace SysOp.Data.Entidades
{
    public partial class OrdemServicoEnt
    {
        public OrdemServicoEnt()
        {
            this.ArquivosOrdemServicoes = new List<ArquivosOrdemServicoEnt>();
            this.EquipeOrdemServicoes = new List<EquipeOrdemServicoEnt>();
            this.HistoricoOrdemServicoes = new List<HistoricoOrdemServicoEnt>();
            this.PagamentoOrdemServicoes = new List<PagamentoOrdemServicoEnt>();
        }

        public int IdOrdemServico { get; set; }
        public Nullable<int> IdPessoa { get; set; }
        public Nullable<int> IdStatusOrdemServico { get; set; }
        public Nullable<bool> Prioridade { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<ArquivosOrdemServicoEnt> ArquivosOrdemServicoes { get; set; }
        public virtual ICollection<EquipeOrdemServicoEnt> EquipeOrdemServicoes { get; set; }
        public virtual ICollection<HistoricoOrdemServicoEnt> HistoricoOrdemServicoes { get; set; }
        public virtual PessoaEnt Pessoa { get; set; }
        public virtual StatusOrdemServicoEnt StatusOrdemServico { get; set; }
        public virtual ICollection<PagamentoOrdemServicoEnt> PagamentoOrdemServicoes { get; set; }
    }
}
