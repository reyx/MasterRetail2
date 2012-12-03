using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class OrigemProdutoMap : EntityTypeConfiguration<OrigemProduto>
    {
        public OrigemProdutoMap()
        {
            // Primary Key
            this.HasKey(t => t.OrigemProdutoId);

            // Properties
            this.Property(t => t.Descricao)
                .HasMaxLength(50);

            this.Property(t => t.Codigo)
                .HasMaxLength(3);

            // Table & Column Mappings
            this.ToTable("ORIGENS_PRODUTOS");
            this.Property(t => t.OrigemProdutoId).HasColumnName("ID_ORIG");
            this.Property(t => t.Descricao).HasColumnName("DESC_ORIG");
            this.Property(t => t.Codigo).HasColumnName("COD_ORIG");
        }
    }
}