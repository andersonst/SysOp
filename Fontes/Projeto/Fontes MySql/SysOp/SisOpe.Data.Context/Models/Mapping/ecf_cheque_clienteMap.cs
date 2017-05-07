using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class Ecf_Cheque_ClienteMap : EntityTypeConfiguration<Ecf_Cheque_Cliente>
    {
        public Ecf_Cheque_ClienteMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.OBSERVACOES)
                .HasMaxLength(1073741823);

            // Table & Column Mappings
            this.ToTable("ecf_cheque_cliente", "sysop");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ID_BANCO).HasColumnName("ID_BANCO");
            this.Property(t => t.ID_PESSOA).HasColumnName("ID_PESSOA");
            this.Property(t => t.NUMERO_CHEQUE).HasColumnName("NUMERO_CHEQUE");
            this.Property(t => t.DATA_CHEQUE).HasColumnName("DATA_CHEQUE");
            this.Property(t => t.VALOR_CHEQUE).HasColumnName("VALOR_CHEQUE");
            this.Property(t => t.OBSERVACOES).HasColumnName("OBSERVACOES");

            // Relationships
            this.HasRequired(t => t.banco)
                .WithMany(t => t.ecf_cheque_cliente)
                .HasForeignKey(d => d.ID_BANCO);
            this.HasRequired(t => t.pessoa)
                .WithMany(t => t.ecf_cheque_cliente)
                .HasForeignKey(d => d.ID_PESSOA);

        }
    }
}
