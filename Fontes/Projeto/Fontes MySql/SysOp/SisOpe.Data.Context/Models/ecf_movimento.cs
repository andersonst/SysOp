using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class ecf_movimento
    {
        public ecf_movimento()
        {
            this.ecf_documentos_emitidos = new List<ecf_documentos_emitidos>();
            this.ecf_recebimento_nao_fiscal = new List<ecf_recebimento_nao_fiscal>();
            this.ecf_sangria = new List<ecf_sangria>();
            this.ecf_suprimento = new List<ecf_suprimento>();
            this.ecf_venda_cabecalho = new List<ecf_venda_cabecalho>();
        }

        public long ID { get; set; }
        public long ID_ECF_TURNO { get; set; }
        public long ID_ECF_IMPRESSORA { get; set; }
        public long ID_ECF_OPERADOR { get; set; }
        public long ID_ECF_CAIXA { get; set; }
        public Nullable<int> ID_GERENTE_SUPERVISOR { get; set; }
        public Nullable<System.DateTime> DATA_HORA_ABERTURA { get; set; }
        public Nullable<System.DateTime> DATA_HORA_FECHAMENTO { get; set; }
        public Nullable<decimal> TOTAL_SUPRIMENTO { get; set; }
        public Nullable<decimal> TOTAL_SANGRIA { get; set; }
        public Nullable<decimal> TOTAL_NAO_FISCAL { get; set; }
        public Nullable<decimal> TOTAL_VENDA { get; set; }
        public Nullable<decimal> TOTAL_DESCONTO { get; set; }
        public Nullable<decimal> TOTAL_ACRESCIMO { get; set; }
        public Nullable<decimal> TOTAL_FINAL { get; set; }
        public Nullable<decimal> TOTAL_RECEBIDO { get; set; }
        public Nullable<decimal> TOTAL_TROCO { get; set; }
        public Nullable<decimal> TOTAL_CANCELADO { get; set; }
        public string STATUS_MOVIMENTO { get; set; }
        public string SINCRONIZADO { get; set; }
        public virtual ecf_caixa ecf_caixa { get; set; }
        public virtual ICollection<ecf_documentos_emitidos> ecf_documentos_emitidos { get; set; }
        public virtual ecf_impressora ecf_impressora { get; set; }
        public virtual ecf_operador ecf_operador { get; set; }
        public virtual ecf_turno ecf_turno { get; set; }
        public virtual ICollection<ecf_recebimento_nao_fiscal> ecf_recebimento_nao_fiscal { get; set; }
        public virtual ICollection<ecf_sangria> ecf_sangria { get; set; }
        public virtual ICollection<ecf_suprimento> ecf_suprimento { get; set; }
        public virtual ICollection<ecf_venda_cabecalho> ecf_venda_cabecalho { get; set; }
    }
}
