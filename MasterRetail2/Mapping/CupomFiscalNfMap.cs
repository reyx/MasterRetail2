using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Rcky.MasterRetail2.Models;

namespace Rcky.MasterRetail2.Mapping
{
    public class CupomFiscalNfMap : EntityTypeConfiguration<CupomFiscalNf>
    {
        public CupomFiscalNfMap()
        {
            // Primary Key
            this.HasKey(t => t.CupomFiscalNfId);

            // Properties
            // Table & Column Mappings
            this.ToTable("CUPONS_FISCAIS_NF");
            this.Property(t => t.CupomFiscalNfId).HasColumnName("ID_CPNF");
            this.Property(t => t.CupomFiscalId).HasColumnName("ID_CPFS");
            this.Property(t => t.NfId).HasColumnName("ID_NF");

            // Relationships
            this.HasOptional(t => t.CupomFiscal)
                .WithMany(t => t.CuponsFiscaisNf)
                .HasForeignKey(d => d.CupomFiscalId);

            this.HasOptional(t => t.NotaFiscal)
                .WithMany(t => t.CuponsFiscaisNf)
                .HasForeignKey(d => d.NfId);

        }
    }
}