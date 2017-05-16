using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class Ecf_Resolucao
    {
        public Ecf_Resolucao()
        {
            this.ecf_configuracao = new List<Ecf_Configuracao>();
            this.ecf_posicao_componentes = new List<Ecf_Posicao_Componentes>();
        }

        public long ID { get; set; }
        public string RESOLUCAO_TELA { get; set; }
        public Nullable<long> LARGURA { get; set; }
        public Nullable<long> ALTURA { get; set; }
        public string IMAGEM_TELA { get; set; }
        public virtual ICollection<Ecf_Configuracao> ecf_configuracao { get; set; }
        public virtual ICollection<Ecf_Posicao_Componentes> ecf_posicao_componentes { get; set; }
    }
}
