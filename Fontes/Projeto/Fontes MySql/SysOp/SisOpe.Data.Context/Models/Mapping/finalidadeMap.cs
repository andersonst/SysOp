using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class finalidadeMap : EntityTypeConfiguration<Finalidade>
    {
        public finalidadeMap()
        {
            // Primary Key
            this.HasKey(t => t.IdFinalidade);

            // Properties
            this.Property(t => t.Descricao)
                .HasMaxLength(50);

            this.Property(t => t.Status)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("finalidade", "sysop");
            this.Property(t => t.IdFinalidade).HasColumnName("IdFinalidade");
            this.Property(t => t.Descricao).HasColumnName("Descricao");
            this.Property(t => t.Status).HasColumnName("Status");
        }
    }
}
