using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class InutilizacaoNfeMap : EntityTypeConfiguration<InutilizacaoNfe>
    {
        public InutilizacaoNfeMap()
        {
            // Primary Key
            this.HasKey(t => t.InutilizacaoNfeId);

            // Properties
            this.Property(t => t.Ambiente)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.SiglaUf)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.Ano)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.Cnpj)
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.NumeroInicial)
                .HasMaxLength(9);

            this.Property(t => t.NumeroFinal)
                .HasMaxLength(9);

            // Table & Column Mappings
            this.ToTable("INUTILIZACOES_NFE");
            this.Property(t => t.InutilizacaoNfeId).HasColumnName("ID_INUT");
            this.Property(t => t.Ambiente).HasColumnName("AMBIENTE_INUT");
            this.Property(t => t.SiglaUf).HasColumnName("SIGLA_UF");
            this.Property(t => t.Ano).HasColumnName("ANO_INUT");
            this.Property(t => t.Cnpj).HasColumnName("CNPJ_INUT");
            this.Property(t => t.Modelo).HasColumnName("MODELO_INUT");
            this.Property(t => t.Serie).HasColumnName("SERIE_INUT");
            this.Property(t => t.NumeroInicial).HasColumnName("NUMERO_INICIAL_INUT");
            this.Property(t => t.NumeroFinal).HasColumnName("NUMERO_FINAL_INUT");
            this.Property(t => t.Justificativa).HasColumnName("JUSTIFICATIVA_INUT");
            this.Property(t => t.LojaId).HasColumnName("COD_LOJA");
        }
    }
}