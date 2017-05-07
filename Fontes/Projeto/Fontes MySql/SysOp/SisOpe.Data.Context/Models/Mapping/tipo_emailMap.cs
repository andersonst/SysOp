using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class tipo_emailMap : EntityTypeConfiguration<Tipo_Email>
    {
        public tipo_emailMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.NOME)
                .HasMaxLength(20);

            this.Property(t => t.DESCRICAO)
                .HasMaxLength(1073741823);

            // Table & Column Mappings
            this.ToTable("tipo_email", "sysop");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.NOME).HasColumnName("NOME");
            this.Property(t => t.DESCRICAO).HasColumnName("DESCRICAO");
        }
    }
}
