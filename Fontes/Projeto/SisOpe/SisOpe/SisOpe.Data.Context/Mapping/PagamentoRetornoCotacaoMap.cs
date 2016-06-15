using SisOpe.Domain.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Mapping
{
    public class PagamentoRetornoCotacaoMap : EntityTypeConfiguration<PagamentoRetornoCotacao>
    {
        public PagamentoRetornoCotacaoMap()
        {
            // Primary Key
            this.HasKey(t => t.IdPagamentoRetorno);

            // Properties
            // Table & Column Mappings
            this.ToTable("PagamentoRetornoCotacao");
            this.Property(t => t.IdPagamentoRetorno).HasColumnName("IdPagamentoRetorno");
            this.Property(t => t.IdCotacao).HasColumnName("IdCotacao");
            this.Property(t => t.IdFormaPagamento).HasColumnName("IdFormaPagamento");
            this.Property(t => t.Parcela).HasColumnName("Parcela");
            this.Property(t => t.DataVencimento).HasColumnName("DataVencimento");
            this.Property(t => t.ValorPago).HasColumnName("ValorPago");

            // Relationships
            this.HasOptional(t => t.FormaPagamento)
                .WithMany(t => t.PagamentoRetornoCotacaos)
                .HasForeignKey(d => d.IdFormaPagamento);

        }
    }
}
