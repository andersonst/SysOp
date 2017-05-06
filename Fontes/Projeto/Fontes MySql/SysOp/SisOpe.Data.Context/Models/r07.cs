using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class r07
    {
        public long ID { get; set; }
        public Nullable<long> ID_R06 { get; set; }
        public Nullable<long> ID_R02 { get; set; }
        public Nullable<int> CCF { get; set; }
        public string MEIO_PAGAMENTO { get; set; }
        public Nullable<decimal> VALOR_PAGAMENTO { get; set; }
        public string ESTORNO { get; set; }
        public Nullable<decimal> VALOR_ESTORNO { get; set; }
        public virtual r02 r02 { get; set; }
        public virtual r06 r06 { get; set; }
    }
}
