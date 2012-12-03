using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class DocumentoPessoaMap : EntityTypeConfiguration<DocumentoPessoa>
    {
        public DocumentoPessoaMap()
        {
            // Primary Key
            this.HasKey(t => t.DocumentoPessoaId);

            // Properties
            this.Property(t => t.Valor)
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("DOCUMENTOS_PESSOA");
            this.Property(t => t.DocumentoPessoaId).HasColumnName("ID_DCPS");
            this.Property(t => t.PessoaId).HasColumnName("ID_PESSOA");
            this.Property(t => t.DocumentoId).HasColumnName("COD_DOC");
            this.Property(t => t.Valor).HasColumnName("VALOR_DCPS");
            this.Property(t => t.UfId).HasColumnName("ID_UF");

            // Relationships
            this.HasOptional(t => t.Pessoa)
                .WithMany(t => t.DocumentosPessoa)
                .HasForeignKey(d => d.PessoaId);

        }
    }
}