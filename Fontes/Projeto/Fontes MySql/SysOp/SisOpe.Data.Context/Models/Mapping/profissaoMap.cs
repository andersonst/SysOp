using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class ProfissaoMap : EntityTypeConfiguration<Profissao>
    {
        public ProfissaoMap()
        {
            // Primary Key
            this.HasKey(t => t.IdProfissoes);

            // Properties
            this.Property(t => t.Nome)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("profissao", "sysop");
            this.Property(t => t.IdProfissoes).HasColumnName("IdProfissoes");
            this.Property(t => t.Nome).HasColumnName("Nome");
            this.Property(t => t.Status).HasColumnName("Status");
        }
    }
}
