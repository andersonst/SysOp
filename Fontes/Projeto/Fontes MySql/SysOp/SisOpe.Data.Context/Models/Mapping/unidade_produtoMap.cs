using SisOpe.Domain.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class Unidade_ProdutoMap : EntityTypeConfiguration<Unidade_Produto>
    {
        public Unidade_ProdutoMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.NOME)
                .HasMaxLength(10);

            this.Property(t => t.DESCRICAO)
                .HasMaxLength(1073741823);

            // Table & Column Mappings
            this.ToTable("unidade_produto", "sysop");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.NOME).HasColumnName("NOME");
            this.Property(t => t.DESCRICAO).HasColumnName("DESCRICAO");
        }
    }
}
