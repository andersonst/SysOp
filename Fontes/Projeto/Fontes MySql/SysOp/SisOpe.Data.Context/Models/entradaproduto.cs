using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class entradaproduto
    {
        public entradaproduto()
        {
            this.entradaprodutonfs = new List<entradaprodutonf>();
            this.itementradaestoques = new List<itementradaestoque>();
        }

        public int IdEntradaProduto { get; set; }
        public Nullable<System.DateTime> DataEntrada { get; set; }
        public Nullable<int> IdUsuario { get; set; }
        public virtual ICollection<entradaprodutonf> entradaprodutonfs { get; set; }
        public virtual ICollection<itementradaestoque> itementradaestoques { get; set; }
    }
}
