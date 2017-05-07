using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class ProdutoMap : EntityTypeConfiguration<Produto>
    {
        public ProdutoMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.GTIN)
                .HasMaxLength(14);

            this.Property(t => t.CODIGO_INTERNO)
                .HasMaxLength(20);

            this.Property(t => t.NOME)
                .HasMaxLength(100);

            this.Property(t => t.DESCRICAO)
                .HasMaxLength(1073741823);

            this.Property(t => t.DESCRICAO_PDV)
                .HasMaxLength(30);

            this.Property(t => t.IAT)
                .HasMaxLength(1);

            this.Property(t => t.IPPT)
                .HasMaxLength(1);

            this.Property(t => t.NCM)
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("produto", "sysop");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ID_ECF_TRIBUTOS).HasColumnName("ID_ECF_TRIBUTOS");
            this.Property(t => t.ID_UNIDADE_PRODUTO).HasColumnName("ID_UNIDADE_PRODUTO");
            this.Property(t => t.GTIN).HasColumnName("GTIN");
            this.Property(t => t.CODIGO_INTERNO).HasColumnName("CODIGO_INTERNO");
            this.Property(t => t.NOME).HasColumnName("NOME");
            this.Property(t => t.DESCRICAO).HasColumnName("DESCRICAO");
            this.Property(t => t.DESCRICAO_PDV).HasColumnName("DESCRICAO_PDV");
            this.Property(t => t.VALOR_VENDA).HasColumnName("VALOR_VENDA");
            this.Property(t => t.QTD_ESTOQUE).HasColumnName("QTD_ESTOQUE");
            this.Property(t => t.ESTOQUE_MIN).HasColumnName("ESTOQUE_MIN");
            this.Property(t => t.ESTOQUE_MAX).HasColumnName("ESTOQUE_MAX");
            this.Property(t => t.IAT).HasColumnName("IAT");
            this.Property(t => t.IPPT).HasColumnName("IPPT");
            this.Property(t => t.NCM).HasColumnName("NCM");

            // Relationships
            this.HasRequired(t => t.ecf_tributo_produto)
                .WithMany(t => t.produtoes)
                .HasForeignKey(d => d.ID_ECF_TRIBUTOS);
            this.HasRequired(t => t.unidade_produto)
                .WithMany(t => t.produtoes)
                .HasForeignKey(d => d.ID_UNIDADE_PRODUTO);

        }
    }
}
