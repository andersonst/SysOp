using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class endereco
    {
        public long ID { get; set; }
        public long ID_PESSOA { get; set; }
        public string LOGRADOURO { get; set; }
        public Nullable<long> NUMERO { get; set; }
        public string COMPLEMENTO { get; set; }
        public string BAIRRO { get; set; }
        public string CEP { get; set; }
        public virtual pessoa pessoa { get; set; }
    }
}
