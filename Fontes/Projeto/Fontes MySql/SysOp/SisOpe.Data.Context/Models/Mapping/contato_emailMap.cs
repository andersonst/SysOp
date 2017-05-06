using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class contato_emailMap : EntityTypeConfiguration<contato_email>
    {
        public contato_emailMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.EMAIL)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("contato_email", "sysop");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ID_CONTATO).HasColumnName("ID_CONTATO");
            this.Property(t => t.ID_TIPO_EMAIL).HasColumnName("ID_TIPO_EMAIL");
            this.Property(t => t.EMAIL).HasColumnName("EMAIL");

            // Relationships
            this.HasRequired(t => t.contato)
                .WithMany(t => t.contato_email)
                .HasForeignKey(d => d.ID_CONTATO);
            this.HasRequired(t => t.tipo_email)
                .WithMany(t => t.contato_email)
                .HasForeignKey(d => d.ID_TIPO_EMAIL);

        }
    }
}
