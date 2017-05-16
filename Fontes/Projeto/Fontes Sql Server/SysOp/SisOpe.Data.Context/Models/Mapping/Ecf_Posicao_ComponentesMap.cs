using SisOpe.Domain.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class Ecf_Posicao_ComponentesMap : EntityTypeConfiguration<Ecf_Posicao_Componentes>
    {
        public Ecf_Posicao_ComponentesMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.NOME)
                .HasMaxLength(100);

            this.Property(t => t.TEXTO)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("ecf_posicao_componentes", "sysop");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ID_ECF_RESOLUCAO).HasColumnName("ID_ECF_RESOLUCAO");
            this.Property(t => t.NOME).HasColumnName("NOME");
            this.Property(t => t.ALTURA).HasColumnName("ALTURA");
            this.Property(t => t.LARGURA).HasColumnName("LARGURA");
            this.Property(t => t.TOPO).HasColumnName("TOPO");
            this.Property(t => t.ESQUERDA).HasColumnName("ESQUERDA");
            this.Property(t => t.TAMANHO_FONTE).HasColumnName("TAMANHO_FONTE");
            this.Property(t => t.TEXTO).HasColumnName("TEXTO");

            // Relationships
            this.HasRequired(t => t.ecf_resolucao)
                .WithMany(t => t.ecf_posicao_componentes)
                .HasForeignKey(d => d.ID_ECF_RESOLUCAO);

        }
    }
}
