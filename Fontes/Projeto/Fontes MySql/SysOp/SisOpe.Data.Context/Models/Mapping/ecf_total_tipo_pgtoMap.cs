using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class ecf_total_tipo_pgtoMap : EntityTypeConfiguration<ecf_total_tipo_pgto>
    {
        public ecf_total_tipo_pgtoMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.NSU)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("ecf_total_tipo_pgto", "sysop");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ID_ECF_VENDA_CABECALHO).HasColumnName("ID_ECF_VENDA_CABECALHO");
            this.Property(t => t.ID_ECF_TIPO_PAGAMENTO).HasColumnName("ID_ECF_TIPO_PAGAMENTO");
            this.Property(t => t.VALOR).HasColumnName("VALOR");
            this.Property(t => t.NSU).HasColumnName("NSU");

            // Relationships
            this.HasRequired(t => t.ecf_tipo_pagamento)
                .WithMany(t => t.ecf_total_tipo_pgto)
                .HasForeignKey(d => d.ID_ECF_TIPO_PAGAMENTO);
            this.HasRequired(t => t.ecf_venda_cabecalho)
                .WithMany(t => t.ecf_total_tipo_pgto)
                .HasForeignKey(d => d.ID_ECF_VENDA_CABECALHO);

        }
    }
}
