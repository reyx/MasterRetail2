using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class InventarioMap : EntityTypeConfiguration<Inventario>
    {
        public InventarioMap()
        {
            // Primary Key
            this.HasKey(t => t.InventarioId);

            // Properties
            // Table & Column Mappings
            this.ToTable("INVENTARIO");
            this.Property(t => t.InventarioId).HasColumnName("ID_INV");
            this.Property(t => t.LojaId).HasColumnName("COD_LOJA");
            this.Property(t => t.Inicio).HasColumnName("DATINI_INV");
            this.Property(t => t.Fim).HasColumnName("DATFIN_INV");
            this.Property(t => t.ValorEstoque).HasColumnName("VALOREST_INV");
            this.Property(t => t.ValorInventario).HasColumnName("VALORINV_INV");
            this.Property(t => t.OperadorId).HasColumnName("ID_OPER");
            this.Property(t => t.LocalEstoqueId).HasColumnName("COD_LCES");

            // Relationships
            this.HasOptional(t => t.LocalEstoque)
                .WithMany(t => t.Inventarios)
                .HasForeignKey(d => d.LocalEstoqueId);

            this.HasOptional(t => t.Loja)
                .WithMany(t => t.Inventarios)
                .HasForeignKey(d => d.LojaId);

            this.HasOptional(t => t.Operador)
                .WithMany(t => t.Inventarios)
                .HasForeignKey(d => d.OperadorId);

        }
    }
}