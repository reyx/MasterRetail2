using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class ItemKitMap : EntityTypeConfiguration<ItemKit>
    {
        public ItemKitMap()
        {
            // Primary Key
            this.HasKey(t => t.ItemKitId);

            // Properties
            // Table & Column Mappings
            this.ToTable("ITENS_KIT");
            this.Property(t => t.ItemKitId).HasColumnName("ID_ITKT");
            this.Property(t => t.KitId).HasColumnName("ID_KIT");
            this.Property(t => t.ProdutoId).HasColumnName("COD_PROD");
            this.Property(t => t.PercentualCusto).HasColumnName("PERCCUSTO_KIT");
            this.Property(t => t.Quantidade).HasColumnName("QUANTIDADE_KIT");

            // Relationships
            this.HasOptional(t => t.Kit)
                .WithMany(t => t.Itens)
                .HasForeignKey(d => d.ItemKitId);

            this.HasOptional(t => t.Produto)
                .WithMany(t => t.ItensKit)
                .HasForeignKey(d => d.ProdutoId);

        }
    }
}