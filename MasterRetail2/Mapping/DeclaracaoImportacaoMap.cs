using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Rcky.MasterRetail2.Models;

namespace Rcky.MasterRetail2.Mapping
{
	public class DeclaracaoImportacaoMap : EntityTypeConfiguration<DeclaracaoImportacao>
	{
        public DeclaracaoImportacaoMap()
		{
			// Primary Key
			this.HasKey(t => t.DeclaracaoImportacaoId);

			// Properties
			this.Property(t => t.LocalDesembargo)
				.HasMaxLength(60);
				
			// Table & Column Mappings
			this.ToTable("DECLARACOES_IMPORTACAO");
			this.Property(t => t.DeclaracaoImportacaoId).HasColumnName("ID_DCIM");
			this.Property(t => t.LocalDesembargo).HasColumnName("LOCALDESEMB_DCIM");
			this.Property(t => t.UfId).HasColumnName("ID_UF");
			this.Property(t => t.DataDesembargo).HasColumnName("DATADESEMB_DCIM");
			this.Property(t => t.CodigoExportacao).HasColumnName("COD_EXPO");
			this.Property(t => t.VendaId).HasColumnName("ID_VDA");

			// Relationships
			this.HasOptional(t => t.Venda)
				.WithMany(t => t.DeclaracoesImportacao)
				.HasForeignKey(d => d.VendaId);
				
		}
	}
}