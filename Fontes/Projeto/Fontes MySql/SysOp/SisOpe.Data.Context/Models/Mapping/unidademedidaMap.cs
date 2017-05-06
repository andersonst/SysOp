using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class unidademedidaMap : EntityTypeConfiguration<unidademedida>
    {
        public unidademedidaMap()
        {
            // Primary Key
            this.HasKey(t => t.IdUnidadeMedida);

            // Properties
            this.Property(t => t.Descricao)
                .HasMaxLength(50);

            this.Property(t => t.Status)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("unidademedida", "sysop");
            this.Property(t => t.IdUnidadeMedida).HasColumnName("IdUnidadeMedida");
            this.Property(t => t.Descricao).HasColumnName("Descricao");
            this.Property(t => t.Status).HasColumnName("Status");
        }
    }
}
