using SisOpe.Domain.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class Ficha_TecnicaMap : EntityTypeConfiguration<Ficha_Tecnica>
    {
        public Ficha_TecnicaMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.DESCRICAO)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ficha_tecnica", "sysop");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ID_PRODUTO).HasColumnName("ID_PRODUTO");
            this.Property(t => t.DESCRICAO).HasColumnName("DESCRICAO");
            this.Property(t => t.ID_PRODUTO_FILHO).HasColumnName("ID_PRODUTO_FILHO");
            this.Property(t => t.QUANTIDADE).HasColumnName("QUANTIDADE");

            // Relationships
            this.HasRequired(t => t.produto)
                .WithMany(t => t.ficha_tecnica)
                .HasForeignKey(d => d.ID_PRODUTO);

        }
    }
}
