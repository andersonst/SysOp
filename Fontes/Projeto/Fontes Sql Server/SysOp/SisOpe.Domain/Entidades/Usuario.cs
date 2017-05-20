using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class Usuario
    {
        public Usuario()
        {
            this.acessousuarios = new List<AcessoUsuario>();
            this.historicostatuscotacaos = new List<HistoricoStatusCotacao>();
            this.reservas = new List<Reserva>();
        }

        public int IdUsuario { get; set; }
        public Nullable<long> IdPessoa { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public Nullable<bool> Status { get; set; }
        public virtual ICollection<AcessoUsuario> acessousuarios { get; set; }
        public virtual ICollection<HistoricoStatusCotacao> historicostatuscotacaos { get; set; }
        public virtual Pessoa pessoa { get; set; }
        public virtual ICollection<Reserva> reservas { get; set; }
    }
}
