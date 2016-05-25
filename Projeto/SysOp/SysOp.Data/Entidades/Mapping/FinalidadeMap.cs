using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SysOp.Data.Entidades.Mapping
{
    public class FinalidadeMap : EntityTypeConfiguration<FinalidadeEnt>
    {
        public FinalidadeMap()
        {
            // Primary Key
            this.HasKey(t => t.IdFinalidade);

            // Properties
            this.Property(t => t.Descricao)
                .HasMaxLength(50);

            this.Property(t => t.Status)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("Finalidade");
            this.Property(t => t.IdFinalidade).HasColumnName("IdFinalidade");
            this.Property(t => t.Descricao).HasColumnName("Descricao");
            this.Property(t => t.Status).HasColumnName("Status");
        }
    }
}
