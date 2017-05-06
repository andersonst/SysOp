using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class ecf_operador
    {
        public ecf_operador()
        {
            this.ecf_movimento = new List<ecf_movimento>();
        }

        public long ID { get; set; }
        public long ID_ECF_FUNCIONARIO { get; set; }
        public string LOGIN { get; set; }
        public string SENHA { get; set; }
        public virtual ICollection<ecf_movimento> ecf_movimento { get; set; }
        public virtual pessoa pessoa { get; set; }
    }
}
