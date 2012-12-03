using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class FotoProdutoMap : EntityTypeConfiguration<FotoProduto>
    {
        public FotoProdutoMap()
        {
            // Primary Key
            this.HasKey(t => t.FotoProdutoId);

            // Properties
            this.Property(t => t.Descricao)
                .HasMaxLength(50);            

            // Table & Column Mappings
            this.ToTable("FOTOS_PRODUTO");
            this.Property(t => t.FotoProdutoId).HasColumnName("ID_FTPD");
            this.Property(t => t.ProdutoId).HasColumnName("COD_PROD");
            this.Property(t => t.Descricao).HasColumnName("DESC_FTPD");
            this.Property(t => t.Foto).HasColumnName("FOTO_FTPD");
            this.Property(t => t.Principal).HasColumnName("PRINCIPAL_FTPD");

            // Relationships
            this.HasOptional(t => t.Produto)
                .WithMany(t => t.Fotos)
                .HasForeignKey(d => d.ProdutoId);

        }
    }
}