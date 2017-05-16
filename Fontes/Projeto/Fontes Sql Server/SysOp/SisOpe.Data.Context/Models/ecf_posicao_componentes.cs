using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class Ecf_Posicao_Componentes
    {
        public long ID { get; set; }
        public long ID_ECF_RESOLUCAO { get; set; }
        public string NOME { get; set; }
        public Nullable<long> ALTURA { get; set; }
        public Nullable<long> LARGURA { get; set; }
        public Nullable<long> TOPO { get; set; }
        public Nullable<long> ESQUERDA { get; set; }
        public Nullable<long> TAMANHO_FONTE { get; set; }
        public string TEXTO { get; set; }
        public virtual Ecf_Resolucao ecf_resolucao { get; set; }
    }
}
