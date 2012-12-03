using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Rcky.MasterRetail2.Entities;

namespace Rcky.MasterRetail2.Mapping
{
    public class GrupoPdvMap : EntityTypeConfiguration<GrupoPdv>
    {
        public GrupoPdvMap()
        {
            // Primary Key
            this.HasKey(t => t.GrupoPdvId);

            // Properties
            this.Property(t => t.Descricao)
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("GRUPOS_PDVS");
            this.Property(t => t.GrupoPdvId).HasColumnName("COD_GRPD");
            this.Property(t => t.Descricao).HasColumnName("DESC_GRPD");
        }
    }
}