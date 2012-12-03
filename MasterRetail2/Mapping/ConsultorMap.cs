using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Rcky.MasterRetail2.Entities;

namespace Rcky.MasterRetail2.Mapping
{
    public class ConsultorMap : EntityTypeConfiguration<Consultor>
    {
        public ConsultorMap()
        {
            // Primary Key
            this.HasKey(t => t.ConsultorId);

            // Properties
            this.Property(t => t.AtivoString)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Ignore(t => t.Ativo);

            // Table & Column Mappings
            this.ToTable("CONSULTORES");
            this.Property(t => t.ConsultorId).HasColumnName("COD_CONS");
            this.Property(t => t.AtivoString).HasColumnName("ATIVO_CONS");
            this.Property(t => t.PessoaId).HasColumnName("ID_PESSOA");

            // Relationships
            this.HasOptional(t => t.Pessoa)
                .WithMany(t => t.Consultores)
                .HasForeignKey(d => d.PessoaId);

        }
    }
}