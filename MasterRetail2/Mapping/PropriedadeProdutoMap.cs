using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class PropriedadeProdutoMap : EntityTypeConfiguration<PropriedadeProduto>
    {
        public PropriedadeProdutoMap()
        {
            // Primary Key
            this.HasKey(t => t.PropriedadeProdutoId);

            // Properties
            // Table & Column Mappings
            this.ToTable("PROPRIEDADES_PRODUTO");
            this.Property(t => t.PropriedadeProdutoId).HasColumnName("ID_PRPD");
            this.Property(t => t.PropriedadeId).HasColumnName("COD_PROP");
            this.Property(t => t.ProdutoId).HasColumnName("COD_PROD");
            this.Property(t => t.Ordem).HasColumnName("ORDEM_PRPR");

            // Relationships
            this.HasOptional(t => t.Produto)
                .WithMany(t => t.Propriedades)
                .HasForeignKey(d => d.ProdutoId);

            this.HasOptional(t => t.Propriedade)
                .WithMany(t => t.Produtos)
                .HasForeignKey(d => d.PropriedadeId);

        }
    }
}