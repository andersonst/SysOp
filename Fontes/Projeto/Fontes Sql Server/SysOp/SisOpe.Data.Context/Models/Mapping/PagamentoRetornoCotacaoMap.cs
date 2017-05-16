using SisOpe.Domain.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class PagamentoRetornoCotacaoMap : EntityTypeConfiguration<PagamentoRetornoCotacao>
    {
        public PagamentoRetornoCotacaoMap()
        {
            // Primary Key
            this.HasKey(t => t.IdPagamentoRetorno);

            // Properties
            // Table & Column Mappings
            this.ToTable("pagamentoretornocotacao", "sysop");
            this.Property(t => t.IdPagamentoRetorno).HasColumnName("IdPagamentoRetorno");
            this.Property(t => t.IdCotacao).HasColumnName("IdCotacao");
            this.Property(t => t.IdFormaPagamento).HasColumnName("IdFormaPagamento");
            this.Property(t => t.Parcela).HasColumnName("Parcela");
            this.Property(t => t.DataVencimento).HasColumnName("DataVencimento");
            this.Property(t => t.ValorPago).HasColumnName("ValorPago");

            // Relationships
            this.HasOptional(t => t.formapagamento)
                .WithMany(t => t.pagamentoretornocotacaos)
                .HasForeignKey(d => d.IdFormaPagamento);

        }
    }
}
