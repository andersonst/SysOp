using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class contato_pjMap : EntityTypeConfiguration<Contato_PJ>
    {
        public contato_pjMap()
        {
            // Primary Key
            this.HasKey(t => t.IdContatoPJ);

            // Properties
            this.Property(t => t.IdContatoPJ)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Nome)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("contato_pj", "sysop");
            this.Property(t => t.IdContatoPJ).HasColumnName("IdContatoPJ");
            this.Property(t => t.IdPessoaJuridica).HasColumnName("IdPessoaJuridica");
            this.Property(t => t.Nome).HasColumnName("Nome");
        }
    }
}
