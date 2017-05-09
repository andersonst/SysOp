using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class Ecf_Movimento
    {
        public Ecf_Movimento()
        {
            this.ecf_documentos_emitidos = new List<Ecf_Documentos_Emitidos>();
            this.ecf_recebimento_nao_fiscal = new List<Ecf_Recebimento_Nao_Fiscal>();
            this.ecf_sangria = new List<Ecf_Sangria>();
            this.ecf_suprimento = new List<Ecf_Suprimento>();
            this.ecf_venda_cabecalho = new List<Ecf_Venda_Cabecalho>();
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
        public virtual Ecf_Caixa ecf_caixa { get; set; }
        public virtual ICollection<Ecf_Documentos_Emitidos> ecf_documentos_emitidos { get; set; }
        public virtual Ecf_Impressora ecf_impressora { get; set; }
        public virtual Ecf_Operador ecf_operador { get; set; }
        public virtual Ecf_Turno ecf_turno { get; set; }
        public virtual ICollection<Ecf_Recebimento_Nao_Fiscal> ecf_recebimento_nao_fiscal { get; set; }
        public virtual ICollection<Ecf_Sangria> ecf_sangria { get; set; }
        public virtual ICollection<Ecf_Suprimento> ecf_suprimento { get; set; }
        public virtual ICollection<Ecf_Venda_Cabecalho> ecf_venda_cabecalho { get; set; }
    }
}
