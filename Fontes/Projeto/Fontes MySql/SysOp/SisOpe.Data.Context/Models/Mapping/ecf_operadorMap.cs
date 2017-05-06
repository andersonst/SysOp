using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class ecf_operadorMap : EntityTypeConfiguration<ecf_operador>
    {
        public ecf_operadorMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.SENHA)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("ecf_operador", "sysop");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ID_ECF_FUNCIONARIO).HasColumnName("ID_ECF_FUNCIONARIO");
            this.Property(t => t.LOGIN).HasColumnName("LOGIN");
            this.Property(t => t.SENHA).HasColumnName("SENHA");

            // Relationships
            this.HasRequired(t => t.pessoa)
                .WithMany(t => t.ecf_operador)
                .HasForeignKey(d => d.ID_ECF_FUNCIONARIO);

        }
    }
}
