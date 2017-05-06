using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class ordemservico
    {
        public ordemservico()
        {
            this.arquivosordemservicoes = new List<arquivosordemservico>();
            this.equipeordemservicoes = new List<equipeordemservico>();
            this.historicoordemservicoes = new List<historicoordemservico>();
            this.pagamentoordemservicoes = new List<pagamentoordemservico>();
        }

        public int IdOrdemServico { get; set; }
        public Nullable<long> IdPessoa { get; set; }
        public Nullable<int> IdStatusOrdemServico { get; set; }
        public Nullable<bool> Prioridade { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<arquivosordemservico> arquivosordemservicoes { get; set; }
        public virtual ICollection<equipeordemservico> equipeordemservicoes { get; set; }
        public virtual ICollection<historicoordemservico> historicoordemservicoes { get; set; }
        public virtual pessoa pessoa { get; set; }
        public virtual statusordemservico statusordemservico { get; set; }
        public virtual ICollection<pagamentoordemservico> pagamentoordemservicoes { get; set; }
    }
}
