using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class Ecf_Venda_Cabecalho
    {
        public Ecf_Venda_Cabecalho()
        {
            this.ecf_total_tipo_pgto = new List<Ecf_Total_Tipo_Pgto>();
            this.ecf_venda_detalhe = new List<Ecf_Venda_Detalhe>();
        }

        public long ID { get; set; }
        public Nullable<long> ID_CFOP { get; set; }
        public Nullable<long> ID_ECF_DAV { get; set; }
        public Nullable<long> ID_ECF_PRE_VENDA_CABECALHO { get; set; }
        public Nullable<long> ID_CLIENTE { get; set; }
        public Nullable<long> ID_ECF_FUNCIONARIO { get; set; }
        public long ID_ECF_MOVIMENTO { get; set; }
        public Nullable<long> COO { get; set; }
        public Nullable<long> CCF { get; set; }
        public Nullable<System.DateTime> DATA_HORA_VENDA { get; set; }
        public Nullable<decimal> VALOR_VENDA { get; set; }
        public Nullable<decimal> TAXA_DESCONTO { get; set; }
        public Nullable<decimal> DESCONTO { get; set; }
        public Nullable<decimal> TAXA_ACRESCIMO { get; set; }
        public Nullable<decimal> ACRESCIMO { get; set; }
        public Nullable<decimal> VALOR_FINAL { get; set; }
        public Nullable<decimal> VALOR_RECEBIDO { get; set; }
        public Nullable<decimal> TROCO { get; set; }
        public Nullable<decimal> VALOR_CANCELADO { get; set; }
        public string SINCRONIZADO { get; set; }
        public Nullable<decimal> TOTAL_PRODUTOS { get; set; }
        public Nullable<decimal> TOTAL_DOCUMENTO { get; set; }
        public Nullable<decimal> BASE_ICMS { get; set; }
        public Nullable<decimal> ICMS { get; set; }
        public Nullable<decimal> ICMS_OUTRAS { get; set; }
        public Nullable<decimal> ISSQN { get; set; }
        public Nullable<decimal> PIS { get; set; }
        public Nullable<decimal> COFINS { get; set; }
        public Nullable<decimal> ACRESCIMO_ITENS { get; set; }
        public Nullable<decimal> DESCONTO_ITENS { get; set; }
        public string STATUS_VENDA { get; set; }
        public string NOME_CLIENTE { get; set; }
        public string CPF_CNPJ_CLIENTE { get; set; }
        public virtual Cfop cfop { get; set; }
        public virtual Ecf_Dav_Cabecalho ecf_dav_cabecalho { get; set; }
        public virtual Ecf_Movimento ecf_movimento { get; set; }
        public virtual Ecf_Pre_Venda_Cabecalho ecf_pre_venda_cabecalho { get; set; }
        public virtual ICollection<Ecf_Total_Tipo_Pgto> ecf_total_tipo_pgto { get; set; }
        public virtual Pessoa pessoa { get; set; }
        public virtual Pessoa pessoa1 { get; set; }
        public virtual ICollection<Ecf_Venda_Detalhe> ecf_venda_detalhe { get; set; }
    }
}
