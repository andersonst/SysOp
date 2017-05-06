using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class ficha_tecnica
    {
        public long ID { get; set; }
        public long ID_PRODUTO { get; set; }
        public string DESCRICAO { get; set; }
        public Nullable<long> ID_PRODUTO_FILHO { get; set; }
        public Nullable<decimal> QUANTIDADE { get; set; }
        public virtual produto produto { get; set; }
    }
}
