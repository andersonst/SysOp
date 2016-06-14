using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SysOp.Data.Entidades.Mapping
{
    public class NotaFiscalMap : EntityTypeConfiguration<NotaFiscalEnt>
    {
        public NotaFiscalMap()
        {
            // Primary Key
            this.HasKey(t => t.IdNotaFiscal);

            // Properties
            this.Property(t => t.ChaveAcesso)
                .HasMaxLength(30);

            this.Property(t => t.PalavrasChave)
                .HasMaxLength(20);

            this.Property(t => t.Observacoes)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("NotaFiscal");
            this.Property(t => t.IdNotaFiscal).HasColumnName("IdNotaFiscal");
            this.Property(t => t.NumeroNF).HasColumnName("NumeroNF");
            this.Property(t => t.Serie).HasColumnName("Serie");
            this.Property(t => t.CodRegimeTrib).HasColumnName("CodRegimeTrib");
            this.Property(t => t.Data).HasColumnName("Data");
            this.Property(t => t.ChaveAcesso).HasColumnName("ChaveAcesso");
            this.Property(t => t.PalavrasChave).HasColumnName("PalavrasChave");
            this.Property(t => t.Observacoes).HasColumnName("Observacoes");
        }
    }
}
