using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class EmailMap : EntityTypeConfiguration<Email>
    {
        public EmailMap()
        {
            // Primary Key
            this.HasKey(t => t.EmailId);

            // Properties
            this.Property(t => t.Endereco)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("EMAILS");
            this.Property(t => t.EmailId).HasColumnName("ID_EMAIL");
            this.Property(t => t.Endereco).HasColumnName("ENDERECO_EMAIL");
            this.Property(t => t.Observacao).HasColumnName("OBS_EMAIL");
            this.Property(t => t.PessoaId).HasColumnName("ID_PESSOA");

            // Relationships
            this.HasOptional(t => t.Pessoa)
                .WithMany(t => t.Emails)
                .HasForeignKey(d => d.PessoaId);

        }
    }
}