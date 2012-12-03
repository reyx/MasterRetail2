using Rcky.MasterRetail2.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class LojaMap : EntityTypeConfiguration<Loja>
    {
        public LojaMap()
        {
            // Primary Key
            this.HasKey(t => t.LojaId);

            // Properties
            this.Property(t => t.LojaId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Nome)
                .HasMaxLength(50);

            this.Property(t => t.AtivoString)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Ignore(t => t.Ativo);

            // Table & Column Mappings
            this.ToTable("LOJAS");
            this.Property(t => t.LojaId).HasColumnName("COD_LOJA");
            this.Property(t => t.Nome).HasColumnName("NOME_LOJA");
            this.Property(t => t.AtivoString).HasColumnName("ATIVO_LOJA");
            this.Property(t => t.PessoaId).HasColumnName("ID_PESSOA");
            this.Property(t => t.RegimeTributarioId).HasColumnName("ID_RGTR");
            this.Property(t => t.UltimaTransacao).HasColumnName("ULTTRANS_LOJA");
            this.Property(t => t.ListaId).HasColumnName("COD_LISTA");
            this.Property(t => t.CnaeId).HasColumnName("ID_CNAE");
            this.Property(t => t.AmbienteNfe).HasColumnName("AMBIENTENFE_LOJA");
            this.Property(t => t.Danfe).HasColumnName("DANFENFE_LOJA");

            // Relationships
            this.HasOptional(t => t.Lista)
                .WithMany(t => t.Lojas)
                .HasForeignKey(d => d.ListaId);

            this.HasOptional(t => t.Pessoa)
                .WithMany(t => t.Lojas)
                .HasForeignKey(d => d.PessoaId);

        }
    }
}