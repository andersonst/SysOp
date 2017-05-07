using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class cfopMap : EntityTypeConfiguration<Cfop>
    {
        public cfopMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.DESCRICAO)
                .HasMaxLength(1073741823);

            this.Property(t => t.APLICACAO)
                .HasMaxLength(1073741823);

            // Table & Column Mappings
            this.ToTable("cfop", "sysop");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.CFOP1).HasColumnName("CFOP");
            this.Property(t => t.DESCRICAO).HasColumnName("DESCRICAO");
            this.Property(t => t.APLICACAO).HasColumnName("APLICACAO");
        }
    }
}
