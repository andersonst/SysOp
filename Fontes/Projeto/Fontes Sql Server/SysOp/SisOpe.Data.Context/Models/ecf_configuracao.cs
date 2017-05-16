using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class Ecf_Configuracao
    {
        public long ID { get; set; }
        public Nullable<int> ID_ECF_IMPRESSORA { get; set; }
        public long ID_ECF_RESOLUCAO { get; set; }
        public long ID_ECF_CAIXA { get; set; }
        public long ID_ECF_EMPRESA { get; set; }
        public string MENSAGEM_CUPOM { get; set; }
        public string PORTA_ECF { get; set; }
        public string PORTA_PINPAD { get; set; }
        public string PORTA_BALANCA { get; set; }
        public string IP_SERVIDOR { get; set; }
        public string IP_SITEF { get; set; }
        public string TIPO_TEF { get; set; }
        public string TITULO_TELA_CAIXA { get; set; }
        public string CAMINHO_IMAGENS_PRODUTOS { get; set; }
        public string CAMINHO_IMAGENS_MARKETING { get; set; }
        public string CAMINHO_IMAGENS_LAYOUT { get; set; }
        public string COR_JANELAS_INTERNAS { get; set; }
        public string MARKETING_ATIVO { get; set; }
        public Nullable<int> CFOP_ECF { get; set; }
        public Nullable<int> CFOP_NF2 { get; set; }
        public Nullable<int> TIMEOUT_ECF { get; set; }
        public Nullable<int> INTERVALO_ECF { get; set; }
        public string DESCRICAO_SUPRIMENTO { get; set; }
        public string DESCRICAO_SANGRIA { get; set; }
        public Nullable<int> TEF_TIPO_GP { get; set; }
        public Nullable<int> TEF_TEMPO_ESPERA { get; set; }
        public Nullable<int> TEF_ESPERA_STS { get; set; }
        public Nullable<int> TEF_NUMERO_VIAS { get; set; }
        public Nullable<int> INDICE_GERENCIAL_DAV { get; set; }
        public string SINCRONIZADO { get; set; }
        public virtual Ecf_Caixa ecf_caixa { get; set; }
        public virtual Ecf_Empresa ecf_empresa { get; set; }
        public virtual Ecf_Resolucao ecf_resolucao { get; set; }
    }
}
