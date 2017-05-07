using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
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
            this.ToTable("cotacao", "sysop");
            this.Property(t => t.IdCotacao).HasColumnName("IdCotacao");
            this.Property(t => t.Descricao).HasColumnName("Descricao");
            this.Property(t => t.DataInicio).HasColumnName("DataInicio");
            this.Property(t => t.DataFim).HasColumnName("DataFim");
            this.Property(t => t.IdStatusCotacao).HasColumnName("IdStatusCotacao");

            // Relationships
            this.HasOptional(t => t.statuscotacao)
                .WithMany(t => t.cotacaos)
                .HasForeignKey(d => d.IdStatusCotacao);

        }
    }
}
