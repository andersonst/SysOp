using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class Sintegra_60m
    {
        public long ID { get; set; }
        public Nullable<System.DateTime> DATA_EMISSAO { get; set; }
        public string NUMERO_SERIE_ECF { get; set; }
        public Nullable<long> NUMERO_EQUIPAMENTO { get; set; }
        public string MODELO_DOCUMENTO_FISCAL { get; set; }
        public Nullable<long> COO_INICIAL { get; set; }
        public Nullable<long> COO_FINAL { get; set; }
        public Nullable<long> CRZ { get; set; }
        public Nullable<long> CRO { get; set; }
        public Nullable<decimal> VALOR_VENDA_BRUTA { get; set; }
        public Nullable<decimal> VALOR_GRANDE_TOTAL { get; set; }
    }
}
