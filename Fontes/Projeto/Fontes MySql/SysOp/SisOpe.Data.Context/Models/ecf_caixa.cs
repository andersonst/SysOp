using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class ecf_caixa
    {
        public ecf_caixa()
        {
            this.ecf_configuracao = new List<ecf_configuracao>();
            this.ecf_movimento = new List<ecf_movimento>();
            this.r02 = new List<r02>();
            this.r06 = new List<r06>();
        }

        public long ID { get; set; }
        public string NOME { get; set; }
        public Nullable<System.DateTime> DATA_CADASTRO { get; set; }
        public virtual ICollection<ecf_configuracao> ecf_configuracao { get; set; }
        public virtual ICollection<ecf_movimento> ecf_movimento { get; set; }
        public virtual ICollection<r02> r02 { get; set; }
        public virtual ICollection<r06> r06 { get; set; }
    }
}
