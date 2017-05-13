using SisOpe.Domain.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class ReservaMap : EntityTypeConfiguration<Reserva>
    {
        public ReservaMap()
        {
            // Primary Key
            this.HasKey(t => t.IdReserva);

            // Properties
            this.Property(t => t.Status)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("reserva", "sysop");
            this.Property(t => t.IdReserva).HasColumnName("IdReserva");
            this.Property(t => t.Data).HasColumnName("Data");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.IdUsuario).HasColumnName("IdUsuario");
            this.Property(t => t.IdUnidade).HasColumnName("IdUnidade");

            // Relationships
            this.HasOptional(t => t.unidade)
                .WithMany(t => t.reservas)
                .HasForeignKey(d => d.IdUnidade);
            this.HasOptional(t => t.usuario)
                .WithMany(t => t.reservas)
                .HasForeignKey(d => d.IdUsuario);

        }
    }
}
