using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class Sintegra_60a
    {
        public long ID { get; set; }
        public long ID_SINTEGRA_60M { get; set; }
        public string SITUACAO_TRIBUTARIA { get; set; }
        public Nullable<decimal> VALOR { get; set; }
    }
}
