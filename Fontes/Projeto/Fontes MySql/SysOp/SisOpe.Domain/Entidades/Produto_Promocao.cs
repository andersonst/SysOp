using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class Produto_Promocao
    {
        public long ID { get; set; }
        public long ID_PRODUTO { get; set; }
        public Nullable<System.DateTime> DATA_INICIO { get; set; }
        public Nullable<System.DateTime> DATA_FIM { get; set; }
        public Nullable<decimal> VALOR { get; set; }
        public Nullable<decimal> QUANTIDADE_EM_PROMOCAO { get; set; }
        public Nullable<decimal> QUANTIDADE_MAXIMA_CLIENTE { get; set; }
        public virtual Produto produto { get; set; }
    }
}
