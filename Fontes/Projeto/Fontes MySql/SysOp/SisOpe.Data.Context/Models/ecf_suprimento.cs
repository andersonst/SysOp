using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class Ecf_Suprimento
    {
        public long ID { get; set; }
        public long ID_ECF_MOVIMENTO { get; set; }
        public Nullable<System.DateTime> DATA_SUPRIMENTO { get; set; }
        public Nullable<decimal> VALOR { get; set; }
        public virtual Ecf_Movimento ecf_movimento { get; set; }
    }
}
