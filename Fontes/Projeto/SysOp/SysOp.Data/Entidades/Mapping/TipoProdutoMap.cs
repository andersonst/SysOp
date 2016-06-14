using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SysOp.Data.Entidades.Mapping
{
    public class TipoProdutoMap : EntityTypeConfiguration<TipoProdutoEnt>
    {
        public TipoProdutoMap()
        {
            // Primary Key
            this.HasKey(t => t.IdTipoProduto);

            // Properties
            this.Property(t => t.Descricao)
                .HasMaxLength(50);

            this.Property(t => t.Status)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("TipoProduto");
            this.Property(t => t.IdTipoProduto).HasColumnName("IdTipoProduto");
            this.Property(t => t.Descricao).HasColumnName("Descricao");
            this.Property(t => t.Status).HasColumnName("Status");
        }
    }
}
