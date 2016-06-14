using SisOpe.Domain.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Mapping
{
    public class CotacaoMap : EntityTypeConfiguration<Cotacao>
    {
        public CotacaoMap()
        {
            // Primary Key
            this.HasKey(t => t.IdCotacao);

            // Properties
            this.Property(t => t.Descricao)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Cotacao");
            this.Property(t => t.IdCotacao).HasColumnName("IdCotacao");
            this.Property(t => t.Descricao).HasColumnName("Descricao");
            this.Property(t => t.DataInicio).HasColumnName("DataInicio");
            this.Property(t => t.DataFim).HasColumnName("DataFim");
            this.Property(t => t.IdStatusCotacao).HasColumnName("IdStatusCotacao");

            // Relationships
            this.HasOptional(t => t.StatusCotacao)
                .WithMany(t => t.Cotacaos)
                .HasForeignKey(d => d.IdStatusCotacao);

        }
    }
}
