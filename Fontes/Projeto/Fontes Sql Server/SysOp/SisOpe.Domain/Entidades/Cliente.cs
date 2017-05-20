using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class Cliente
    {
        public Cliente()
        {
            this.contatoes = new List<Contato>();
        }

        public long ID { get; set; }
        public long ID_SITUACAO_CLI { get; set; }
        public string NOME { get; set; }
        public string CPF_CNPJ { get; set; }
        public string RG { get; set; }
        public string ORGAO_RG { get; set; }
        public string INSCRICAO_ESTADUAL { get; set; }
        public string INSCRICAO_MUNICIPAL { get; set; }
        public Nullable<System.DateTime> DESDE { get; set; }
        public string TIPO_PESSOA { get; set; }
        public string EXCLUIDO { get; set; }
        public Nullable<System.DateTime> DATA_CADASTRO { get; set; }
        public virtual Situacao_cli situacao_cli { get; set; }
        public virtual ICollection<Contato> contatoes { get; set; }
    }
}
