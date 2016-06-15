using SisOpe.Domain.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Mapping
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
            this.ToTable("OrdemServico");
            this.Property(t => t.IdOrdemServico).HasColumnName("IdOrdemServico");
            this.Property(t => t.IdPessoa).HasColumnName("IdPessoa");
            this.Property(t => t.IdStatusOrdemServico).HasColumnName("IdStatusOrdemServico");
            this.Property(t => t.Prioridade).HasColumnName("Prioridade");
            this.Property(t => t.Titulo).HasColumnName("Titulo");
            this.Property(t => t.Descricao).HasColumnName("Descricao");

            // Relationships
            this.HasOptional(t => t.Pessoa)
                .WithMany(t => t.OrdemServicoes)
                .HasForeignKey(d => d.IdPessoa);
            this.HasOptional(t => t.StatusOrdemServico)
                .WithMany(t => t.OrdemServicoes)
                .HasForeignKey(d => d.IdStatusOrdemServico);

        }
    }
}
