using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class PedidoTransitoMap : EntityTypeConfiguration<PedidoTransito>
    {
        public PedidoTransitoMap()
        {
            // Primary Key
            this.HasKey(t => t.PedidoTransitoId);

            // Properties
            // Table & Column Mappings
            this.ToTable("PEDIDOS_TRANSITO");
            this.Property(t => t.PedidoTransitoId).HasColumnName("ID_PDTR");
            this.Property(t => t.EntradaId).HasColumnName("ID_ENTR");
            this.Property(t => t.ValorProdutoId).HasColumnName("ID_VLPR");
            this.Property(t => t.Quantidade).HasColumnName("QTDE_PDTR");
            this.Property(t => t.ItemEntradaId).HasColumnName("ID_ITEN");

            // Relationships
            this.HasOptional(t => t.ItemEntrada)
                .WithMany(t => t.PedidosTransito)
                .HasForeignKey(d => d.ItemEntradaId);

            this.HasOptional(t => t.ValorProduto)
                .WithMany(t => t.PedidosTransito)
                .HasForeignKey(d => d.ValorProdutoId);

        }
    }
}