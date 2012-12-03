using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Rcky.MasterRetail2.Models;

namespace Rcky.MasterRetail2.Mapping
{
    public class LojaClienteMap : EntityTypeConfiguration<LojaCliente>
    {
        public LojaClienteMap()
        {
            // Primary Key
            this.HasKey(t => t.LojaClienteId);

            // Properties
            // Table & Column Mappings
            this.ToTable("LOJAS_CLIENTE");
            this.Property(t => t.LojaClienteId).HasColumnName("ID_LJCL");
            this.Property(t => t.LojaId).HasColumnName("COD_LOJA");
            this.Property(t => t.ClienteId).HasColumnName("COD_CLI");
            this.Property(t => t.SituacaoId).HasColumnName("COD_SITU");
        }
    }
}