using Rcky.MasterRetail2.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class GrupoFaturamentoMap : EntityTypeConfiguration<GrupoFaturamento>
    {
        public GrupoFaturamentoMap()
        {
            // Primary Key
            this.HasKey(t => t.GrupoFaturamentoId);

            // Properties
            this.Property(t => t.GrupoFaturamentoId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Descricao)
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("GRUPOS_FATURAMENTOS");
            this.Property(t => t.GrupoFaturamentoId).HasColumnName("COD_GRFT");
            this.Property(t => t.Descricao).HasColumnName("DESC_GRFT");
            this.Property(t => t.Cf).HasColumnName("CF_GRFT");
            this.Property(t => t.Cst).HasColumnName("CST_GRFT");
            this.Property(t => t.UnidadeId).HasColumnName("ID_UNID");

            //Relationships
            this.HasOptional(t => t.Unidade)
                .WithMany(t => t.GruposFaturamento)
                .HasForeignKey(d => d.UnidadeId);
        }
    }
}