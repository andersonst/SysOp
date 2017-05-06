using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class ecf_resolucao
    {
        public ecf_resolucao()
        {
            this.ecf_configuracao = new List<ecf_configuracao>();
            this.ecf_posicao_componentes = new List<ecf_posicao_componentes>();
        }

        public long ID { get; set; }
        public string RESOLUCAO_TELA { get; set; }
        public Nullable<long> LARGURA { get; set; }
        public Nullable<long> ALTURA { get; set; }
        public string IMAGEM_TELA { get; set; }
        public virtual ICollection<ecf_configuracao> ecf_configuracao { get; set; }
        public virtual ICollection<ecf_posicao_componentes> ecf_posicao_componentes { get; set; }
    }
}
