using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class ItemPromocaoMap : EntityTypeConfiguration<ItemPromocao>
    {
        public ItemPromocaoMap()
        {
            // Primary Key
            this.HasKey(t => t.ItemPromocaoId);

            // Properties
            // Table & Column Mappings
            this.ToTable("ITENS_PROMOCAO");
            this.Property(t => t.ItemPromocaoId).HasColumnName("ID_ITPR");
            this.Property(t => t.PromocaoId).HasColumnName("COD_PROM");
            this.Property(t => t.ProdutoId).HasColumnName("COD_PROD");

            // Relationships
            this.HasOptional(t => t.Produto)
                .WithMany(t => t.ItensPromocao)
                .HasForeignKey(d => d.ProdutoId);

            this.HasOptional(t => t.Promocao)
                .WithMany(t => t.Itens)
                .HasForeignKey(d => d.PromocaoId);

        }
    }
}