using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class TipoEnderecoMap : EntityTypeConfiguration<TipoEndereco>
    {
        public TipoEnderecoMap()
        {
            // Primary Key
            this.HasKey(t => t.TipoEnderecoId);

            // Properties
            this.Property(t => t.Descricao)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TIPOS_ENDERECO");
            this.Property(t => t.TipoEnderecoId).HasColumnName("ID_TPEN");
            this.Property(t => t.Descricao).HasColumnName("DESCR_TPEN");
            this.Property(t => t.Imagem).HasColumnName("IMAGEM_TPEN");
        }
    }
}