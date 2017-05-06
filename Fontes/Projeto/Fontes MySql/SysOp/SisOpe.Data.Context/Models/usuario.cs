using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class usuario
    {
        public usuario()
        {
            this.acessousuarios = new List<acessousuario>();
            this.historicostatuscotacaos = new List<historicostatuscotacao>();
            this.reservas = new List<reserva>();
        }

        public int IdUsuario { get; set; }
        public Nullable<long> IdPessoa { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public Nullable<bool> Status { get; set; }
        public virtual ICollection<acessousuario> acessousuarios { get; set; }
        public virtual ICollection<historicostatuscotacao> historicostatuscotacaos { get; set; }
        public virtual pessoa pessoa { get; set; }
        public virtual ICollection<reserva> reservas { get; set; }
    }
}
