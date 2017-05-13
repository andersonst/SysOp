using SisOpe.Domain.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class R03Map : EntityTypeConfiguration<R03>
    {
        public R03Map()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.TOTALIZADOR_PARCIAL)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("r03", "sysop");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ID_R02).HasColumnName("ID_R02");
            this.Property(t => t.TOTALIZADOR_PARCIAL).HasColumnName("TOTALIZADOR_PARCIAL");
            this.Property(t => t.VALOR_ACUMULADO).HasColumnName("VALOR_ACUMULADO");

            // Relationships
            this.HasRequired(t => t.r02)
                .WithMany(t => t.r03)
                .HasForeignKey(d => d.ID_R02);

        }
    }
}
