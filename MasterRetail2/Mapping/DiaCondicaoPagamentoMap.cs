using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Rcky.MasterRetail2.Models;

namespace Rcky.MasterRetail2.Mapping
{
	public class DiaCondicaoPagamentoMap : EntityTypeConfiguration<DiaCondicaoPagamento>
	{
        public DiaCondicaoPagamentoMap()
		{
			// Primary Key
			this.HasKey(t => t.DiaCondicaoPagamentoId);

			// Properties
			// Table & Column Mappings
			this.ToTable("DIAS_CONDICAO_PAGAMENTO");
            this.Property(t => t.DiaCondicaoPagamentoId).HasColumnName("ID_DICP");
			this.Property(t => t.CondicaoPagamentoId).HasColumnName("COD_CDPG");
			this.Property(t => t.Dias).HasColumnName("DIAS_DICP");

			// Relationships
			this.HasOptional(t => t.CondicaoPagamento)
				.WithMany(t => t.DiasCondicaoPagamento)
				.HasForeignKey(d => d.CondicaoPagamento);
				
		}
	}
}