using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class situacao_cliMap : EntityTypeConfiguration<Situacao_cli>
    {
        public situacao_cliMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.NOME)
                .HasMaxLength(20);

            this.Property(t => t.DESCRICAO)
                .HasMaxLength(1073741823);

            // Table & Column Mappings
            this.ToTable("situacao_cli", "sysop");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.NOME).HasColumnName("NOME");
            this.Property(t => t.DESCRICAO).HasColumnName("DESCRICAO");
        }
    }
}
