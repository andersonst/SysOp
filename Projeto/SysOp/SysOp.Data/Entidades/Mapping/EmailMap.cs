using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SysOp.Data.Entidades.Mapping
{
    public class EmailMap : EntityTypeConfiguration<EmailEnt>
    {
        public EmailMap()
        {
            // Primary Key
            this.HasKey(t => t.IdEmail);

            // Properties
            this.Property(t => t.Email1)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Email");
            this.Property(t => t.IdEmail).HasColumnName("IdEmail");
            this.Property(t => t.IdPessoa).HasColumnName("IdPessoa");
            this.Property(t => t.Email1).HasColumnName("Email");

            // Relationships
            this.HasOptional(t => t.Pessoa)
                .WithMany(t => t.Emails)
                .HasForeignKey(d => d.IdPessoa);

        }
    }
}
