using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class Ecf_Empresa
    {
        public Ecf_Empresa()
        {
            this.ecf_configuracao = new List<Ecf_Configuracao>();
            this.ecf_contador = new List<Ecf_Contador>();
            this.ecf_empresa1 = new List<Ecf_Empresa>();
        }

        public long ID { get; set; }
        public long ID_EMPRESA { get; set; }
        public string RAZAO_SOCIAL { get; set; }
        public string NOME_FANTASIA { get; set; }
        public string CNPJ { get; set; }
        public string INSCRICAO_ESTADUAL { get; set; }
        public string INSCRICAO_MUNICIPAL { get; set; }
        public string MATRIZ_FILIAL { get; set; }
        public Nullable<System.DateTime> DATA_CADASTRO { get; set; }
        public string ENDERECO { get; set; }
        public string COMPLEMENTO { get; set; }
        public string BAIRRO { get; set; }
        public string CIDADE { get; set; }
        public Nullable<int> CODIGO_MUNICIPIO_IBGE { get; set; }
        public string UF { get; set; }
        public string CEP { get; set; }
        public string FONE1 { get; set; }
        public string FONE2 { get; set; }
        public string CONTATO { get; set; }
        public virtual ICollection<Ecf_Configuracao> ecf_configuracao { get; set; }
        public virtual ICollection<Ecf_Contador> ecf_contador { get; set; }
        public virtual ICollection<Ecf_Empresa> ecf_empresa1 { get; set; }
        public virtual Ecf_Empresa ecf_empresa2 { get; set; }
    }
}
