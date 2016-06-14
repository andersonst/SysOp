using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SysOp.Data.Entidades.Mapping
{
    public class PagamentoOrdemServicoMap : EntityTypeConfiguration<PagamentoOrdemServicoEnt>
    {
        public PagamentoOrdemServicoMap()
        {
            // Primary Key
            this.HasKey(t => t.IdPagamentoOrdemServico);

            // Properties
            this.Property(t => t.Status)
                .HasMaxLength(20);

            this.Property(t => t.NumeroDocumento)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PagamentoOrdemServico");
            this.Property(t => t.IdPagamentoOrdemServico).HasColumnName("IdPagamentoOrdemServico");
            this.Property(t => t.NumeroParcela).HasColumnName("NumeroParcela");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.NumeroDocumento).HasColumnName("NumeroDocumento");
            this.Property(t => t.Valor).HasColumnName("Valor");
            this.Property(t => t.DataVencimento).HasColumnName("DataVencimento");
            this.Property(t => t.ValorPago).HasColumnName("ValorPago");
            this.Property(t => t.DataPagamento).HasColumnName("DataPagamento");
            this.Property(t => t.IdOrdemServico).HasColumnName("IdOrdemServico");

            // Relationships
            this.HasOptional(t => t.OrdemServico)
                .WithMany(t => t.PagamentoOrdemServicoes)
                .HasForeignKey(d => d.IdOrdemServico);

        }
    }
}
