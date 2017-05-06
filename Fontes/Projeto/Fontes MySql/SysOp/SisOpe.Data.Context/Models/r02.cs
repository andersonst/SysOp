using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class r02
    {
        public r02()
        {
            this.r03 = new List<r03>();
            this.r07 = new List<r07>();
        }

        public long ID { get; set; }
        public long ID_ECF_CAIXA { get; set; }
        public long ID_OPERADOR { get; set; }
        public long ID_IMPRESSORA { get; set; }
        public Nullable<long> CRZ { get; set; }
        public Nullable<long> COO { get; set; }
        public Nullable<long> CRO { get; set; }
        public Nullable<System.DateTime> DATA_MOVIMENTO { get; set; }
        public Nullable<System.DateTime> DATA_EMISSAO { get; set; }
        public string HORA_EMISSAO { get; set; }
        public Nullable<decimal> VENDA_BRUTA { get; set; }
        public Nullable<decimal> GRANDE_TOTAL { get; set; }
        public string SINCRONIZADO { get; set; }
        public virtual ecf_caixa ecf_caixa { get; set; }
        public virtual ICollection<r03> r03 { get; set; }
        public virtual ICollection<r07> r07 { get; set; }
    }
}
