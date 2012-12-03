using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Rcky.MasterRetail2.Entities;

namespace Rcky.MasterRetail2.Mapping
{
	public class EntregadorMap : EntityTypeConfiguration<Entregador>
	{
        public EntregadorMap()
		{
			// Primary Key
			this.HasKey(t => t.EntregadorId);

			// Properties
			this.Property(t => t.AtivoString)
				.IsFixedLength()
				.HasMaxLength(1);

            this.Ignore(t => t.Ativo);
				
			// Table & Column Mappings
			this.ToTable("ENTREGADORES");
			this.Property(t => t.EntregadorId).HasColumnName("COD_ENTR");
			this.Property(t => t.AtivoString).HasColumnName("ATIVO_ENTR");
			this.Property(t => t.PessoaId).HasColumnName("ID_PESSOA");

			// Relationships
			this.HasOptional(t => t.Pessoa)
				.WithMany(t => t.Entregadores)
				.HasForeignKey(d => d.PessoaId);
				
		}
	}
}