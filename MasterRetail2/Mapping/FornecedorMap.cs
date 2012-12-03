using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class FornecedorMap : EntityTypeConfiguration<Fornecedor>
    {
        public FornecedorMap()
        {
            // Primary Key
            this.HasKey(t => t.FornecedorId);

            // Properties
            this.Property(t => t.AtivoString)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Ignore(t => t.Ativo);

            // Table & Column Mappings
            this.ToTable("FORNECEDORES");
            this.Property(t => t.FornecedorId).HasColumnName("COD_FORN");
            this.Property(t => t.PessoaId).HasColumnName("ID_PESSOA");
            this.Property(t => t.AtivoString).HasColumnName("ATIVO_FORN");

            // Relationships
            this.HasOptional(t => t.Pessoa)
                .WithMany(t => t.Fornecedores)
                .HasForeignKey(d => d.PessoaId);

        }
    }
}