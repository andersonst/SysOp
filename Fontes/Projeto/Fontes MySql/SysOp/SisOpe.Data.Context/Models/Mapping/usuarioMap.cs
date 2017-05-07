using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class usuarioMap : EntityTypeConfiguration<Usuario>
    {
        public usuarioMap()
        {
            // Primary Key
            this.HasKey(t => t.IdUsuario);

            // Properties
            this.Property(t => t.Login)
                .HasMaxLength(20);

            this.Property(t => t.Senha)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("usuario", "sysop");
            this.Property(t => t.IdUsuario).HasColumnName("IdUsuario");
            this.Property(t => t.IdPessoa).HasColumnName("IdPessoa");
            this.Property(t => t.Login).HasColumnName("Login");
            this.Property(t => t.Senha).HasColumnName("Senha");
            this.Property(t => t.Status).HasColumnName("Status");

            // Relationships
            this.HasOptional(t => t.pessoa)
                .WithMany(t => t.usuarios)
                .HasForeignKey(d => d.IdPessoa);

        }
    }
}
