using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Rcky.MasterRetail2.Models;

namespace Rcky.MasterRetail2.Mapping
{
	public class CodigoTributacaoEcfMap : EntityTypeConfiguration<CodigoTributacaoEcf>
	{
        public CodigoTributacaoEcfMap()
		{
			// Primary Key
			this.HasKey(t => t.CodigoTributacaoEcfId);

			// Properties
			this.Property(t => t.Comando)
				.HasMaxLength(30);
				
			this.Property(t => t.TipoComendo)
				.IsFixedLength()
				.HasMaxLength(1);
				
			// Table & Column Mappings
			this.ToTable("CODIGOS_TRIBUTACAO_ECF");
			this.Property(t => t.CodigoTributacaoEcfId).HasColumnName("ID_CTEC");
			this.Property(t => t.EcfId).HasColumnName("ID_ECF");
			this.Property(t => t.CodigoTributacaoId).HasColumnName("COD_CDTR");
			this.Property(t => t.Comando).HasColumnName("COMANDO_CTEC");
			this.Property(t => t.TipoComendo).HasColumnName("TIPOCOMANDO_CTEC");
			this.Property(t => t.TamanhoComando).HasColumnName("TAMCOMANDO_CTEC");

			// Relationships
			this.HasOptional(t => t.CodigoTributacao)
				.WithMany(t => t.CodigosTributacaoEcf)
				.HasForeignKey(d => d.CodigoTributacaoId);
				
			this.HasOptional(t => t.Ecf)
                .WithMany(t => t.CodigosTributacaoEcf)
				.HasForeignKey(d => d.EcfId);
				
		}
	}
}