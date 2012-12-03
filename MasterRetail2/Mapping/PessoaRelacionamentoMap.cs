using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class PessoaRelacionamentoMap : EntityTypeConfiguration<PessoaRelacionamento>
    {
        public PessoaRelacionamentoMap()
        {
            // Primary Key
            this.HasKey(t => t.PessoaRelacionamentoId);

            // Properties
            // Table & Column Mappings
            this.ToTable("PESSOAS_RELACIONAMENTO");
            this.Property(t => t.PessoaRelacionamentoId).HasColumnName("ID_PSRL");
            this.Property(t => t.PessoaAId).HasColumnName("ID_PESSOAA");
            this.Property(t => t.PessoaBId).HasColumnName("ID_PESSOAB");
            this.Property(t => t.GrauRelacionamentoId).HasColumnName("COD_GRRL");
            this.Property(t => t.Data).HasColumnName("DATA_GRRL");

            // Relationships
            this.HasOptional(t => t.GrauRelacionamento)
                .WithMany(t => t.PessoasRelacionamento)
                .HasForeignKey(d => d.GrauRelacionamentoId);

            this.HasOptional(t => t.PessoaA)
                .WithMany(t => t.PessoasRelacionamentoA)
                .HasForeignKey(d => d.PessoaAId);

            this.HasOptional(t => t.PessoaB)
                .WithMany(t => t.PessoasRelacionamentoB)
                .HasForeignKey(d => d.PessoaBId);

        }
    }
}