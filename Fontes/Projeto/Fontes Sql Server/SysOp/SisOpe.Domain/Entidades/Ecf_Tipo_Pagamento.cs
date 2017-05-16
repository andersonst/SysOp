using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class Ecf_Tipo_Pagamento
    {
        public Ecf_Tipo_Pagamento()
        {
            this.ecf_total_tipo_pgto = new List<Ecf_Total_Tipo_Pgto>();
        }

        public long ID { get; set; }
        public string CODIGO { get; set; }
        public string DESCRICAO { get; set; }
        public string TEF { get; set; }
        public string IMPRIME_VINCULADO { get; set; }
        public virtual ICollection<Ecf_Total_Tipo_Pgto> ecf_total_tipo_pgto { get; set; }
    }
}
