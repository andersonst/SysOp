using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SysOp.Data.Entidades.Mapping
{
    public class HistoricoStatusCotacaoMap : EntityTypeConfiguration<HistoricoStatusCotacaoEnt>
    {
        public HistoricoStatusCotacaoMap()
        {
            // Primary Key
            this.HasKey(t => t.IdHistoricoStatusCotacao);

            // Properties
            this.Property(t => t.DataStatus)
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("HistoricoStatusCotacao");
            this.Property(t => t.IdHistoricoStatusCotacao).HasColumnName("IdHistoricoStatusCotacao");
            this.Property(t => t.IdCotacao).HasColumnName("IdCotacao");
            this.Property(t => t.IdStatusCotacao).HasColumnName("IdStatusCotacao");
            this.Property(t => t.DataStatus).HasColumnName("DataStatus");
            this.Property(t => t.IdUsuario).HasColumnName("IdUsuario");

            // Relationships
            this.HasOptional(t => t.Cotacao)
                .WithMany(t => t.HistoricoStatusCotacaos)
                .HasForeignKey(d => d.IdCotacao);
            this.HasOptional(t => t.StatusCotacao)
                .WithMany(t => t.HistoricoStatusCotacaos)
                .HasForeignKey(d => d.IdStatusCotacao);
            this.HasOptional(t => t.Usuario)
                .WithMany(t => t.HistoricoStatusCotacaos)
                .HasForeignKey(d => d.IdUsuario);

        }
    }
}
