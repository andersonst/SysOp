using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class acessousuarioMap : EntityTypeConfiguration<acessousuario>
    {
        public acessousuarioMap()
        {
            // Primary Key
            this.HasKey(t => t.IdAcessoUsuario);

            // Properties
            // Table & Column Mappings
            this.ToTable("acessousuario", "sysop");
            this.Property(t => t.IdAcessoUsuario).HasColumnName("IdAcessoUsuario");
            this.Property(t => t.IdUsuario).HasColumnName("IdUsuario");
            this.Property(t => t.IdAcesso).HasColumnName("IdAcesso");

            // Relationships
            this.HasOptional(t => t.acesso)
                .WithMany(t => t.acessousuarios)
                .HasForeignKey(d => d.IdAcesso);
            this.HasOptional(t => t.usuario)
                .WithMany(t => t.acessousuarios)
                .HasForeignKey(d => d.IdUsuario);

        }
    }
}
