using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class TelefoneMap : EntityTypeConfiguration<Telefone>
    {
        public TelefoneMap()
        {
            // Primary Key
            this.HasKey(t => t.TelefoneId);

            // Properties
            this.Property(t => t.Numero)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("TELEFONES");
            this.Property(t => t.TelefoneId).HasColumnName("ID_FONE");
            this.Property(t => t.Numero).HasColumnName("NUMERO_FONE");
            this.Property(t => t.Observacao).HasColumnName("OBS_FONE");
            this.Property(t => t.PessoaId).HasColumnName("ID_PESSOA");

            // Relationships
            this.HasOptional(t => t.Pessoa)
                .WithMany(t => t.Telefones)
                .HasForeignKey(d => d.PessoaId);

        }
    }
}