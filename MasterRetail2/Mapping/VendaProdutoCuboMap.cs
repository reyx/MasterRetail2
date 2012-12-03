using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class VendaProdutoCuboMap : EntityTypeConfiguration<VendaProdutoCubo>
    {
        public VendaProdutoCuboMap()
        {
            // Primary Key
            this.HasKey(t => t.VendaProdutoCuboId);

            // Properties
            this.Property(t => t.Data)
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("VENDAS_PRODUTO_CUBO");
            this.Property(t => t.VendaProdutoCuboId).HasColumnName("ID_VDPC");
            this.Property(t => t.LojaId).HasColumnName("COD_LOJA");
            this.Property(t => t.ValorProdutoId).HasColumnName("ID_VLPR");
            this.Property(t => t.Quantidade).HasColumnName("QTDE_ITVD");
            this.Property(t => t.Preco).HasColumnName("PRECO_ITVD");
            this.Property(t => t.Custo).HasColumnName("CUSTO_PROD");
            this.Property(t => t.Data).HasColumnName("DATA_VDA");
            this.Property(t => t.Devolucao).HasColumnName("DEVOLUCAO_ITVD");

            // Relationships
            this.HasOptional(t => t.Loja)
                .WithMany(t => t.VendasProdutoCubo)
                .HasForeignKey(d => d.LojaId);

            this.HasOptional(t => t.ValorProduto)
                .WithMany(t => t.VendasProdutosCubo)
                .HasForeignKey(d => d.ValorProdutoId);

        }
    }
}