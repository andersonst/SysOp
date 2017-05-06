using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class unidade
    {
        public unidade()
        {
            this.itemestoques = new List<itemestoque>();
            this.itemtransferenciaestoques = new List<itemtransferenciaestoque>();
            this.itemtransferenciaestoques1 = new List<itemtransferenciaestoque>();
            this.reservas = new List<reserva>();
            this.vendaprodutoes = new List<vendaproduto>();
        }

        public int IdUnidade { get; set; }
        public Nullable<int> IdPessoaJuridica { get; set; }
        public Nullable<int> IdMatriz { get; set; }
        public virtual ICollection<itemestoque> itemestoques { get; set; }
        public virtual ICollection<itemtransferenciaestoque> itemtransferenciaestoques { get; set; }
        public virtual ICollection<itemtransferenciaestoque> itemtransferenciaestoques1 { get; set; }
        public virtual ICollection<reserva> reservas { get; set; }
        public virtual ICollection<vendaproduto> vendaprodutoes { get; set; }
    }
}
