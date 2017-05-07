using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class TransferenciaEstoque
    {
        public TransferenciaEstoque()
        {
            this.itemtransferenciaestoques = new List<ItemTransferenciaEstoque>();
        }

        public int IdTE { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> DataSeparacao { get; set; }
        public Nullable<System.DateTime> DataAtual { get; set; }
        public Nullable<int> IdOperador { get; set; }
        public virtual ICollection<ItemTransferenciaEstoque> itemtransferenciaestoques { get; set; }
    }
}
