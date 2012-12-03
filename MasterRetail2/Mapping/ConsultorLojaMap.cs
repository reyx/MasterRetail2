using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Rcky.MasterRetail2.Models;

namespace Rcky.MasterRetail2.Mapping
{
    public class ConsultorLojaMap : EntityTypeConfiguration<ConsultorLoja>
    {
        public ConsultorLojaMap()
        {
            // Primary Key
            this.HasKey(t => t.ConsultorLojaId);

            // Properties
            // Table & Column Mappings
            this.ToTable("CONSULTORES_LOJAS");
            this.Property(t => t.ConsultorLojaId).HasColumnName("ID_CNLJ");
            this.Property(t => t.ConsultorId).HasColumnName("COD_CONS");
            this.Property(t => t.LojaId).HasColumnName("COD_LOJA");

            // Relationships
            this.HasOptional(t => t.Consultor)
                .WithMany(t => t.ConsultoresLojas)
                .HasForeignKey(d => d.ConsultorId);

            this.HasOptional(t => t.Loja)
                .WithMany(t => t.ConsultoresLoja)
                .HasForeignKey(d => d.LojaId);

        }
    }
}