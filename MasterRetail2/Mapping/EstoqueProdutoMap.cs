using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class EstoqueProdutoMap : EntityTypeConfiguration<EstoqueProduto>
    {
        public EstoqueProdutoMap()
        {
            // Primary Key
            this.HasKey(t => t.EstoqueProdutoId);

            // Properties
            // Table & Column Mappings
            this.ToTable("ESTOQUES_PRODUTO");
            this.Property(t => t.EstoqueProdutoId).HasColumnName("ID_ESPR");
            this.Property(t => t.LocalEstoqueId).HasColumnName("COD_LCES");
            this.Property(t => t.ValorPropriedadeId).HasColumnName("ID_VLPR");
            this.Property(t => t.LojaId).HasColumnName("COD_LOJA");
            this.Property(t => t.Extoque).HasColumnName("ESTOQUE_ESPR");

            // Relationships
            this.HasOptional(t => t.LocalEstoque)
                .WithMany(t => t.EstoquesProduto)
                .HasForeignKey(d => d.LocalEstoqueId);

            this.HasOptional(t => t.Loja)
                .WithMany(t => t.EstoquesProduto)
                .HasForeignKey(d => d.LojaId);

            this.HasOptional(t => t.ValorProduto)
                .WithMany(t => t.EstoquesProduto)
                .HasForeignKey(d => d.ValorPropriedadeId);

        }
    }
}