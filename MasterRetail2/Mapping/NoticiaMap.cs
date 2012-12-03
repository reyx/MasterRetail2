using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Rcky.MasterRetail2.Models;

namespace Rcky.MasterRetail2.Mapping
{
    public class NoticiaMap : EntityTypeConfiguration<Noticia>
    {
        public NoticiaMap()
        {
            // Primary Key
            this.HasKey(t => t.NoticiaId);

            // Properties
            this.Property(t => t.Titulo)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("NOTICIAS");
            this.Property(t => t.NoticiaId).HasColumnName("ID_NOT");
            this.Property(t => t.Titulo).HasColumnName("TITULO_NOT");
            this.Property(t => t.Texto).HasColumnName("TEXTO_NOT");
            this.Property(t => t.Data).HasColumnName("DATA_NOT");
        }
    }
}