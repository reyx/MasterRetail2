using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class ItemInventarioMap : EntityTypeConfiguration<ItemInventario>
    {
        public ItemInventarioMap()
        {
            // Primary Key
            this.HasKey(t => t.ItemInventarioId);

            // Properties
            // Table & Column Mappings
            this.ToTable("ITENS_INVENTARIO");
            this.Property(t => t.ItemInventarioId).HasColumnName("ID_ITIV");
            this.Property(t => t.InventarioId).HasColumnName("ID_INV");
            this.Property(t => t.ValorProdutoId).HasColumnName("ID_VLPR");
            this.Property(t => t.Quantidade).HasColumnName("QTDE_ITIV");
            this.Property(t => t.OperadorId).HasColumnName("ID_OPER");

            // Relationships
            this.HasOptional(t => t.Inventario)
                .WithMany(t => t.Itens)
                .HasForeignKey(d => d.InventarioId);

            this.HasOptional(t => t.Operador)
                .WithMany(t => t.ItensInventario)
                .HasForeignKey(d => d.OperadorId);

            this.HasOptional(t => t.ValorProduto)
                .WithMany(t => t.ItensInventario)
                .HasForeignKey(d => d.ValorProdutoId);

        }
    }
}