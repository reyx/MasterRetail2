using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class ItemArvoreMap : EntityTypeConfiguration<ItemArvore>
    {
        public ItemArvoreMap()
        {
            // Primary Key
            this.HasKey(t => t.ItemArvoreId);

            // Properties
            // Table & Column Mappings
            this.ToTable("ITENS_ARVORE");
            this.Property(t => t.ItemArvoreId).HasColumnName("ID_ITAR");
            this.Property(t => t.ArvoreId).HasColumnName("ID_ARV");
            this.Property(t => t.ProdutoId).HasColumnName("COD_PROD");
            this.Property(t => t.PercentualCusto).HasColumnName("PERCCUSTO_ITAR");
            this.Property(t => t.Quantidade).HasColumnName("QUANTIDADE_ITAR");

            // Relationships
            this.HasOptional(t => t.Arvore)
                .WithMany(t => t.ItensArvore)
                .HasForeignKey(d => d.ArvoreId);

            this.HasOptional(t => t.Produto)
                .WithMany(t => t.ItensArvore)
                .HasForeignKey(d => d.ProdutoId);

        }
    }
}