using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class DocumentoMap : EntityTypeConfiguration<Documento>
    {
        public DocumentoMap()
        {
            // Primary Key
            this.HasKey(t => t.DocumentoId);

            // Properties
            this.Property(t => t.Descricao)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.ObrigatorioString)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Ignore(t => t.Obrigatorio);

            this.Property(t => t.ChecadoString)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Ignore(t => t.Checado);

            // Table & Column Mappings
            this.ToTable("DOCUMENTOS");
            this.Property(t => t.DocumentoId).HasColumnName("COD_DOC");
            this.Property(t => t.Descricao).HasColumnName("DESC_DOC");
            this.Property(t => t.ObrigatorioString).HasColumnName("OBRIG_DOC");
            this.Property(t => t.ChecadoString).HasColumnName("CHECK_DOC");
        }
    }
}