using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class acessoMap : EntityTypeConfiguration<acesso>
    {
        public acessoMap()
        {
            // Primary Key
            this.HasKey(t => t.IdAcesso);

            // Properties
            this.Property(t => t.Descricao)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("acesso", "sysop");
            this.Property(t => t.IdAcesso).HasColumnName("IdAcesso");
            this.Property(t => t.Descricao).HasColumnName("Descricao");
        }
    }
}
