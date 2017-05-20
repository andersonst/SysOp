using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class Ecf_Caixa
    {
        public Ecf_Caixa()
        {
            this.ecf_configuracao = new List<Ecf_Configuracao>();
            this.ecf_movimento = new List<Ecf_Movimento>();
            this.r02 = new List<R02>();
            this.r06 = new List<R06>();
        }

        public long ID { get; set; }
        public string NOME { get; set; }
        public Nullable<System.DateTime> DATA_CADASTRO { get; set; }
        public virtual ICollection<Ecf_Configuracao> ecf_configuracao { get; set; }
        public virtual ICollection<Ecf_Movimento> ecf_movimento { get; set; }
        public virtual ICollection<R02> r02 { get; set; }
        public virtual ICollection<R06> r06 { get; set; }
    }
}
