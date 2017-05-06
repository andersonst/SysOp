using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class emailMap : EntityTypeConfiguration<email>
    {
        public emailMap()
        {
            // Primary Key
            this.HasKey(t => t.IdEmail);

            // Properties
            this.Property(t => t.Email1)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("email", "sysop");
            this.Property(t => t.IdEmail).HasColumnName("IdEmail");
            this.Property(t => t.IdPessoa).HasColumnName("IdPessoa");
            this.Property(t => t.Email1).HasColumnName("Email");

            // Relationships
            this.HasOptional(t => t.pessoa)
                .WithMany(t => t.emails)
                .HasForeignKey(d => d.IdPessoa);

        }
    }
}
