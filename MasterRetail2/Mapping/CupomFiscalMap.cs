using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Rcky.MasterRetail2.Models;

namespace Rcky.MasterRetail2.Mapping
{
	public class CupomFiscalMap : EntityTypeConfiguration<CupomFiscal>
	{
        public CupomFiscalMap()
		{
			// Primary Key
			this.HasKey(t => t.CupomFiscalId);

			// Properties
			this.Property(t => t.Modelo)
				.IsFixedLength()
				.HasMaxLength(2);
				
			// Table & Column Mappings
			this.ToTable("CUPONS_FISCAIS");
			this.Property(t => t.CupomFiscalId).HasColumnName("ID_CPFS");
			this.Property(t => t.EcfId).HasColumnName("ECF_CPFS");
			this.Property(t => t.Coo).HasColumnName("COO_CPFS");
			this.Property(t => t.Modelo).HasColumnName("MODELO_CPFS");
		}
	}
}