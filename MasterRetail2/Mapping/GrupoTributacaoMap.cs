using Rcky.MasterRetail2.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class GrupoTributacaoMap : EntityTypeConfiguration<GrupoTributacaoProduto>
    {
        public GrupoTributacaoMap()
        {
            //Primary Key
            this.HasKey(t => t.GrupoTributacaoProdutoId);

            //Properties
            this.Property(t => t.GrupoTributacaoProdutoId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Descricao)
                .HasMaxLength(60);

            //Table & Column Mappings
            this.ToTable("GRUPOS_TRIBUTACAO_PRODUTOS");
            this.Property(t => t.GrupoTributacaoProdutoId).HasColumnName("COD_GRTP");
            this.Property(t => t.Descricao).HasColumnName("DESC_GRTP");
            this.Property(t => t.TributacaoOrigemId).HasColumnName("ORIGEM_GRTP");
            this.Property(t => t.TributacaoIcmsId).HasColumnName("TICMS_GRTP");
            this.Property(t => t.TributacaoIpiId).HasColumnName("TIPI_GRTP");
            this.Property(t => t.TributacaoPisId).HasColumnName("TPIS_GRTP");
            this.Property(t => t.TributacaoCofinsId).HasColumnName("TCOFINS_GRTP");

            //Relationships
            this.HasOptional(t => t.TributacaoCofins)
                .WithMany(t => t.GruposTributacaoProdutoCofins)
                .HasForeignKey(d => d.TributacaoCofinsId);

            this.HasOptional(t => t.TributacaoIcms)
                .WithMany(t => t.GruposTributacaoProdutoIcms)
                .HasForeignKey(d => d.TributacaoIcmsId);

            this.HasOptional(t => t.TributacaoIpi)
                .WithMany(t => t.GruposTributacaoProdutoIpi)
                .HasForeignKey(d => d.TributacaoIpiId);

            this.HasOptional(t => t.TributacaoOrigem)
                .WithMany(t => t.GruposTributacaoProdutoOrigem)
                .HasForeignKey(d => d.TributacaoOrigemId);

            this.HasOptional(t => t.TributacaoPis)
                .WithMany(t => t.GruposTributacaoProdutoPis)
                .HasForeignKey(d => d.TributacaoPisId);
        }
    }
}