using SisOpe.Domain.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class OrdemServicoMap : EntityTypeConfiguration<OrdemServico>
    {
        public OrdemServicoMap()
        {
            // Primary Key
            this.HasKey(t => t.IdOrdemServico);

            // Properties
            this.Property(t => t.Titulo)
                .HasMaxLength(100);

            this.Property(t => t.Descricao)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("ordemservico", "sysop");
            this.Property(t => t.IdOrdemServico).HasColumnName("IdOrdemServico");
            this.Property(t => t.IdPessoa).HasColumnName("IdPessoa");
            this.Property(t => t.IdStatusOrdemServico).HasColumnName("IdStatusOrdemServico");
            this.Property(t => t.Prioridade).HasColumnName("Prioridade");
            this.Property(t => t.Titulo).HasColumnName("Titulo");
            this.Property(t => t.Descricao).HasColumnName("Descricao");

            // Relationships
            this.HasOptional(t => t.pessoa)
                .WithMany(t => t.ordemservicoes)
                .HasForeignKey(d => d.IdPessoa);
            this.HasOptional(t => t.statusordemservico)
                .WithMany(t => t.ordemservicoes)
                .HasForeignKey(d => d.IdStatusOrdemServico);

        }
    }
}
