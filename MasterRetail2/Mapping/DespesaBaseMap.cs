using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Rcky.MasterRetail2.Models;

namespace Rcky.MasterRetail2.Mapping
{
    public class DespesaBaseMap : EntityTypeConfiguration<DespesaBase>
    {
        public DespesaBaseMap()
        {
            // Primary Key
            this.HasKey(t => t.DespesaBaseId);

            // Properties
            this.Property(t => t.PadraoZero)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("DESPESAS_BASE");
            this.Property(t => t.DespesaBaseId).HasColumnName("ID_DSBS");
            this.Property(t => t.TipoDespesaId).HasColumnName("ID_TPDS");
            this.Property(t => t.LojaId).HasColumnName("COD_LOJA");
            this.Property(t => t.PadraoZero).HasColumnName("PADRAOZERO_DSBS");
            this.Property(t => t.Margem).HasColumnName("MARGEM_DSBS");
            this.Property(t => t.ValorPadrao).HasColumnName("VALORPADRAO_DSBS");

            // Relationships
            this.HasOptional(t => t.Loja)
                .WithMany(t => t.DespesasBase)
                .HasForeignKey(d => d.LojaId);

            this.HasOptional(t => t.TipoDespesa)
                .WithMany(t => t.DespesasBase)
                .HasForeignKey(d => d.TipoDespesaId);

        }
    }
}