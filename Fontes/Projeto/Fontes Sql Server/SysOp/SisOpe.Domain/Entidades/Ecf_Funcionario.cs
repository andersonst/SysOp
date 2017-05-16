using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class Ecf_Funcionario
    {
        public long ID { get; set; }
        public string NOME { get; set; }
        public string TELEFONE { get; set; }
        public string CELULAR { get; set; }
        public string EMAIL { get; set; }
        public Nullable<decimal> COMISSAO_VISTA { get; set; }
        public Nullable<decimal> COMISSAO_PRAZO { get; set; }
        public string NIVEL_AUTORIZACAO { get; set; }
    }
}
