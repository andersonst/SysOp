using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SysOp.Data.Entidades.Mapping
{
    public class AcessoUsuarioMap : EntityTypeConfiguration<AcessoUsuarioEnt>
    {
        public AcessoUsuarioMap()
        {
            // Primary Key
            this.HasKey(t => t.IdAcessoUsuario);

            // Properties
            // Table & Column Mappings
            this.ToTable("AcessoUsuario");
            this.Property(t => t.IdAcessoUsuario).HasColumnName("IdAcessoUsuario");
            this.Property(t => t.IdUsuario).HasColumnName("IdUsuario");
            this.Property(t => t.IdAcesso).HasColumnName("IdAcesso");

            // Relationships
            this.HasOptional(t => t.Acesso)
                .WithMany(t => t.AcessoUsuarios)
                .HasForeignKey(d => d.IdAcesso);
            this.HasOptional(t => t.Usuario)
                .WithMany(t => t.AcessoUsuarios)
                .HasForeignKey(d => d.IdUsuario);

        }
    }
}
