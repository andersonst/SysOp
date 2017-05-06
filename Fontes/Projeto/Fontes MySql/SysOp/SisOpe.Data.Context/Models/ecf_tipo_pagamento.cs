using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class ecf_tipo_pagamento
    {
        public ecf_tipo_pagamento()
        {
            this.ecf_total_tipo_pgto = new List<ecf_total_tipo_pgto>();
        }

        public long ID { get; set; }
        public string CODIGO { get; set; }
        public string DESCRICAO { get; set; }
        public string TEF { get; set; }
        public string IMPRIME_VINCULADO { get; set; }
        public virtual ICollection<ecf_total_tipo_pgto> ecf_total_tipo_pgto { get; set; }
    }
}
