using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Rcky.MasterRetail2.Entities;

namespace Rcky.MasterRetail2.Mapping
{
	public class CodigoBarrasMap : EntityTypeConfiguration<CodigoBarras>
	{
        public CodigoBarrasMap()
		{
			// Primary Key
			this.HasKey(t => t.CodigoBarraId);

			// Properties
			this.Property(t => t.Codigo)
				.HasMaxLength(13);
				
			this.Property(t => t.PrincipalString)
				.IsFixedLength()
                .HasMaxLength(1);

            this.Ignore(t => t.Principal);
				
			// Table & Column Mappings
			this.ToTable("CODIGO_BARRAS");
			this.Property(t => t.CodigoBarraId).HasColumnName("ID_BAR");
			this.Property(t => t.Codigo).HasColumnName("COD_BAR");
			this.Property(t => t.ProdutoId).HasColumnName("COD_PROD");
			this.Property(t => t.PrincipalString).HasColumnName("PRINCIPAL_CDBR");

			// Relationships
			this.HasOptional(t => t.Produto)
				.WithMany(t => t.CodigosBarras)
				.HasForeignKey(d => d.ProdutoId);
				
		}
	}
}