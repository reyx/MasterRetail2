using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class EstoqueProdutoCuboMap : EntityTypeConfiguration<EstoqueProdutoCubo>
    {
        public EstoqueProdutoCuboMap()
        {
            // Primary Key
            this.HasKey(t => t.EstoqueProdutoCuboId);

            // Properties
            // Table & Column Mappings
            this.ToTable("ESTOQUES_PRODUTOS_CUBO");
            this.Property(t => t.EstoqueProdutoCuboId).HasColumnName("ID_EPCB");
            this.Property(t => t.LocalEstoqueId).HasColumnName("COD_LCES");
            this.Property(t => t.ValorProdutoId).HasColumnName("ID_VLPR");
            this.Property(t => t.Estoque).HasColumnName("ESTOQUE_ESPR");

            // Relationships
            this.HasOptional(t => t.LocalEstoque)
                .WithMany(t => t.EstoquesProdutoCubo)
                .HasForeignKey(d => d.LocalEstoqueId);

            this.HasOptional(t => t.ValorProduto)
                .WithMany(t => t.EstoquesProdutoCubo)
                .HasForeignKey(d => d.ValorProdutoId);

        }
    }
}