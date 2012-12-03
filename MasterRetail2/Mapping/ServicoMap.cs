using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class ServicoMap : EntityTypeConfiguration<Servico>
    {
        public ServicoMap()
        {
            // Primary Key
            this.HasKey(t => t.ServicoId);

            // Properties
            this.Property(t => t.Descricao)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("SERVICOS");
            this.Property(t => t.ServicoId).HasColumnName("ID_SERV");
            this.Property(t => t.Codigo).HasColumnName("COD_SERV");
            this.Property(t => t.Descricao).HasColumnName("DESC_SERV");
        }
    }
}