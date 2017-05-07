using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class HistoricoStatusCotacaoMap : EntityTypeConfiguration<HistoricoStatusCotacao>
    {
        public HistoricoStatusCotacaoMap()
        {
            // Primary Key
            this.HasKey(t => t.IdHistoricoStatusCotacao);

            // Properties
            this.Property(t => t.DataStatus)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("historicostatuscotacao", "sysop");
            this.Property(t => t.IdHistoricoStatusCotacao).HasColumnName("IdHistoricoStatusCotacao");
            this.Property(t => t.IdCotacao).HasColumnName("IdCotacao");
            this.Property(t => t.IdStatusCotacao).HasColumnName("IdStatusCotacao");
            this.Property(t => t.DataStatus).HasColumnName("DataStatus");
            this.Property(t => t.IdUsuario).HasColumnName("IdUsuario");

            // Relationships
            this.HasOptional(t => t.cotacao)
                .WithMany(t => t.historicostatuscotacaos)
                .HasForeignKey(d => d.IdCotacao);
            this.HasOptional(t => t.statuscotacao)
                .WithMany(t => t.historicostatuscotacaos)
                .HasForeignKey(d => d.IdStatusCotacao);
            this.HasOptional(t => t.usuario)
                .WithMany(t => t.historicostatuscotacaos)
                .HasForeignKey(d => d.IdUsuario);

        }
    }
}
