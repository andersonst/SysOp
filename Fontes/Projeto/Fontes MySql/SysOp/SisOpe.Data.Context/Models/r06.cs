using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class r06
    {
        public r06()
        {
            this.r07 = new List<r07>();
        }

        public long ID { get; set; }
        public long ID_ECF_CAIXA { get; set; }
        public long ID_OPERADOR { get; set; }
        public long ID_IMPRESSORA { get; set; }
        public Nullable<long> COO { get; set; }
        public Nullable<long> GNF { get; set; }
        public Nullable<long> GRG { get; set; }
        public Nullable<long> CDC { get; set; }
        public string DENOMINACAO { get; set; }
        public Nullable<System.DateTime> DATA_EMISSAO { get; set; }
        public string HORA_EMISSAO { get; set; }
        public string SINCRONIZADO { get; set; }
        public virtual ecf_caixa ecf_caixa { get; set; }
        public virtual ICollection<r07> r07 { get; set; }
    }
}
