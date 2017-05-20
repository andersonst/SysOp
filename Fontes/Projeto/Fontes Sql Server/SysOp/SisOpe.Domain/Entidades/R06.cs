using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class R06
    {
        public R06()
        {
            this.r07 = new List<R07>();
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
        public virtual Ecf_Caixa ecf_caixa { get; set; }
        public virtual ICollection<R07> r07 { get; set; }
    }
}
