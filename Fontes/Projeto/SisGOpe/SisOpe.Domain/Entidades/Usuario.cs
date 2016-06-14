using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class Usuario
    {
        public Usuario()
        {
            this.AcessoUsuarios = new List<AcessoUsuario>();
            this.HistoricoStatusCotacaos = new List<HistoricoStatusCotacao>();
            this.Reservas = new List<Reserva>();
        }

        public int IdUsuario { get; set; }
        public Nullable<int> IdPessoa { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public Nullable<bool> Status { get; set; }
        public virtual ICollection<AcessoUsuario> AcessoUsuarios { get; set; }
        public virtual ICollection<HistoricoStatusCotacao> HistoricoStatusCotacaos { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public virtual ICollection<Reserva> Reservas { get; set; }
    }
}
