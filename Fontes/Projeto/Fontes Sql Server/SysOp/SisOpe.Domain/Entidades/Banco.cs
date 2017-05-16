using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class Banco
    {
        public Banco()
        {
            this.ecf_cheque_cliente = new List<Ecf_Cheque_Cliente>();
        }

        public long ID { get; set; }
        public Nullable<long> CODIGO { get; set; }
        public string NOME { get; set; }
        public string URL { get; set; }
        public virtual ICollection<Ecf_Cheque_Cliente> ecf_cheque_cliente { get; set; }
    }
}
