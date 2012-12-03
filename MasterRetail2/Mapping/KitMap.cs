using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Rcky.MasterRetail2.Models;

namespace Rcky.MasterRetail2.Mapping
{
    public class KitMap : EntityTypeConfiguration<Kit>
    {
        public KitMap()
        {
            // Primary Key
            this.HasKey(t => t.KitId);

            // Properties
            this.Property(t => t.Descricao)
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("KITS");
            this.Property(t => t.KitId).HasColumnName("ID_KIT");
            this.Property(t => t.Codigo).HasColumnName("COD_KIT");
            this.Property(t => t.Descricao).HasColumnName("DESC_KIT");
            this.Property(t => t.Lote).HasColumnName("LOTE_KIT");
            this.Property(t => t.Observacao).HasColumnName("OBS_KIT");
            this.Property(t => t.Foto).HasColumnName("FOTO_KIT");
            this.Property(t => t.LojaId).HasColumnName("COD_LOJA");

            // Relationships
            this.HasOptional(t => t.Loja)
                .WithMany(t => t.Kits)
                .HasForeignKey(d => d.LojaId);

        }
    }
}