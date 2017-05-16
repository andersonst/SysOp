using SisOpe.Domain.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class Produto_PromocaoMap : EntityTypeConfiguration<Produto_Promocao>
    {
        public Produto_PromocaoMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("produto_promocao", "sysop");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ID_PRODUTO).HasColumnName("ID_PRODUTO");
            this.Property(t => t.DATA_INICIO).HasColumnName("DATA_INICIO");
            this.Property(t => t.DATA_FIM).HasColumnName("DATA_FIM");
            this.Property(t => t.VALOR).HasColumnName("VALOR");
            this.Property(t => t.QUANTIDADE_EM_PROMOCAO).HasColumnName("QUANTIDADE_EM_PROMOCAO");
            this.Property(t => t.QUANTIDADE_MAXIMA_CLIENTE).HasColumnName("QUANTIDADE_MAXIMA_CLIENTE");

            // Relationships
            this.HasRequired(t => t.produto)
                .WithMany(t => t.produto_promocao)
                .HasForeignKey(d => d.ID_PRODUTO);

        }
    }
}
