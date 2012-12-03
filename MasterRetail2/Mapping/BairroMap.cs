using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
	public class BairroMap : EntityTypeConfiguration<Bairro>
	{
        public BairroMap()
		{
			// Primary Key
			this.HasKey(t => t.BairroId);

			// Properties
			this.Property(t => t.Nome)
				.HasMaxLength(50);
				
			// Table & Column Mappings
			this.ToTable("BAIRROS");
			this.Property(t => t.BairroId).HasColumnName("ID_BAIRRO");
			this.Property(t => t.CidadeId).HasColumnName("ID_CID");
			this.Property(t => t.Nome).HasColumnName("NOME_BAIRRO");

			// Relationships
			this.HasRequired(t => t.Cidade)
				.WithMany(t => t.Bairros)
				.HasForeignKey(d => d.CidadeId);
				
		}
	}
}