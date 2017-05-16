using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class Ecf_Operador
    {
        public Ecf_Operador()
        {
            this.ecf_movimento = new List<Ecf_Movimento>();
        }

        public long ID { get; set; }
        public long ID_ECF_FUNCIONARIO { get; set; }
        public string LOGIN { get; set; }
        public string SENHA { get; set; }
        public virtual ICollection<Ecf_Movimento> ecf_movimento { get; set; }
        public virtual Pessoa pessoa { get; set; }
    }
}
