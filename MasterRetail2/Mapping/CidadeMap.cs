using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
	public class CidadeMap : EntityTypeConfiguration<Cidade>
	{
        public CidadeMap()
		{
			// Primary Key
			this.HasKey(t => t.CidadeId);

			// Properties
			this.Property(t => t.Nome)
				.HasMaxLength(50);
				
			// Table & Column Mappings
			this.ToTable("CIDADES");
			this.Property(t => t.CidadeId).HasColumnName("ID_CID");
			this.Property(t => t.UfId).HasColumnName("ID_UF");
			this.Property(t => t.Nome).HasColumnName("NOME_CID");
			this.Property(t => t.CodigoIbge).HasColumnName("CODIBGE_CID");

			// Relationships
			this.HasRequired(t => t.Uf)
				.WithMany(t => t.Cidades)
				.HasForeignKey(d => d.UfId);
				
		}
	}
}