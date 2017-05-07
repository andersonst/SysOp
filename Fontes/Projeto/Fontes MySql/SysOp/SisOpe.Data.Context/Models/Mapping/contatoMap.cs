using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class ContatoMap : EntityTypeConfiguration<Contato>
    {
        public ContatoMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.NOME)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("contato", "sysop");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ID_CLIENTE).HasColumnName("ID_CLIENTE");
            this.Property(t => t.NOME).HasColumnName("NOME");

            // Relationships
            this.HasRequired(t => t.cliente)
                .WithMany(t => t.contatoes)
                .HasForeignKey(d => d.ID_CLIENTE);

        }
    }
}
