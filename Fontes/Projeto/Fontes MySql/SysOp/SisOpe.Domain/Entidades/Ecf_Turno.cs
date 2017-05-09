using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class Ecf_Turno
    {
        public Ecf_Turno()
        {
            this.ecf_movimento = new List<Ecf_Movimento>();
        }

        public long ID { get; set; }
        public string DESCRICAO { get; set; }
        public string HORA_INICIO { get; set; }
        public string HORA_FIM { get; set; }
        public virtual ICollection<Ecf_Movimento> ecf_movimento { get; set; }
    }
}
