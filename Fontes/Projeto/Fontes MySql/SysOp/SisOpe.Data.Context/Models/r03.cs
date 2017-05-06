using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class r03
    {
        public long ID { get; set; }
        public long ID_R02 { get; set; }
        public string TOTALIZADOR_PARCIAL { get; set; }
        public Nullable<decimal> VALOR_ACUMULADO { get; set; }
        public virtual r02 r02 { get; set; }
    }
}
