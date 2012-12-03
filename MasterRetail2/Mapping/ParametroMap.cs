using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Rcky.MasterRetail2.Models;

namespace Rcky.MasterRetail2.Mapping
{
    public class ParametroMap : EntityTypeConfiguration<Parametro>
    {
        public ParametroMap()
        {
            // Primary Key
            this.HasKey(t => t.ParametroId);

            // Properties
            this.Property(t => t.Valor)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("PARAMETROS");
            this.Property(t => t.ParametroId).HasColumnName("ID_PAR");
            this.Property(t => t.LojaId).HasColumnName("COD_LOJA");
            this.Property(t => t.TipoParametroId).HasColumnName("ID_TPPR");
            this.Property(t => t.Valor).HasColumnName("VALOR_PAR");
            this.Property(t => t.Texto).HasColumnName("TEXTO_PAR");

            // Relationships
            this.HasOptional(t => t.Loja)
                .WithMany(t => t.Parametros)
                .HasForeignKey(d => d.LojaId);

        }
    }
}