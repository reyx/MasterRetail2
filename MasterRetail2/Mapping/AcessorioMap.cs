using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
	public class AcessorioMap : EntityTypeConfiguration<Acessorio>
	{
		public AcessorioMap()
		{
			// Primary Key
			this.HasKey(t => t.AcessorioId);

			// Properties
			// Table & Column Mappings
			this.ToTable("ACESSORIOS");
			this.Property(t => t.AcessorioId).HasColumnName("ID_ACES");
			this.Property(t => t.ProdutoId).HasColumnName("COD_PROD_PAI");
			this.Property(t => t.ProdutoAcessorioId).HasColumnName("COD_PROD_FILHO");
			this.Property(t => t.Quantidade).HasColumnName("QUANTIDADE_ACES");

			// Relationships
            this.HasRequired(t => t.Produto)
                .WithMany(t => t.Acessorios)
                .HasForeignKey(d => d.ProdutoId);

            this.HasRequired(t => t.ProdutoAcessorio)
                .WithMany(t => t.Acessorios)
                .HasForeignKey(d => d.ProdutoAcessorioId);
		}
	}
}