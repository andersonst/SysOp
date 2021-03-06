using SisOpe.Domain.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class Ecf_Tipo_PagamentoMap : EntityTypeConfiguration<Ecf_Tipo_Pagamento>
    {
        public Ecf_Tipo_PagamentoMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.CODIGO)
                .HasMaxLength(3);

            this.Property(t => t.DESCRICAO)
                .HasMaxLength(20);

            this.Property(t => t.TEF)
                .HasMaxLength(1);

            this.Property(t => t.IMPRIME_VINCULADO)
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("ecf_tipo_pagamento", "sysop");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.CODIGO).HasColumnName("CODIGO");
            this.Property(t => t.DESCRICAO).HasColumnName("DESCRICAO");
            this.Property(t => t.TEF).HasColumnName("TEF");
            this.Property(t => t.IMPRIME_VINCULADO).HasColumnName("IMPRIME_VINCULADO");
        }
    }
}
