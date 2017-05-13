using SisOpe.Domain.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class Ecf_ResolucaoMap : EntityTypeConfiguration<Ecf_Resolucao>
    {
        public Ecf_ResolucaoMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.RESOLUCAO_TELA)
                .HasMaxLength(20);

            this.Property(t => t.IMAGEM_TELA)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ecf_resolucao", "sysop");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.RESOLUCAO_TELA).HasColumnName("RESOLUCAO_TELA");
            this.Property(t => t.LARGURA).HasColumnName("LARGURA");
            this.Property(t => t.ALTURA).HasColumnName("ALTURA");
            this.Property(t => t.IMAGEM_TELA).HasColumnName("IMAGEM_TELA");
        }
    }
}
