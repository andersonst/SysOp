using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class contato_telefoneMap : EntityTypeConfiguration<contato_telefone>
    {
        public contato_telefoneMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.TELEFONE)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("contato_telefone", "sysop");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ID_CONTATO).HasColumnName("ID_CONTATO");
            this.Property(t => t.ID_TIPO_TELEFONE).HasColumnName("ID_TIPO_TELEFONE");
            this.Property(t => t.TELEFONE).HasColumnName("TELEFONE");

            // Relationships
            this.HasRequired(t => t.contato)
                .WithMany(t => t.contato_telefone)
                .HasForeignKey(d => d.ID_CONTATO);
            this.HasRequired(t => t.tipo_telefone)
                .WithMany(t => t.contato_telefone)
                .HasForeignKey(d => d.ID_TIPO_TELEFONE);

        }
    }
}
