using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Rcky.MasterRetail2.Models;

namespace Rcky.MasterRetail2.Mapping
{
    public class EnderecoMap : EntityTypeConfiguration<Endereco>
    {
        public EnderecoMap()
        {
            // Primary Key
            this.HasKey(t => t.EnderecoId);

            // Properties
            this.Property(t => t.Nome)
                .HasMaxLength(200);

            this.Property(t => t.Cep)
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("ENDERECOS");
            this.Property(t => t.EnderecoId).HasColumnName("ID_END");
            this.Property(t => t.LogradouroId).HasColumnName("ID_LOGRAD");
            this.Property(t => t.Nome).HasColumnName("LOGR_END");
            this.Property(t => t.Cep).HasColumnName("CEP_END");
            this.Property(t => t.BairroId).HasColumnName("ID_BAIRRO");

            // Relationships
            this.HasRequired(t => t.Bairro)
                .WithMany(t => t.Enderecos)
                .HasForeignKey(d => d.BairroId);

            this.HasOptional(t => t.Logradouro)
                .WithMany(t => t.Enderecos)
                .HasForeignKey(d => d.LogradouroId);

        }
    }
}