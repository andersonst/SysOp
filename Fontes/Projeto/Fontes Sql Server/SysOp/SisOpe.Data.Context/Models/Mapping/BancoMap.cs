using SisOpe.Domain.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class BancoMap : EntityTypeConfiguration<Banco>
    {
        public BancoMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.NOME)
                .HasMaxLength(100);

            this.Property(t => t.URL)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("banco", "sysop");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.CODIGO).HasColumnName("CODIGO");
            this.Property(t => t.NOME).HasColumnName("NOME");
            this.Property(t => t.URL).HasColumnName("URL");
        }
    }
}
