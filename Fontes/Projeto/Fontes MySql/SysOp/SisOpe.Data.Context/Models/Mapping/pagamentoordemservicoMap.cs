using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class pagamentoordemservicoMap : EntityTypeConfiguration<pagamentoordemservico>
    {
        public pagamentoordemservicoMap()
        {
            // Primary Key
            this.HasKey(t => t.IdPagamentoOrdemServico);

            // Properties
            this.Property(t => t.Status)
                .HasMaxLength(20);

            this.Property(t => t.NumeroDocumento)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("pagamentoordemservico", "sysop");
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
            this.HasOptional(t => t.ordemservico)
                .WithMany(t => t.pagamentoordemservicoes)
                .HasForeignKey(d => d.IdOrdemServico);

        }
    }
}
