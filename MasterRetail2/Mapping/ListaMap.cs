using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class ListaMap : EntityTypeConfiguration<Lista>
    {
        public ListaMap()
        {
            // Primary Key
            this.HasKey(t => t.ListaId);

            // Properties
            this.Property(t => t.Descricao)
                .HasMaxLength(40);

            this.Property(t => t.Preco)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("LISTAS");
            this.Property(t => t.ListaId).HasColumnName("COD_LISTA");
            this.Property(t => t.Descricao).HasColumnName("DESC_LISTA");
            this.Property(t => t.InicioValidade).HasColumnName("VALIDADE_INICIO_LISTA");
            this.Property(t => t.TerminoValidade).HasColumnName("VALIDADE_TERMINO_LISTA");
            this.Property(t => t.Preco).HasColumnName("CPOPRECO_LISTA");
        }
    }
}