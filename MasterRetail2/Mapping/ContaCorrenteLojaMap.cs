using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Rcky.MasterRetail2.Models;

namespace Rcky.MasterRetail2.Mapping
{
	public class ContaCorrenteLojaMap : EntityTypeConfiguration<ContaCorrenteLoja>
	{
        public ContaCorrenteLojaMap()
		{
			// Primary Key
			this.HasKey(t => t.ContaCorrenteLojaId);

			// Properties
			// Table & Column Mappings
			this.ToTable("CONTAS_CORRENTES_LOJA");
			this.Property(t => t.ContaCorrenteLojaId).HasColumnName("ID_CCLJ");
			this.Property(t => t.ContaCorrenteId).HasColumnName("ID_CTCR");
			this.Property(t => t.LojaId).HasColumnName("COD_LOJA");

			// Relationships
			this.HasOptional(t => t.ContaCorrente)
				.WithMany(t => t.ContasCorrentesLojas)
				.HasForeignKey(d => d.ContaCorrenteId);
				
			this.HasOptional(t => t.Loja)
				.WithMany(t => t.ContasCorrentesLojas)
				.HasForeignKey(d => d.LojaId);
				
		}
	}
}