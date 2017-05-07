using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class transferenciaestoqueMap : EntityTypeConfiguration<TransferenciaEstoque>
    {
        public transferenciaestoqueMap()
        {
            // Primary Key
            this.HasKey(t => t.IdTE);

            // Properties
            this.Property(t => t.Status)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("transferenciaestoque", "sysop");
            this.Property(t => t.IdTE).HasColumnName("IdTE");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.DataSeparacao).HasColumnName("DataSeparacao");
            this.Property(t => t.DataAtual).HasColumnName("DataAtual");
            this.Property(t => t.IdOperador).HasColumnName("IdOperador");
        }
    }
}
