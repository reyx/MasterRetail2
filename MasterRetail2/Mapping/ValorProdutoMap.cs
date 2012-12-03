using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class ValorProdutoMap : EntityTypeConfiguration<ValorProduto>
    {
        public ValorProdutoMap()
        {
            // Primary Key
            this.HasKey(t => t.ValorProdutoId);

            // Properties
            // Table & Column Mappings
            this.ToTable("VALORES_PRODUTO");
            this.Property(t => t.ValorProdutoId).HasColumnName("ID_VLPR");
            this.Property(t => t.ProdutoId).HasColumnName("COD_PROD");
            this.Property(t => t.ValorPropriedade1Id).HasColumnName("ID_VLPR01");
            this.Property(t => t.ValorPropriedade2Id).HasColumnName("ID_VLPR02");
            this.Property(t => t.ValorPropriedade3Id).HasColumnName("ID_VLPR03");

            // Relationships
            this.HasOptional(t => t.Produto)
                .WithMany(t => t.Valores)
                .HasForeignKey(d => d.ProdutoId);

            this.HasOptional(t => t.ValorPropriedade1)
                .WithMany(t => t.ValoresProduto1)
                .HasForeignKey(d => d.ValorPropriedade1Id);

            this.HasOptional(t => t.ValorPropriedade2)
                .WithMany(t => t.ValoresProduto2)
                .HasForeignKey(d => d.ValorPropriedade2Id);

            this.HasOptional(t => t.ValorPropriedade3)
                .WithMany(t => t.ValoresProduto3)
                .HasForeignKey(d => d.ValorPropriedade3Id);

        }
    }
}