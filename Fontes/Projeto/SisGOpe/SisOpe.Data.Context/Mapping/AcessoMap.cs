using SisOpe.Domain.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Mapping
{
    public class AcessoMap : EntityTypeConfiguration<Acesso>
    {
        public AcessoMap()
        {
            // Primary Key
            this.HasKey(t => t.IdAcesso);

            // Properties
            this.Property(t => t.Descricao)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Acesso");
            this.Property(t => t.IdAcesso).HasColumnName("IdAcesso");
            this.Property(t => t.Descricao).HasColumnName("Descricao");
        }
    }
}
