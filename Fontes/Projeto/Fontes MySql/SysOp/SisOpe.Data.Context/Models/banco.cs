using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class banco
    {
        public banco()
        {
            this.ecf_cheque_cliente = new List<ecf_cheque_cliente>();
        }

        public long ID { get; set; }
        public Nullable<long> CODIGO { get; set; }
        public string NOME { get; set; }
        public string URL { get; set; }
        public virtual ICollection<ecf_cheque_cliente> ecf_cheque_cliente { get; set; }
    }
}
