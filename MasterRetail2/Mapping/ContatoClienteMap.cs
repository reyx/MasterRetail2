using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Rcky.MasterRetail2.Models;

namespace Rcky.MasterRetail2.Mapping
{
	public class ContatoClienteMap : EntityTypeConfiguration<ContatoCliente>
	{
        public ContatoClienteMap()
		{
			// Primary Key
			this.HasKey(t => t.ContatoClienteId);

			// Properties
			this.Property(t => t.Tipo)
				.IsRequired()
				.IsFixedLength()
				.HasMaxLength(1);
				
			// Table & Column Mappings
			this.ToTable("CONTATOS_CLIENTE");
			this.Property(t => t.ContatoClienteId).HasColumnName("COD_CTCL");
			this.Property(t => t.Tipo).HasColumnName("TIPO_CTCL");
			this.Property(t => t.Data).HasColumnName("DATA_CTCL");
			this.Property(t => t.Observacao).HasColumnName("OBS_CTCL");
			this.Property(t => t.ClienteId).HasColumnName("COD_CLI");

            // Relationships
            this.HasOptional(t => t.Cliente)
                .WithMany(t => t.ContatosCliente)
                .HasForeignKey(d => d.ClienteId);
		}
	}
}