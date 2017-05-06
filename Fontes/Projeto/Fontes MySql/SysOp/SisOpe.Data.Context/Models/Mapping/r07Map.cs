using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class r07Map : EntityTypeConfiguration<r07>
    {
        public r07Map()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.MEIO_PAGAMENTO)
                .HasMaxLength(20);

            this.Property(t => t.ESTORNO)
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("r07", "sysop");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ID_R06).HasColumnName("ID_R06");
            this.Property(t => t.ID_R02).HasColumnName("ID_R02");
            this.Property(t => t.CCF).HasColumnName("CCF");
            this.Property(t => t.MEIO_PAGAMENTO).HasColumnName("MEIO_PAGAMENTO");
            this.Property(t => t.VALOR_PAGAMENTO).HasColumnName("VALOR_PAGAMENTO");
            this.Property(t => t.ESTORNO).HasColumnName("ESTORNO");
            this.Property(t => t.VALOR_ESTORNO).HasColumnName("VALOR_ESTORNO");

            // Relationships
            this.HasOptional(t => t.r02)
                .WithMany(t => t.r07)
                .HasForeignKey(d => d.ID_R02);
            this.HasOptional(t => t.r06)
                .WithMany(t => t.r07)
                .HasForeignKey(d => d.ID_R06);

        }
    }
}
