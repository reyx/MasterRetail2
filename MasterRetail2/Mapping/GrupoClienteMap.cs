using Rcky.MasterRetail2.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class GrupoClienteMap : EntityTypeConfiguration<GrupoCliente>
    {
        public GrupoClienteMap()
        {
            // Primary Key
            this.HasKey(t => t.GrupoClienteId);

            // Properties
            this.Property(t => t.GrupoClienteId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Descricao)
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("GRUPOS_CLIENTES");
            this.Property(t => t.GrupoClienteId).HasColumnName("COD_GRCL");
            this.Property(t => t.Descricao).HasColumnName("DESC_GRCL");
        }
    }
}