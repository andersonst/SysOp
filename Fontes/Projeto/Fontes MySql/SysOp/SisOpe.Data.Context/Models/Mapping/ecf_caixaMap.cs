using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class Ecf_CaixaMap : EntityTypeConfiguration<Ecf_Caixa>
    {
        public Ecf_CaixaMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.NOME)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("ecf_caixa", "sysop");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.NOME).HasColumnName("NOME");
            this.Property(t => t.DATA_CADASTRO).HasColumnName("DATA_CADASTRO");
        }
    }
}
