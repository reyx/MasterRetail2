using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class AdicaoMap : EntityTypeConfiguration<Adicao>
	{
		public AdicaoMap()
		{
			// Primary Key
			this.HasKey(t => t.AdicaoId);

			// Properties
			// Table & Column Mappings
			this.ToTable("ADICOES");
			this.Property(t => t.AdicaoId).HasColumnName("ID_ADIC");
			this.Property(t => t.Numero).HasColumnName("NUMERO_ADIC");
			this.Property(t => t.Item).HasColumnName("ITEM_ADIC");
			this.Property(t => t.CodigoFabrica).HasColumnName("COD_FABR");
			this.Property(t => t.Desconto).HasColumnName("DESCONTO_ADIC");
			this.Property(t => t.DeclaracaoImportacaoId).HasColumnName("ID_DCIM");

			// Relationships
			this.HasOptional(t => t.DeclaracaoImportacao)
				.WithMany(t => t.Adicoes)
				.HasForeignKey(d => d.DeclaracaoImportacaoId);
				
		}
	}
}