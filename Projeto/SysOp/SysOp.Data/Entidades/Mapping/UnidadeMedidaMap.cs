using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SysOp.Data.Entidades.Mapping
{
    public class UnidadeMedidaMap : EntityTypeConfiguration<UnidadeMedidaEnt>
    {
        public UnidadeMedidaMap()
        {
            // Primary Key
            this.HasKey(t => t.IdUnidadeMedida);

            // Properties
            this.Property(t => t.Descricao)
                .HasMaxLength(50);

            this.Property(t => t.Status)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("UnidadeMedida");
            this.Property(t => t.IdUnidadeMedida).HasColumnName("IdUnidadeMedida");
            this.Property(t => t.Descricao).HasColumnName("Descricao");
            this.Property(t => t.Status).HasColumnName("Status");
        }
    }
}
