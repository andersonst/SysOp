using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class reserva
    {
        public int IdReserva { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
        public string Status { get; set; }
        public Nullable<int> IdUsuario { get; set; }
        public Nullable<int> IdUnidade { get; set; }
        public virtual unidade unidade { get; set; }
        public virtual usuario usuario { get; set; }
    }
}
