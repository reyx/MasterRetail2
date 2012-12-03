using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class EvolucaoCustoMap : EntityTypeConfiguration<EvolucaoCusto>
    {
        public EvolucaoCustoMap()
        {
            // Primary Key
            this.HasKey(t => t.EvolucaoCustoId);

            // Properties
            // Table & Column Mappings
            this.ToTable("EVOLUCAO_CUSTOS");
            this.Property(t => t.EvolucaoCustoId).HasColumnName("ID_EVCS");
            this.Property(t => t.ProdutoId).HasColumnName("COD_PROD");
            this.Property(t => t.Custo).HasColumnName("CUSTO_EVCS");
            this.Property(t => t.Data).HasColumnName("DATA_EVCS");
            this.Property(t => t.ListaId).HasColumnName("COD_LISTA");

            // Relationships
            this.HasOptional(t => t.Lista)
                .WithMany(t => t.EvolucoesCusto)
                .HasForeignKey(d => d.ListaId);

            this.HasOptional(t => t.Produto)
                .WithMany(t => t.EvolucoesCusto)
                .HasForeignKey(d => d.ProdutoId);

        }
    }
}