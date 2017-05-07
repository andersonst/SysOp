using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class Reserva
    {
        public int IdReserva { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
        public string Status { get; set; }
        public Nullable<int> IdUsuario { get; set; }
        public Nullable<int> IdUnidade { get; set; }
        public virtual Unidade unidade { get; set; }
        public virtual Usuario usuario { get; set; }
    }
}
