using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class Ecf_Contador
    {
        public long ID { get; set; }
        public long ID_ECF_EMPRESA { get; set; }
        public string CPF { get; set; }
        public string CNPJ { get; set; }
        public string NOME { get; set; }
        public string INSCRICAO_CRC { get; set; }
        public string FONE { get; set; }
        public string FAX { get; set; }
        public string LOGRADOURO { get; set; }
        public Nullable<long> NUMERO { get; set; }
        public string COMPLEMENTO { get; set; }
        public string BAIRRO { get; set; }
        public string CEP { get; set; }
        public Nullable<long> CODIGO_MUNICIPIO { get; set; }
        public string UF { get; set; }
        public string EMAIL { get; set; }
        public virtual Ecf_Empresa ecf_empresa { get; set; }
    }
}
