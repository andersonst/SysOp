using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class transferenciaestoque
    {
        public transferenciaestoque()
        {
            this.itemtransferenciaestoques = new List<itemtransferenciaestoque>();
        }

        public int IdTE { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> DataSeparacao { get; set; }
        public Nullable<System.DateTime> DataAtual { get; set; }
        public Nullable<int> IdOperador { get; set; }
        public virtual ICollection<itemtransferenciaestoque> itemtransferenciaestoques { get; set; }
    }
}
