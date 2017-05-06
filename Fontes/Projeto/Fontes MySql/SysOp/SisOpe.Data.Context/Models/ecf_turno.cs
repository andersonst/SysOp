using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class ecf_turno
    {
        public ecf_turno()
        {
            this.ecf_movimento = new List<ecf_movimento>();
        }

        public long ID { get; set; }
        public string DESCRICAO { get; set; }
        public string HORA_INICIO { get; set; }
        public string HORA_FIM { get; set; }
        public virtual ICollection<ecf_movimento> ecf_movimento { get; set; }
    }
}
