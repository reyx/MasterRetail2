using Rcky.MasterRetail2.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class GrupoProdutoMap : EntityTypeConfiguration<GrupoProduto>
    {
        public GrupoProdutoMap()
        {
            // Primary Key
            this.HasKey(t => t.GrupoProdutoId);

            // Properties
            this.Property(t => t.GrupoProdutoId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Descricao)
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("GRUPOS_PRODUTOS");
            this.Property(t => t.GrupoProdutoId).HasColumnName("COD_GRPR");
            this.Property(t => t.Descricao).HasColumnName("DESC_GRPR");
        }
    }
}