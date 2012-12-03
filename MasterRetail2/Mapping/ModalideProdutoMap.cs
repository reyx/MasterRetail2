using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class ModalideProdutoMap : EntityTypeConfiguration<ModalidadeProduto>
    {
        public ModalideProdutoMap()
        {
            // Primary Key
            this.HasKey(t => t.ModalidadeProdutoId);

            // Properties
            this.Property(t => t.Codigo)
                .HasMaxLength(3);

            this.Property(t => t.Descricao)
                .HasMaxLength(50);

            this.Property(t => t.Tipo)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("MODALIDADES_PRODUTOS");
            this.Property(t => t.ModalidadeProdutoId).HasColumnName("ID_MDPD");
            this.Property(t => t.Codigo).HasColumnName("COD_MDPD");
            this.Property(t => t.Descricao).HasColumnName("DESC_MDPD");
            this.Property(t => t.Tipo).HasColumnName("TIPO_MDPD");
        }
    }
}